namespace PintoNS.Forms
{
    partial class DebugForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebugForm));
            this.DebugProtocolTextbox = new System.Windows.Forms.TextBox();
            this.ProtocolText = new System.Windows.Forms.Label();
            this.SetProtocolButton = new System.Windows.Forms.Button();
            this.CurrentProtocolVersionText = new System.Windows.Forms.Label();
            this.CurrentProtocolText = new System.Windows.Forms.Label();
            this.VersionReportedToServerTextBox = new System.Windows.Forms.TextBox();
            this.CurrentVersionText = new System.Windows.Forms.Label();
            this.SetVersionReportedToServerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ServerListURLTextBox = new System.Windows.Forms.TextBox();
            this.SetServerListURLButton = new System.Windows.Forms.Button();
            this.SVLUrlText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DebugProtocolTextbox
            // 
            this.DebugProtocolTextbox.Location = new System.Drawing.Point(101, 38);
            this.DebugProtocolTextbox.Name = "DebugProtocolTextbox";
            this.DebugProtocolTextbox.Size = new System.Drawing.Size(100, 20);
            this.DebugProtocolTextbox.TabIndex = 0;
            this.DebugProtocolTextbox.Text = "14";
            this.DebugProtocolTextbox.TextChanged += new System.EventHandler(this.DebugProtocolTextbox_TextChanged);
            // 
            // ProtocolText
            // 
            this.ProtocolText.AutoSize = true;
            this.ProtocolText.BackColor = System.Drawing.Color.Transparent;
            this.ProtocolText.Location = new System.Drawing.Point(128, 22);
            this.ProtocolText.Name = "ProtocolText";
            this.ProtocolText.Size = new System.Drawing.Size(46, 13);
            this.ProtocolText.TabIndex = 1;
            this.ProtocolText.Text = "Protocol";
            this.ProtocolText.Click += new System.EventHandler(this.label1_Click);
            // 
            // SetProtocolButton
            // 
            this.SetProtocolButton.Location = new System.Drawing.Point(114, 64);
            this.SetProtocolButton.Name = "SetProtocolButton";
            this.SetProtocolButton.Size = new System.Drawing.Size(75, 23);
            this.SetProtocolButton.TabIndex = 2;
            this.SetProtocolButton.Text = "Set Protocol";
            this.SetProtocolButton.UseVisualStyleBackColor = true;
            this.SetProtocolButton.Click += new System.EventHandler(this.SetProtocolButton_Click);
            // 
            // CurrentProtocolVersionText
            // 
            this.CurrentProtocolVersionText.AutoSize = true;
            this.CurrentProtocolVersionText.Location = new System.Drawing.Point(4, 79);
            this.CurrentProtocolVersionText.Name = "CurrentProtocolVersionText";
            this.CurrentProtocolVersionText.Size = new System.Drawing.Size(0, 13);
            this.CurrentProtocolVersionText.TabIndex = 3;
            this.CurrentProtocolVersionText.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CurrentProtocolText
            // 
            this.CurrentProtocolText.AutoSize = true;
            this.CurrentProtocolText.BackColor = System.Drawing.Color.Transparent;
            this.CurrentProtocolText.Location = new System.Drawing.Point(2, 172);
            this.CurrentProtocolText.Name = "CurrentProtocolText";
            this.CurrentProtocolText.Size = new System.Drawing.Size(35, 13);
            this.CurrentProtocolText.TabIndex = 4;
            this.CurrentProtocolText.Text = "label1";
            this.CurrentProtocolText.Click += new System.EventHandler(this.CurrentProtocolText_Click);
            // 
            // VersionReportedToServerTextBox
            // 
            this.VersionReportedToServerTextBox.Location = new System.Drawing.Point(260, 38);
            this.VersionReportedToServerTextBox.Name = "VersionReportedToServerTextBox";
            this.VersionReportedToServerTextBox.Size = new System.Drawing.Size(100, 20);
            this.VersionReportedToServerTextBox.TabIndex = 5;
            this.VersionReportedToServerTextBox.Text = "a1.3";
            this.VersionReportedToServerTextBox.TextChanged += new System.EventHandler(this.VersionReportedToServerTextBox_TextChanged);
            // 
            // CurrentVersionText
            // 
            this.CurrentVersionText.AutoSize = true;
            this.CurrentVersionText.BackColor = System.Drawing.Color.Transparent;
            this.CurrentVersionText.Location = new System.Drawing.Point(2, 149);
            this.CurrentVersionText.Name = "CurrentVersionText";
            this.CurrentVersionText.Size = new System.Drawing.Size(35, 13);
            this.CurrentVersionText.TabIndex = 6;
            this.CurrentVersionText.Text = "label1";
            this.CurrentVersionText.Click += new System.EventHandler(this.CurrentVersionText_Click);
            // 
            // SetVersionReportedToServerButton
            // 
            this.SetVersionReportedToServerButton.Location = new System.Drawing.Point(273, 64);
            this.SetVersionReportedToServerButton.Name = "SetVersionReportedToServerButton";
            this.SetVersionReportedToServerButton.Size = new System.Drawing.Size(75, 23);
            this.SetVersionReportedToServerButton.TabIndex = 7;
            this.SetVersionReportedToServerButton.Text = "Set version";
            this.SetVersionReportedToServerButton.UseVisualStyleBackColor = true;
            this.SetVersionReportedToServerButton.Click += new System.EventHandler(this.SetVersionReportedToServerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(231, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Client Version reported to Server";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // ServerListURLTextBox
            // 
            this.ServerListURLTextBox.Location = new System.Drawing.Point(101, 110);
            this.ServerListURLTextBox.Name = "ServerListURLTextBox";
            this.ServerListURLTextBox.Size = new System.Drawing.Size(259, 20);
            this.ServerListURLTextBox.TabIndex = 9;
            this.ServerListURLTextBox.TextChanged += new System.EventHandler(this.ServerListURLTextBox_TextChanged);
            // 
            // SetServerListURLButton
            // 
            this.SetServerListURLButton.Location = new System.Drawing.Point(164, 136);
            this.SetServerListURLButton.Name = "SetServerListURLButton";
            this.SetServerListURLButton.Size = new System.Drawing.Size(133, 23);
            this.SetServerListURLButton.TabIndex = 10;
            this.SetServerListURLButton.Text = "Set Server List URL";
            this.SetServerListURLButton.UseVisualStyleBackColor = true;
            this.SetServerListURLButton.Click += new System.EventHandler(this.SetServerListURLButton_Click);
            // 
            // SVLUrlText
            // 
            this.SVLUrlText.AutoSize = true;
            this.SVLUrlText.BackColor = System.Drawing.Color.Transparent;
            this.SVLUrlText.Location = new System.Drawing.Point(2, 195);
            this.SVLUrlText.Name = "SVLUrlText";
            this.SVLUrlText.Size = new System.Drawing.Size(35, 13);
            this.SVLUrlText.TabIndex = 11;
            this.SVLUrlText.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(189, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Server List URL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Reset URL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PintoNS.Assets.LOGINANIM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 208);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SVLUrlText);
            this.Controls.Add(this.SetServerListURLButton);
            this.Controls.Add(this.ServerListURLTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetVersionReportedToServerButton);
            this.Controls.Add(this.CurrentVersionText);
            this.Controls.Add(this.VersionReportedToServerTextBox);
            this.Controls.Add(this.CurrentProtocolText);
            this.Controls.Add(this.CurrentProtocolVersionText);
            this.Controls.Add(this.SetProtocolButton);
            this.Controls.Add(this.ProtocolText);
            this.Controls.Add(this.DebugProtocolTextbox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DebugForm";
            this.Text = "豆子 - Debug";
            this.Load += new System.EventHandler(this.DebugForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DebugProtocolTextbox;
        private System.Windows.Forms.Label ProtocolText;
        private System.Windows.Forms.Button SetProtocolButton;
        private System.Windows.Forms.Label CurrentProtocolVersionText;
        private System.Windows.Forms.Label CurrentProtocolText;
        private System.Windows.Forms.TextBox VersionReportedToServerTextBox;
        private System.Windows.Forms.Label CurrentVersionText;
        private System.Windows.Forms.Button SetVersionReportedToServerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerListURLTextBox;
        private System.Windows.Forms.Button SetServerListURLButton;
        private System.Windows.Forms.Label SVLUrlText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}