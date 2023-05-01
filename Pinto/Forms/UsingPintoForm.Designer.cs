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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pLoginControls = new System.Windows.Forms.Panel();
            this.rbLogin = new System.Windows.Forms.RadioButton();
            this.rbCreate = new System.Windows.Forms.RadioButton();
            this.cbSavePassword = new System.Windows.Forms.CheckBox();
            this.llForgotPassword = new System.Windows.Forms.LinkLabel();
            this.pbAd = new System.Windows.Forms.PictureBox();
            this.tcSections = new System.Windows.Forms.TabControl();
            this.tpMain = new System.Windows.Forms.TabPage();
            this.tpRegister = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegisterBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRegisterIP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudRegisterPort = new System.Windows.Forms.NumericUpDown();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRegisterUsername = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPassword = new PintoNS.Controls.TextBoxWithPlaceholderSupport();
            this.txtUsername = new PintoNS.Controls.TextBoxWithPlaceholderSupport();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.pLoginControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAd)).BeginInit();
            this.tcSections.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.tpRegister.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegisterPort)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(215, 302);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(154, 273);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(194, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(234, 65);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(106, 20);
            this.txtIP.TabIndex = 2;
            this.txtIP.Text = "127.0.0.1";
            // 
            // nudPort
            // 
            this.nudPort.Location = new System.Drawing.Point(243, 89);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password:";
            // 
            // pLoginControls
            // 
            this.pLoginControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLoginControls.Controls.Add(this.txtUsername);
            this.pLoginControls.Controls.Add(this.txtPassword);
            this.pLoginControls.Controls.Add(this.rbCreate);
            this.pLoginControls.Controls.Add(this.rbLogin);
            this.pLoginControls.Controls.Add(this.llForgotPassword);
            this.pLoginControls.Controls.Add(this.label1);
            this.pLoginControls.Controls.Add(this.label4);
            this.pLoginControls.Controls.Add(this.txtIP);
            this.pLoginControls.Controls.Add(this.label3);
            this.pLoginControls.Controls.Add(this.nudPort);
            this.pLoginControls.Controls.Add(this.label2);
            this.pLoginControls.Location = new System.Drawing.Point(70, 111);
            this.pLoginControls.Name = "pLoginControls";
            this.pLoginControls.Size = new System.Drawing.Size(348, 136);
            this.pLoginControls.TabIndex = 10;
            // 
            // rbLogin
            // 
            this.rbLogin.AutoSize = true;
            this.rbLogin.Checked = true;
            this.rbLogin.Location = new System.Drawing.Point(22, 39);
            this.rbLogin.Name = "rbLogin";
            this.rbLogin.Size = new System.Drawing.Size(170, 17);
            this.rbLogin.TabIndex = 13;
            this.rbLogin.TabStop = true;
            this.rbLogin.Text = "I already have a Pinto account";
            this.rbLogin.UseVisualStyleBackColor = true;
            // 
            // rbCreate
            // 
            this.rbCreate.AutoSize = true;
            this.rbCreate.Location = new System.Drawing.Point(23, 16);
            this.rbCreate.Name = "rbCreate";
            this.rbCreate.Size = new System.Drawing.Size(224, 17);
            this.rbCreate.TabIndex = 12;
            this.rbCreate.Text = "I would like to create a new Pinto account";
            this.rbCreate.UseVisualStyleBackColor = true;
            this.rbCreate.CheckedChanged += new System.EventHandler(this.rbCreate_CheckedChanged);
            // 
            // cbSavePassword
            // 
            this.cbSavePassword.AutoSize = true;
            this.cbSavePassword.Checked = true;
            this.cbSavePassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSavePassword.Location = new System.Drawing.Point(77, 253);
            this.cbSavePassword.Name = "cbSavePassword";
            this.cbSavePassword.Size = new System.Drawing.Size(196, 17);
            this.cbSavePassword.TabIndex = 11;
            this.cbSavePassword.Text = "Store my password on this computer";
            this.cbSavePassword.UseVisualStyleBackColor = true;
            this.cbSavePassword.CheckedChanged += new System.EventHandler(this.cbSavePassword_CheckedChanged);
            // 
            // llForgotPassword
            // 
            this.llForgotPassword.AutoSize = true;
            this.llForgotPassword.Enabled = false;
            this.llForgotPassword.Location = new System.Drawing.Point(20, 116);
            this.llForgotPassword.Name = "llForgotPassword";
            this.llForgotPassword.Size = new System.Drawing.Size(114, 13);
            this.llForgotPassword.TabIndex = 10;
            this.llForgotPassword.TabStop = true;
            this.llForgotPassword.Text = "Forgot your password?";
            // 
            // pbAd
            // 
            this.pbAd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbAd.Image = global::PintoNS.Assets.LOGIN_PLACEHOLDER;
            this.pbAd.Location = new System.Drawing.Point(-4, -22);
            this.pbAd.Name = "pbAd";
            this.pbAd.Size = new System.Drawing.Size(510, 136);
            this.pbAd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAd.TabIndex = 12;
            this.pbAd.TabStop = false;
            this.pbAd.Click += new System.EventHandler(this.pbAd_Click);
            // 
            // tcSections
            // 
            this.tcSections.Controls.Add(this.tpMain);
            this.tcSections.Controls.Add(this.tpRegister);
            this.tcSections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSections.Location = new System.Drawing.Point(0, 0);
            this.tcSections.Name = "tcSections";
            this.tcSections.SelectedIndex = 0;
            this.tcSections.Size = new System.Drawing.Size(517, 352);
            this.tcSections.TabIndex = 14;
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.btnCancel);
            this.tpMain.Controls.Add(this.pLoginControls);
            this.tpMain.Controls.Add(this.btnConnect);
            this.tpMain.Controls.Add(this.cbSavePassword);
            this.tpMain.Controls.Add(this.pbAd);
            this.tpMain.Location = new System.Drawing.Point(4, 22);
            this.tpMain.Name = "tpMain";
            this.tpMain.Padding = new System.Windows.Forms.Padding(3);
            this.tpMain.Size = new System.Drawing.Size(509, 326);
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "Main";
            this.tpMain.UseVisualStyleBackColor = true;
            // 
            // tpRegister
            // 
            this.tpRegister.Controls.Add(this.label5);
            this.tpRegister.Controls.Add(this.btnRegisterBack);
            this.tpRegister.Controls.Add(this.panel1);
            this.tpRegister.Controls.Add(this.btnRegister);
            this.tpRegister.Location = new System.Drawing.Point(4, 22);
            this.tpRegister.Name = "tpRegister";
            this.tpRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegister.Size = new System.Drawing.Size(509, 351);
            this.tpRegister.TabIndex = 1;
            this.tpRegister.Text = "Register";
            this.tpRegister.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Register on Pinto";
            // 
            // btnRegisterBack
            // 
            this.btnRegisterBack.Location = new System.Drawing.Point(216, 273);
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
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtRegisterIP);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.nudRegisterPort);
            this.panel1.Controls.Add(this.txtRegisterPassword);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtRegisterUsername);
            this.panel1.Location = new System.Drawing.Point(78, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 65);
            this.panel1.TabIndex = 15;
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
            // txtRegisterIP
            // 
            this.txtRegisterIP.Location = new System.Drawing.Point(234, 8);
            this.txtRegisterIP.Name = "txtRegisterIP";
            this.txtRegisterIP.Size = new System.Drawing.Size(106, 20);
            this.txtRegisterIP.TabIndex = 2;
            this.txtRegisterIP.Text = "127.0.0.1";
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
            this.btnRegister.Location = new System.Drawing.Point(149, 244);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(215, 23);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(83, 88);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "password";
            this.txtPassword.PlaceholderTextForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Size = new System.Drawing.Size(119, 20);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.TextForeColor = System.Drawing.Color.Black;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBoxWithPlaceholderSupport1_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsername.Location = new System.Drawing.Point(83, 62);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "username";
            this.txtUsername.PlaceholderTextForeColor = System.Drawing.Color.DimGray;
            this.txtUsername.Size = new System.Drawing.Size(119, 20);
            this.txtUsername.TabIndex = 16;
            this.txtUsername.TextForeColor = System.Drawing.Color.Black;
            // 
            // UsingPintoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 352);
            this.Controls.Add(this.tcSections);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsingPintoForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pinto! - Using Pinto";
            this.Load += new System.EventHandler(this.UsingPintoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            this.pLoginControls.ResumeLayout(false);
            this.pLoginControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAd)).EndInit();
            this.tcSections.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            this.tpMain.PerformLayout();
            this.tpRegister.ResumeLayout(false);
            this.tpRegister.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegisterPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pLoginControls;
        private System.Windows.Forms.LinkLabel llForgotPassword;
        private System.Windows.Forms.CheckBox cbSavePassword;
        private System.Windows.Forms.RadioButton rbLogin;
        private System.Windows.Forms.RadioButton rbCreate;
        private System.Windows.Forms.PictureBox pbAd;
        private System.Windows.Forms.TabControl tcSections;
        private System.Windows.Forms.TabPage tpMain;
        private System.Windows.Forms.TabPage tpRegister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegisterBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRegisterIP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudRegisterPort;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRegisterUsername;
        private System.Windows.Forms.Button btnRegister;
        private Controls.TextBoxWithPlaceholderSupport txtPassword;
        private Controls.TextBoxWithPlaceholderSupport txtUsername;
    }
}