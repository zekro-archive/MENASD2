namespace MENASD_v2._0
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbStatusBar = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.rbExecute = new System.Windows.Forms.RadioButton();
            this.rbSleep = new System.Windows.Forms.RadioButton();
            this.rbShutdown = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbLog = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numbDelayS = new System.Windows.Forms.NumericUpDown();
            this.numbDelayM = new System.Windows.Forms.NumericUpDown();
            this.btSettings = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btInfo = new System.Windows.Forms.Button();
            this.lbTaskStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbDelayS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbDelayM)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStatusBar
            // 
            this.lbStatusBar.AutoSize = true;
            this.lbStatusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 300F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusBar.Location = new System.Drawing.Point(-143, -95);
            this.lbStatusBar.Name = "lbStatusBar";
            this.lbStatusBar.Size = new System.Drawing.Size(301, 453);
            this.lbStatusBar.TabIndex = 0;
            this.lbStatusBar.Text = "I";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(24, 11);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(164, 30);
            this.lbStatus.TabIndex = 1;
            this.lbStatus.Text = "AME not started";
            // 
            // rbExecute
            // 
            this.rbExecute.AutoSize = true;
            this.rbExecute.Location = new System.Drawing.Point(21, 73);
            this.rbExecute.Name = "rbExecute";
            this.rbExecute.Size = new System.Drawing.Size(64, 17);
            this.rbExecute.TabIndex = 3;
            this.rbExecute.TabStop = true;
            this.rbExecute.Text = "Execute";
            this.rbExecute.UseVisualStyleBackColor = true;
            this.rbExecute.CheckedChanged += new System.EventHandler(this.rbExecute_CheckedChanged);
            // 
            // rbSleep
            // 
            this.rbSleep.AutoSize = true;
            this.rbSleep.Location = new System.Drawing.Point(21, 50);
            this.rbSleep.Name = "rbSleep";
            this.rbSleep.Size = new System.Drawing.Size(52, 17);
            this.rbSleep.TabIndex = 4;
            this.rbSleep.TabStop = true;
            this.rbSleep.Text = "Sleep";
            this.rbSleep.UseVisualStyleBackColor = true;
            this.rbSleep.CheckedChanged += new System.EventHandler(this.rbSleep_CheckedChanged);
            // 
            // rbShutdown
            // 
            this.rbShutdown.AutoSize = true;
            this.rbShutdown.Location = new System.Drawing.Point(21, 27);
            this.rbShutdown.Name = "rbShutdown";
            this.rbShutdown.Size = new System.Drawing.Size(73, 17);
            this.rbShutdown.TabIndex = 2;
            this.rbShutdown.TabStop = true;
            this.rbShutdown.Text = "Shutdown";
            this.rbShutdown.UseVisualStyleBackColor = true;
            this.rbShutdown.CheckedChanged += new System.EventHandler(this.rbShutdown_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbShutdown);
            this.groupBox1.Controls.Add(this.rbSleep);
            this.groupBox1.Controls.Add(this.rbExecute);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(29, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 116);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TASK";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbLog);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numbDelayS);
            this.groupBox2.Controls.Add(this.numbDelayM);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(179, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 116);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TASK";
            // 
            // cbLog
            // 
            this.cbLog.AutoSize = true;
            this.cbLog.Location = new System.Drawing.Point(23, 83);
            this.cbLog.Name = "cbLog";
            this.cbLog.Size = new System.Drawing.Size(84, 17);
            this.cbLog.TabIndex = 5;
            this.cbLog.Text = "Write log file";
            this.cbLog.UseVisualStyleBackColor = true;
            this.cbLog.CheckedChanged += new System.EventHandler(this.cbLog_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Delay after finish:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "S";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "M";
            // 
            // numbDelayS
            // 
            this.numbDelayS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.numbDelayS.ForeColor = System.Drawing.Color.White;
            this.numbDelayS.Location = new System.Drawing.Point(101, 46);
            this.numbDelayS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numbDelayS.Name = "numbDelayS";
            this.numbDelayS.Size = new System.Drawing.Size(48, 20);
            this.numbDelayS.TabIndex = 1;
            this.numbDelayS.ValueChanged += new System.EventHandler(this.numbDelayS_ValueChanged);
            // 
            // numbDelayM
            // 
            this.numbDelayM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.numbDelayM.ForeColor = System.Drawing.Color.White;
            this.numbDelayM.Location = new System.Drawing.Point(23, 46);
            this.numbDelayM.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numbDelayM.Name = "numbDelayM";
            this.numbDelayM.Size = new System.Drawing.Size(48, 20);
            this.numbDelayM.TabIndex = 0;
            // 
            // btSettings
            // 
            this.btSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSettings.Location = new System.Drawing.Point(147, 219);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(100, 23);
            this.btSettings.TabIndex = 7;
            this.btSettings.Text = "Settings";
            this.btSettings.UseVisualStyleBackColor = false;
            this.btSettings.Click += new System.EventHandler(this.btSettings_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btCancel.Enabled = false;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Location = new System.Drawing.Point(267, 219);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(100, 23);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btInfo
            // 
            this.btInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInfo.Location = new System.Drawing.Point(29, 219);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(100, 23);
            this.btInfo.TabIndex = 9;
            this.btInfo.Text = "Info";
            this.btInfo.UseVisualStyleBackColor = false;
            this.btInfo.Click += new System.EventHandler(this.btInfo_Click);
            // 
            // lbTaskStatus
            // 
            this.lbTaskStatus.AutoSize = true;
            this.lbTaskStatus.Location = new System.Drawing.Point(29, 187);
            this.lbTaskStatus.Name = "lbTaskStatus";
            this.lbTaskStatus.Size = new System.Drawing.Size(155, 13);
            this.lbTaskStatus.TabIndex = 10;
            this.lbTaskStatus.Text = "Waiting for signal to start task...";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(392, 264);
            this.Controls.Add(this.lbTaskStatus);
            this.Controls.Add(this.btInfo);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSettings);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbStatusBar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "MENASD v2.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbDelayS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbDelayM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbExecute;
        private System.Windows.Forms.RadioButton rbSleep;
        private System.Windows.Forms.RadioButton rbShutdown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numbDelayM;
        private System.Windows.Forms.NumericUpDown numbDelayS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbLog;
        private System.Windows.Forms.Button btSettings;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btInfo;
        public System.Windows.Forms.Label lbStatusBar;
        public System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbTaskStatus;
    }
}

