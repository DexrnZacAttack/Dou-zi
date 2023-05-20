﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PintoNS.Forms
{
    public partial class PopupForm : Form
    {
        public const int ANIMATION_POSITION_CHANGE = 25;
        public int TargetY;
        public bool ReachedTargetY;
        public int MaxAutoCloseTicks;
        private int autoCloseTicks;

        public PopupForm()
        {
            InitializeComponent();
            if (Properties.Settings.Default.BEANSENABLED == false)
            {
                // no beans?
            }
            else
            {
                // beans mode activated

                this.BackgroundImage = Logo_Beans.LOGIN_BACKGROUND;
            }
        }

        private void tAnim_Tick(object sender, EventArgs e)
        {
            if (ReachedTargetY)
            {
                tAnim.Stop();
                return;
            }

            if (Location.Y - ANIMATION_POSITION_CHANGE > TargetY)
            {
                Location = new Point(Location.X, Location.Y - ANIMATION_POSITION_CHANGE);
            }
            else
            {
                Location = new Point(Location.X, TargetY);
                ReachedTargetY = true;
            }
        }

        private void tSizeCheck_Tick(object sender, EventArgs e)
        {
            if (lBody.Text.Length >= 321)
                lSeeContent.Visible = true;
            else
                lSeeContent.Visible = false;
        }

        private void lSeeContent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewAllPopupContentForm viewAllPopupContentForm = new ViewAllPopupContentForm();
            viewAllPopupContentForm.rtxtContent.Text = lBody.Text;
            viewAllPopupContentForm.Show();
        }

        private void tAutoClose_Tick(object sender, EventArgs e)
        {
            lAutoClose.Visible = true;
            lAutoClose.Text = $"{MaxAutoCloseTicks - autoCloseTicks}";

            if (autoCloseTicks >= MaxAutoCloseTicks)
                btnClose.PerformClick();

            autoCloseTicks++;
        }

        private void lBody_Click(object sender, EventArgs e)
        {

        }
    }
}