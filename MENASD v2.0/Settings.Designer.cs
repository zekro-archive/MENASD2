namespace MENASD_v2._0
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.tbLogFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPush = new System.Windows.Forms.CheckBox();
            this.llbDetPb = new System.Windows.Forms.LinkLabel();
            this.tbPushToken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbExecute = new System.Windows.Forms.CheckBox();
            this.tbTask = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btOpen);
            this.groupBox1.Controls.Add(this.tbLogFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 90);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOGGING";
            // 
            // btOpen
            // 
            this.btOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpen.Location = new System.Drawing.Point(220, 49);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(74, 23);
            this.btOpen.TabIndex = 10;
            this.btOpen.Text = "Open...";
            this.btOpen.UseVisualStyleBackColor = false;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // tbLogFile
            // 
            this.tbLogFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tbLogFile.ForeColor = System.Drawing.Color.White;
            this.tbLogFile.Location = new System.Drawing.Point(18, 51);
            this.tbLogFile.Name = "tbLogFile";
            this.tbLogFile.Size = new System.Drawing.Size(186, 20);
            this.tbLogFile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log File Location:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPush);
            this.groupBox2.Controls.Add(this.llbDetPb);
            this.groupBox2.Controls.Add(this.tbPushToken);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 115);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PUSHBULLET API";
            // 
            // cbPush
            // 
            this.cbPush.AutoSize = true;
            this.cbPush.Enabled = false;
            this.cbPush.Location = new System.Drawing.Point(18, 83);
            this.cbPush.Name = "cbPush";
            this.cbPush.Size = new System.Drawing.Size(193, 17);
            this.cbPush.TabIndex = 6;
            this.cbPush.Text = "Send push message after rendering";
            this.cbPush.UseVisualStyleBackColor = true;
            // 
            // llbDetPb
            // 
            this.llbDetPb.ActiveLinkColor = System.Drawing.Color.White;
            this.llbDetPb.AutoSize = true;
            this.llbDetPb.LinkColor = System.Drawing.Color.White;
            this.llbDetPb.Location = new System.Drawing.Point(191, 26);
            this.llbDetPb.Name = "llbDetPb";
            this.llbDetPb.Size = new System.Drawing.Size(103, 13);
            this.llbDetPb.TabIndex = 2;
            this.llbDetPb.TabStop = true;
            this.llbDetPb.Text = "Where do I get this?";
            this.llbDetPb.VisitedLinkColor = System.Drawing.Color.White;
            this.llbDetPb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDetPb_LinkClicked);
            // 
            // tbPushToken
            // 
            this.tbPushToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tbPushToken.ForeColor = System.Drawing.Color.White;
            this.tbPushToken.Location = new System.Drawing.Point(18, 51);
            this.tbPushToken.Name = "tbPushToken";
            this.tbPushToken.Size = new System.Drawing.Size(276, 20);
            this.tbPushToken.TabIndex = 1;
            this.tbPushToken.TextChanged += new System.EventHandler(this.tbPushToken_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pushpullet Account Token:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbExecute);
            this.groupBox3.Controls.Add(this.tbTask);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 115);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TASK EXECUTION";
            // 
            // cbExecute
            // 
            this.cbExecute.AutoSize = true;
            this.cbExecute.Enabled = false;
            this.cbExecute.Location = new System.Drawing.Point(18, 83);
            this.cbExecute.Name = "cbExecute";
            this.cbExecute.Size = new System.Drawing.Size(136, 17);
            this.cbExecute.TabIndex = 6;
            this.cbExecute.Text = "Execute after rendering";
            this.cbExecute.UseVisualStyleBackColor = true;
            // 
            // tbTask
            // 
            this.tbTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tbTask.ForeColor = System.Drawing.Color.White;
            this.tbTask.Location = new System.Drawing.Point(18, 51);
            this.tbTask.Name = "tbTask";
            this.tbTask.Size = new System.Drawing.Size(276, 20);
            this.tbTask.TabIndex = 1;
            this.tbTask.TextChanged += new System.EventHandler(this.tbTask_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Command Line To Execute:";
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Location = new System.Drawing.Point(12, 381);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(152, 23);
            this.btCancel.TabIndex = 14;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOk
            // 
            this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOk.Location = new System.Drawing.Point(172, 381);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(152, 23);
            this.btOk.TabIndex = 13;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = false;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(336, 416);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbLogFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel llbDetPb;
        private System.Windows.Forms.TextBox tbPushToken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbPush;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbExecute;
        private System.Windows.Forms.TextBox tbTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
    }
}