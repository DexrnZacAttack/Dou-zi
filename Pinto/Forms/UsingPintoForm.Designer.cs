namespace PintoNS.Forms
{
    partial class UsingPintoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsingPintoForm));
            this.tpRegister = new System.Windows.Forms.TabPage();
            this.btnRegisterBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRegisterIP = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudRegisterPort = new System.Windows.Forms.NumericUpDown();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRegisterUsername = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tpMain = new System.Windows.Forms.TabPage();
            this.LinkToDebugUI = new System.Windows.Forms.LinkLabel();
            this.btnRegisterPage = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.llForgotPassword = new System.Windows.Forms.LinkLabel();
            this.pLoginControls = new System.Windows.Forms.Panel();
            this.txtIP = new System.Windows.Forms.ComboBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbSavePassword = new System.Windows.Forms.CheckBox();
            this.tcSections = new System.Windows.Forms.TabControl();
            this.pbAd = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tpRegister.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegisterPort)).BeginInit();
            this.tpMain.SuspendLayout();
            this.pLoginControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.tcSections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tpRegister
            // 
            this.tpRegister.Controls.Add(this.pictureBox1);
            this.tpRegister.Controls.Add(this.btnRegisterBack);
            this.tpRegister.Controls.Add(this.panel1);
            this.tpRegister.Controls.Add(this.btnRegister);
            this.tpRegister.Location = new System.Drawing.Point(4, 22);
            this.tpRegister.Name = "tpRegister";
            this.tpRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegister.Size = new System.Drawing.Size(412, 275);
            this.tpRegister.TabIndex = 1;
            this.tpRegister.Text = "Register";
            this.tpRegister.UseVisualStyleBackColor = true;
            // 
            // btnRegisterBack
            // 
            this.btnRegisterBack.Location = new System.Drawing.Point(163, 220);
            this.btnRegisterBack.Name = "btnRegisterBack";
            this.btnRegisterBack.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterBack.TabIndex = 13;
            this.btnRegisterBack.Text = "Back";
            this.btnRegisterBack.UseVisualStyleBackColor = true;
            this.btnRegisterBack.Click += new System.EventHandler(this.btnRegisterBack_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtRegisterIP);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.nudRegisterPort);
            this.panel1.Controls.Add(this.txtRegisterPassword);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtRegisterUsername);
            this.panel1.Location = new System.Drawing.Point(30, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 65);
            this.panel1.TabIndex = 15;
            // 
            // txtRegisterIP
            // 
            this.txtRegisterIP.AutoCompleteCustomSource.AddRange(new string[] {
            "ponso00.com",
            "MYPinto.ddns.net"});
            this.txtRegisterIP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtRegisterIP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRegisterIP.FormattingEnabled = true;
            this.txtRegisterIP.Items.AddRange(new object[] {
            "ponso00.com",
            "MYPinto.ddns.net"});
            this.txtRegisterIP.Location = new System.Drawing.Point(234, 8);
            this.txtRegisterIP.Name = "txtRegisterIP";
            this.txtRegisterIP.Size = new System.Drawing.Size(106, 21);
            this.txtRegisterIP.TabIndex = 16;
            this.txtRegisterIP.Text = "ponso00.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "IP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Username:";
            // 
            // nudRegisterPort
            // 
            this.nudRegisterPort.Location = new System.Drawing.Point(243, 32);
            this.nudRegisterPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudRegisterPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRegisterPort.Name = "nudRegisterPort";
            this.nudRegisterPort.Size = new System.Drawing.Size(97, 20);
            this.nudRegisterPort.TabIndex = 3;
            this.nudRegisterPort.Value = new decimal(new int[] {
            2407,
            0,
            0,
            0});
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Location = new System.Drawing.Point(83, 32);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Size = new System.Drawing.Size(119, 20);
            this.txtRegisterPassword.TabIndex = 7;
            this.txtRegisterPassword.Text = "1234";
            this.txtRegisterPassword.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(208, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Port:";
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.Location = new System.Drawing.Point(83, 5);
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.Size = new System.Drawing.Size(119, 20);
            this.txtRegisterUsername.TabIndex = 6;
            this.txtRegisterUsername.Text = "example";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(96, 191);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(215, 23);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.LinkToDebugUI);
            this.tpMain.Controls.Add(this.pbAd);
            this.tpMain.Controls.Add(this.btnRegisterPage);
            this.tpMain.Controls.Add(this.btnCancel);
            this.tpMain.Controls.Add(this.llForgotPassword);
            this.tpMain.Controls.Add(this.pLoginControls);
            this.tpMain.Controls.Add(this.btnConnect);
            this.tpMain.Controls.Add(this.cbSavePassword);
            this.tpMain.Location = new System.Drawing.Point(4, 22);
            this.tpMain.Name = "tpMain";
            this.tpMain.Padding = new System.Windows.Forms.Padding(3);
            this.tpMain.Size = new System.Drawing.Size(412, 275);
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "Main";
            this.tpMain.UseVisualStyleBackColor = true;
            // 
            // LinkToDebugUI
            // 
            this.LinkToDebugUI.AutoSize = true;
            this.LinkToDebugUI.Location = new System.Drawing.Point(365, 255);
            this.LinkToDebugUI.Name = "LinkToDebugUI";
            this.LinkToDebugUI.Size = new System.Drawing.Size(39, 13);
            this.LinkToDebugUI.TabIndex = 15;
            this.LinkToDebugUI.TabStop = true;
            this.LinkToDebugUI.Text = "Debug";
            this.LinkToDebugUI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnRegisterPage
            // 
            this.btnRegisterPage.AutoSize = true;
            this.btnRegisterPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterPage.Location = new System.Drawing.Point(322, 191);
            this.btnRegisterPage.Name = "btnRegisterPage";
            this.btnRegisterPage.Size = new System.Drawing.Size(58, 16);
            this.btnRegisterPage.TabIndex = 14;
            this.btnRegisterPage.TabStop = true;
            this.btnRegisterPage.Text = "Register";
            this.btnRegisterPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnRegisterPage_LinkClicked);
            this.btnRegisterPage.Click += new System.EventHandler(this.BtnRegisterPage_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(168, 252);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(67, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // llForgotPassword
            // 
            this.llForgotPassword.AutoSize = true;
            this.llForgotPassword.Enabled = false;
            this.llForgotPassword.Location = new System.Drawing.Point(6, 255);
            this.llForgotPassword.Name = "llForgotPassword";
            this.llForgotPassword.Size = new System.Drawing.Size(114, 13);
            this.llForgotPassword.TabIndex = 10;
            this.llForgotPassword.TabStop = true;
            this.llForgotPassword.Text = "Forgot your password?";
            // 
            // pLoginControls
            // 
            this.pLoginControls.Controls.Add(this.txtIP);
            this.pLoginControls.Controls.Add(this.txtUsername);
            this.pLoginControls.Controls.Add(this.txtPassword);
            this.pLoginControls.Controls.Add(this.label1);
            this.pLoginControls.Controls.Add(this.label4);
            this.pLoginControls.Controls.Add(this.label3);
            this.pLoginControls.Controls.Add(this.nudPort);
            this.pLoginControls.Controls.Add(this.label2);
            this.pLoginControls.Location = new System.Drawing.Point(32, 120);
            this.pLoginControls.Name = "pLoginControls";
            this.pLoginControls.Size = new System.Drawing.Size(348, 70);
            this.pLoginControls.TabIndex = 10;
            // 
            // txtIP
            // 
            this.txtIP.AutoCompleteCustomSource.AddRange(new string[] {
            "ponso00.com",
            "MYPinto.ddns.net"});
            this.txtIP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtIP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtIP.FormattingEnabled = true;
            this.txtIP.Items.AddRange(new object[] {
            "ponso00.com",
            "luckys-lab.ga",
            "MYPinto.ddns.net"});
            this.txtIP.Location = new System.Drawing.Point(234, 8);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(106, 21);
            this.txtIP.TabIndex = 15;
            this.txtIP.Text = "ponso00.com";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(83, 8);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(119, 20);
            this.txtUsername.TabIndex = 14;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(83, 37);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(119, 20);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username:";
            // 
            // nudPort
            // 
            this.nudPort.Location = new System.Drawing.Point(243, 35);
            this.nudPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(97, 20);
            this.nudPort.TabIndex = 3;
            this.nudPort.Value = new decimal(new int[] {
            2407,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port:";
            // 
            // btnConnect
            // 
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnect.Location = new System.Drawing.Point(66, 221);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(273, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbSavePassword
            // 
            this.cbSavePassword.AutoSize = true;
            this.cbSavePassword.Checked = true;
            this.cbSavePassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSavePassword.Location = new System.Drawing.Point(39, 192);
            this.cbSavePassword.Name = "cbSavePassword";
            this.cbSavePassword.Size = new System.Drawing.Size(196, 17);
            this.cbSavePassword.TabIndex = 11;
            this.cbSavePassword.Text = "Store my password on this computer";
            this.cbSavePassword.UseVisualStyleBackColor = true;
            this.cbSavePassword.CheckedChanged += new System.EventHandler(this.cbSavePassword_CheckedChanged);
            // 
            // tcSections
            // 
            this.tcSections.Controls.Add(this.tpMain);
            this.tcSections.Controls.Add(this.tpRegister);
            this.tcSections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSections.Location = new System.Drawing.Point(0, 0);
            this.tcSections.Name = "tcSections";
            this.tcSections.SelectedIndex = 0;
            this.tcSections.Size = new System.Drawing.Size(420, 301);
            this.tcSections.TabIndex = 14;
            this.tcSections.SelectedIndexChanged += new System.EventHandler(this.tcSections_SelectedIndexChanged);
            // 
            // pbAd
            // 
            this.pbAd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbAd.Image = ((System.Drawing.Image)(resources.GetObject("pbAd.Image")));
            this.pbAd.Location = new System.Drawing.Point(-16, -22);
            this.pbAd.Name = "pbAd";
            this.pbAd.Size = new System.Drawing.Size(448, 136);
            this.pbAd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAd.TabIndex = 12;
            this.pbAd.TabStop = false;
            this.pbAd.Click += new System.EventHandler(this.pbAd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UsingPintoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 301);
            this.Controls.Add(this.tcSections);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsingPintoForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "豆子 - Login";
            this.Load += new System.EventHandler(this.UsingPintoForm_Load);
            this.tpRegister.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegisterPort)).EndInit();
            this.tpMain.ResumeLayout(false);
            this.tpMain.PerformLayout();
            this.pLoginControls.ResumeLayout(false);
            this.pLoginControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            this.tcSections.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegisterBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudRegisterPort;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRegisterUsername;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TabPage tpMain;
        private System.Windows.Forms.PictureBox pbAd;
        private System.Windows.Forms.LinkLabel btnRegisterPage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel llForgotPassword;
        private System.Windows.Forms.Panel pLoginControls;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.MaskedTextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.CheckBox cbSavePassword;
        private System.Windows.Forms.TabControl tcSections;
        private System.Windows.Forms.LinkLabel LinkToDebugUI;
        private System.Windows.Forms.ComboBox txtIP;
        private System.Windows.Forms.ComboBox txtRegisterIP;
    }
}