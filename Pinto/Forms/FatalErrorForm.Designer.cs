namespace PintoNS.Forms
{
    partial class FatalErrorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FatalErrorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxtLog = new System.Windows.Forms.RichTextBox();
            this.DontReportText = new System.Windows.Forms.Label();
            this.HereText = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "豆子 has ran into an fatal error!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "This may be due to my (Dexrn\'s) shit coding";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "If you want to prevent this from happening in the future, report the attached log" +
    "";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rtxtLog
            // 
            this.rtxtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtLog.BackColor = System.Drawing.SystemColors.Window;
            this.rtxtLog.Location = new System.Drawing.Point(15, 54);
            this.rtxtLog.Name = "rtxtLog";
            this.rtxtLog.ReadOnly = true;
            this.rtxtLog.Size = new System.Drawing.Size(374, 242);
            this.rtxtLog.TabIndex = 3;
            this.rtxtLog.Text = "";
            // 
            // DontReportText
            // 
            this.DontReportText.AutoSize = true;
            this.DontReportText.Location = new System.Drawing.Point(12, 38);
            this.DontReportText.Name = "DontReportText";
            this.DontReportText.Size = new System.Drawing.Size(338, 13);
            this.DontReportText.TabIndex = 4;
            this.DontReportText.Text = "Don\'t report to vlOd as it is likely an issue with DouZi. instead, report to";
            this.DontReportText.Click += new System.EventHandler(this.label4_Click);
            // 
            // HereText
            // 
            this.HereText.AutoSize = true;
            this.HereText.Location = new System.Drawing.Point(346, 38);
            this.HereText.Name = "HereText";
            this.HereText.Size = new System.Drawing.Size(28, 13);
            this.HereText.TabIndex = 5;
            this.HereText.TabStop = true;
            this.HereText.Text = "here";
            this.HereText.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HereText_LinkClicked);
            // 
            // FatalErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 312);
            this.Controls.Add(this.HereText);
            this.Controls.Add(this.DontReportText);
            this.Controls.Add(this.rtxtLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FatalErrorForm";
            this.Text = "豆子 - Fatal Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.RichTextBox rtxtLog;
        private System.Windows.Forms.Label DontReportText;
        private System.Windows.Forms.LinkLabel HereText;
    }
}