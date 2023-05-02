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
            this.DebugProtocolTextbox = new System.Windows.Forms.TextBox();
            this.ProtocolText = new System.Windows.Forms.Label();
            this.SetProtocolButton = new System.Windows.Forms.Button();
            this.CurrentProtocolVersionText = new System.Windows.Forms.Label();
            this.CurrentProtocolText = new System.Windows.Forms.Label();
            this.VersionReportedToServerTextBox = new System.Windows.Forms.TextBox();
            this.CurrentVersionText = new System.Windows.Forms.Label();
            this.SetVersionReportedToServerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DebugProtocolTextbox
            // 
            this.DebugProtocolTextbox.Location = new System.Drawing.Point(68, 25);
            this.DebugProtocolTextbox.Name = "DebugProtocolTextbox";
            this.DebugProtocolTextbox.Size = new System.Drawing.Size(100, 20);
            this.DebugProtocolTextbox.TabIndex = 0;
            this.DebugProtocolTextbox.Text = "13";
            this.DebugProtocolTextbox.TextChanged += new System.EventHandler(this.DebugProtocolTextbox_TextChanged);
            // 
            // ProtocolText
            // 
            this.ProtocolText.AutoSize = true;
            this.ProtocolText.Location = new System.Drawing.Point(94, 9);
            this.ProtocolText.Name = "ProtocolText";
            this.ProtocolText.Size = new System.Drawing.Size(49, 13);
            this.ProtocolText.TabIndex = 1;
            this.ProtocolText.Text = "Protocol:";
            this.ProtocolText.Click += new System.EventHandler(this.label1_Click);
            // 
            // SetProtocolButton
            // 
            this.SetProtocolButton.Location = new System.Drawing.Point(79, 51);
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
            this.CurrentProtocolText.Location = new System.Drawing.Point(7, 79);
            this.CurrentProtocolText.Name = "CurrentProtocolText";
            this.CurrentProtocolText.Size = new System.Drawing.Size(35, 13);
            this.CurrentProtocolText.TabIndex = 4;
            this.CurrentProtocolText.Text = "label1";
            // 
            // VersionReportedToServerTextBox
            // 
            this.VersionReportedToServerTextBox.Location = new System.Drawing.Point(227, 25);
            this.VersionReportedToServerTextBox.Name = "VersionReportedToServerTextBox";
            this.VersionReportedToServerTextBox.Size = new System.Drawing.Size(100, 20);
            this.VersionReportedToServerTextBox.TabIndex = 5;
            this.VersionReportedToServerTextBox.Text = "a1.1";
            // 
            // CurrentVersionText
            // 
            this.CurrentVersionText.AutoSize = true;
            this.CurrentVersionText.Location = new System.Drawing.Point(7, 96);
            this.CurrentVersionText.Name = "CurrentVersionText";
            this.CurrentVersionText.Size = new System.Drawing.Size(35, 13);
            this.CurrentVersionText.TabIndex = 6;
            this.CurrentVersionText.Text = "label1";
            // 
            // SetVersionReportedToServerButton
            // 
            this.SetVersionReportedToServerButton.Location = new System.Drawing.Point(237, 51);
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
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Client Version reported to Server";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // DebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 118);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetVersionReportedToServerButton);
            this.Controls.Add(this.CurrentVersionText);
            this.Controls.Add(this.VersionReportedToServerTextBox);
            this.Controls.Add(this.CurrentProtocolText);
            this.Controls.Add(this.CurrentProtocolVersionText);
            this.Controls.Add(this.SetProtocolButton);
            this.Controls.Add(this.ProtocolText);
            this.Controls.Add(this.DebugProtocolTextbox);
            this.Name = "DebugForm";
            this.Text = "Form1";
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
    }
}