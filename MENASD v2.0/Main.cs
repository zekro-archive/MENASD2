using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CSCore.CoreAudioAPI;

namespace MENASD_v2._0
{
    public partial class Main : Form
    {
        Properties.Settings set = Properties.Settings.Default;
        Logger logger = new Logger();

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

            if (set.writeLog)
                logger.log("Started MENASD 2.0", set.logFileDir);
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
                    if (!checkSound.Enabled)
                        checkSound_start();
                    break;

                case 2:
                    lbStatusBar.ForeColor = Color.Cyan;
                    lbStatus.ForeColor = Color.Cyan;
                    lbStatus.Text = "Finished, task executed.";
                    ameState.Stop();
                    handleTask(false);
                    btCancel.Enabled = true;
                    break;

                case 3:
                    lbStatusBar.ForeColor = Color.Orange;
                    lbStatus.ForeColor = Color.Orange;
                    lbStatus.Text = "Task caneled.";
                    handleTask(true);
                    break;
            }
        }

        private void handleTask(bool cancel)
        {
            decimal delay = numbDelayM.Value * 60 + numbDelayS.Value;

            sendPush(delay, cancel);
            setLabel(delay, cancel);

            switch (set.task)
            {

                // SHUTDOWN
                case 0:
                    if (cancel)
                    {
                        Process.Start("shutdown", "/a");
                        if (set.writeLog)
                            logger.log("Shutdown canceled manually", set.logFileDir);
                    }
                    else
                    {
                        Process.Start("shutdown", "/s /t " + delay.ToString());
                        if (set.writeLog)
                            logger.log(String.Format("Shutdown initialized in {0} seconds", delay), set.logFileDir);
                    }
                    break;

                // STANDBY
                case 1:
                    if (cancel)
                    {
                        if (handleTaskDelay.Enabled)
                            handleTaskDelay.Stop();
                        if (set.writeLog)
                            logger.log("Standby canceled manually", set.logFileDir);
                    }
                    else
                    {
                        if (delay == 0)
                            Application.SetSuspendState(PowerState.Suspend, true, true);
                        else
                        {
                            decimal current = 0;
                            handleTaskDelay.Interval = 1000;
                            handleTaskDelay.Tick += new EventHandler((object sender, EventArgs e) =>
                            {
                                if (delay <= current++)
                                {
                                    Application.SetSuspendState(PowerState.Suspend, true, true);
                                    handleTaskDelay.Stop();
                                }
                            });
                        }
                        if (set.writeLog)
                            logger.log(String.Format("Standby initialized in {0} seconds", delay), set.logFileDir);
                    }
                    break;

                // EXECUTE COMMAND
                case 2:
                    if (cancel)
                    {
                        if (handleTaskDelay.Enabled)
                            handleTaskDelay.Stop();
                        if (set.writeLog)
                            logger.log("Command execution canceled manually", set.logFileDir);
                    }
                    else
                    {
                        if (set.taskAfter == "" || set.taskAfter == null)
                        {
                            MessageBox.Show("No execute task set", "Because no execute task was set in settings, no task was executed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (set.writeLog)
                                logger.log("No execute task set", set.logFileDir);
                            return;
                        }

                        if (delay == 0)
                        {
                            string t = set.taskAfter;
                            List<string> call = new List<string>();
                            if (!(t.StartsWith("\"") || t.StartsWith("\'")))
                                Process.Start(t.Split(' ')[0], String.Join(" ", t.Split(' ').Skip(1)));
                            else
                                Process.Start(t);
                        }
                        else
                        {
                            decimal current = 0;
                            handleTaskDelay.Interval = 1000;
                            handleTaskDelay.Tick += new EventHandler((object sender, EventArgs e) =>
                            {
                                if (delay <= current++)
                                {
                                    string t = set.taskAfter;
                                    List<string> call = new List<string>();
                                    if (!(t.StartsWith("\"") || t.StartsWith("\'")))
                                        Process.Start(t.Split(' ')[0], String.Join(" ", t.Split(' ').Skip(1)));
                                    else
                                        Process.Start(t);

                                    handleTaskDelay.Stop();
                                }
                            });
                        }

                        if (set.writeLog)
                            logger.log(String.Format("Command execution initialized in {0} seconds", delay), set.logFileDir);
                    }
                    break;
            }
        }

        private void sendPush(decimal delay, bool calcel)
        {

        }

        private void setLabel(decimal delay, bool cancel)
        {
            string[] states = { "Initializing shutdown in {0} minutes and {1} seconds.", "Initializing standby in {0} minutes and {1} seconds.", "Command will be executed in {0} minutes and {1} seconds." };
            
            decimal min = (int)(delay / 60),
                    sec = delay % 60;

            if (cancel)
                lbTaskStatus.Text = "Task canceled.";
            else
            {
                labelTimer.Interval = 1000;
                labelTimer.Tick += new EventHandler((object o, EventArgs e) =>
                {
                    lbTaskStatus.Text = String.Format(states[set.task], min, sec);
                });
                labelTimer.Start();
            }
        }

        void detectedSound()
        {
            handleState(2);
        }


        private static AudioSessionManager2 getDefaultAudioSessionManager2(DataFlow dataFlow)
        {
            using (var enumerator = new MMDeviceEnumerator())
            {
                using (var device = enumerator.GetDefaultAudioEndpoint(dataFlow, Role.Multimedia))
                {
                    Debug.WriteLine("DefaultDevice: " + device.FriendlyName);
                    var sessionManager = AudioSessionManager2.FromMMDevice(device);
                    return sessionManager;
                }
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
            if (taskStatus == 2)
            {
                handleTaskDelay.Stop();
                handleState(3);
            }
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

        Timer handleTaskDelay = new Timer(),
              labelTimer = new Timer(), 
              ameState = new Timer(),
              checkSound = new Timer();


        private void ameState_start()
        {
            ameState.Interval = 1000;
            ameState.Tick += new EventHandler(ameState_tick);
            ameState.Start();

            if (set.writeLog)
                logger.log("Status check timer started", set.logFileDir);
        }

        private void ameState_tick(object sender, EventArgs e)
        {
            Process[] p = Process.GetProcessesByName("Adobe Media Encoder");
            if (taskStatus < 2)
                handleState(p.Length > 0 ? 1 : 0);
        }


        AudioSessionControl2 session;

        private void checkSound_start()
        {
            checkSound.Interval = 250;
            checkSound.Tick += new EventHandler(checkSound_tick);
            checkSound.Start();

            AudioSessionEnumerator sesenum = getDefaultAudioSessionManager2(DataFlow.Render).GetSessionEnumerator();

            foreach (AudioSessionControl s in sesenum)
                if (s.QueryInterface<AudioSessionControl2>().Process.MainWindowTitle.Contains("Adobe Media Encoder"))
                    session = s.QueryInterface<AudioSessionControl2>();

            if (set.writeLog)
                logger.log("Audio system check timer initialized and started", set.logFileDir);

        }

        private void checkSound_tick(object sender, EventArgs e)
        {
            float audio = session.QueryInterface<AudioMeterInformation>().PeakValue;

            if (audio > 0.1) 
            {
                detectedSound();
                checkSound.Stop();
            }
        }

        #endregion

    }
}
