﻿
namespace PintoNS.Controls
{
    partial class Loader
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tAnimation = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tAnimation
            // 
            this.tAnimation.Enabled = true;
            this.tAnimation.Interval = 50;
            this.tAnimation.Tick += new System.EventHandler(this.tAnimation_Tick);
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(128, 128);
            this.MinimumSize = new System.Drawing.Size(128, 128);
            this.Name = "Loader";
            this.Size = new System.Drawing.Size(128, 128);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tAnimation;
    }
}
