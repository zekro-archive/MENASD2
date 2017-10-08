using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MENASD_v2._0
{
    public partial class Main : Form
    {
        Properties.Settings set = Properties.Settings.Default;

        int taskStatus = 0;


        public Main()
        {
            InitializeComponent();

            #region Load Preferences

            switch (set.task)
            {
                case 0:
                    rbShutdown.Checked = true;
                    break;
                case 1:
                    rbSleep.Checked = true;
                    break;
                case 2:
                    rbExecute.Checked = true;
                    break;
            }

            cbLog.Checked = set.writeLog;

            #endregion

            ameState_start();

        }

        private void handleState(int state)
        {
            taskStatus = state;

            switch (state)
            {
                case 0:
                    lbStatusBar.ForeColor = Color.Red;
                    lbStatus.ForeColor = Color.Red;
                    lbStatus.Text = "AME not started.";
                    break;

                case 1:
                    lbStatusBar.ForeColor = Color.Lime;
                    lbStatus.ForeColor = Color.Lime;
                    lbStatus.Text = "System ready and listening.";
                    break;

                case 2:
                    lbStatusBar.ForeColor = Color.Cyan;
                    lbStatus.ForeColor = Color.Cyan;
                    lbStatus.Text = "Finished, task executed.";
                    break;

                case 3:
                    lbStatusBar.ForeColor = Color.Orange;
                    lbStatus.ForeColor = Color.Orange;
                    lbStatus.Text = "Task caneled.";
                    break;
            }
        }


        #region Events

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void numbDelayS_ValueChanged(object sender, EventArgs e)
        {
            decimal val = numbDelayS.Value;

            if (val > 59)
            {
                numbDelayS.Value = 0;
                numbDelayM.Value += 1;
            }

            if (val == -1)
                numbDelayS.Value = 59;
        }

        private void btSettings_Click(object sender, EventArgs e)
        {
            new Settings().ShowDialog();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
        }

        private void btInfo_Click(object sender, EventArgs e)
        {
            new Info().ShowDialog();
        }

        private void cbLog_CheckedChanged(object sender, EventArgs e)
        {
            set.writeLog = cbLog.Checked;
            if ((set.logFileDir == null || set.logFileDir == "") && cbLog.Checked)
            {
                MessageBox.Show("Log file path is empty! Please check your settings!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbLog.Checked = false;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine(set.task);
            set.Save();
        }

        #endregion

        #region Task Checks
        private void rbShutdown_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShutdown.Checked)
                set.task = 0;
        }

        private void rbSleep_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSleep.Checked)
                set.task = 1;
        }

        private void rbExecute_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExecute.Checked)
                set.task = 2;
        }
        #endregion
        
        #region Timers

        Timer ameState = new Timer();

        private void ameState_start()
        {
            ameState.Interval = 1000;
            ameState.Tick += new EventHandler(ameState_tick);
            ameState.Start();
        }

        private void ameState_tick(object sender, EventArgs e)
        {
            Process[] p = Process.GetProcessesByName("Adobe Media Encoder");
            if (taskStatus < 2)
                handleState(p.Length > 0 ? 1 : 0);
        }

        #endregion

    }
}
