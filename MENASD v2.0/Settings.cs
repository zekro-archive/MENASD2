using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MENASD_v2._0 {

    public partial class Settings : Form
    {
        Properties.Settings set = Properties.Settings.Default;

        public Settings()
        {
            InitializeComponent();
            tbLogFile.Text = set.logFileDir;
            tbPushToken.Text = set.PBToken;
            tbTask.Text = set.taskAfter;
            cbExecute.Checked = set.execTask;
            cbPush.Checked = set.usePB;
        }

        public static void save()
        {
            Properties.Settings.Default.Save();
        }

        private void tbPushToken_TextChanged(object sender, EventArgs e)
        {
            if (tbPushToken.Text.Length < 1)
            {
                cbPush.Enabled = false;
                cbPush.Checked = false;
            }
            else
            {
                cbPush.Enabled = true;
            }
        }

        private void tbTask_TextChanged(object sender, EventArgs e)
        {
            if (tbTask.Text.Length < 1)
            {
                cbExecute.Enabled = false;
                cbExecute.Checked = false;
            }
            else
            {
                cbExecute.Enabled = true;
            }
        }

        private void llbDetPb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://gist.github.com/zekroTJA/75d172968db923afce5272e54d431e4d");
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            if (fbd.SelectedPath != "")
            {
                set.logFileDir = fbd.SelectedPath + "\\MENASD_log.txt";
                tbLogFile.Text = set.logFileDir;
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            set.logFileDir = tbLogFile.Text;
            set.PBToken = tbPushToken.Text;
            set.taskAfter = tbTask.Text;
            set.usePB = cbPush.Checked;
            set.execTask = cbExecute.Checked;
            save();

            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
