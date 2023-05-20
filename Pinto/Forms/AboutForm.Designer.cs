namespace PintoNS.Forms
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lProtocolVersion = new System.Windows.Forms.Label();
            this.lVersionReportedtoServer = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PintoNS.Logo.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(85, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lVersion
            // 
            this.lVersion.AutoSize = true;
            this.lVersion.BackColor = System.Drawing.Color.Transparent;
            this.lVersion.Location = new System.Drawing.Point(4, 174);
            this.lVersion.Name = "lVersion";
            this.lVersion.Size = new System.Drawing.Size(71, 13);
            this.lVersion.TabIndex = 3;
            this.lVersion.Text = "Client Version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(55, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "what the FUCK am i doing";
            // 
            // lProtocolVersion
            // 
            this.lProtocolVersion.AutoSize = true;
            this.lProtocolVersion.BackColor = System.Drawing.Color.Transparent;
            this.lProtocolVersion.Location = new System.Drawing.Point(4, 200);
            this.lProtocolVersion.Name = "lProtocolVersion";
            this.lProtocolVersion.Size = new System.Drawing.Size(84, 13);
            this.lProtocolVersion.TabIndex = 5;
            this.lProtocolVersion.Text = "Protocol Version";
            this.lProtocolVersion.Click += new System.EventHandler(this.lVersionReportToServer_Click);
            // 
            // lVersionReportedtoServer
            // 
            this.lVersionReportedtoServer.AutoSize = true;
            this.lVersionReportedtoServer.BackColor = System.Drawing.Color.Transparent;
            this.lVersionReportedtoServer.Location = new System.Drawing.Point(4, 187);
            this.lVersionReportedtoServer.Name = "lVersionReportedtoServer";
            this.lVersionReportedtoServer.Size = new System.Drawing.Size(128, 13);
            this.lVersionReportedtoServer.TabIndex = 6;
            this.lVersionReportedtoServer.Text = "Version reported to server";
            this.lVersionReportedtoServer.Click += new System.EventHandler(this.label2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(164, 200);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(76, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "a fork of Pinto!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(88, 92);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(61, 29);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "豆子";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PintoNS.Assets.LOGINANIM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(240, 217);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lVersionReportedtoServer);
            this.Controls.Add(this.lProtocolVersion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lVersion);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(256, 256);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(256, 256);
            this.Name = "AboutForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "豆子 - About";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lProtocolVersion;
        private System.Windows.Forms.Label lVersionReportedtoServer;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}