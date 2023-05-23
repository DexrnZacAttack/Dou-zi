using PintoNS.Networking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PintoNS.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            if (Properties.Settings.Default.BEANSENABLED == false)
            {
                // no beans?
            }
            else
            {
                // beans mode activated

                this.pictureBox1.Image = Logo_Beans.LOGO;
                this.BackgroundImage = Logo_Beans.LOGO_BACKGROUND_ALT;
            }
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            lVersion.Text = $"Client Version: {Program.DOUZIVERSION}";
            lProtocolVersion.Text = $"Protocol Version: {Program.PROTOCOL_VERSION}";
            lVersionReportedtoServer.Text = $"Pinto! Version: {Program.VERSION}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lVersionReportToServer_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/PintoIM/Pinto");
            Process.Start(sInfo);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/DexrnZacAttack/DouZi");
            Process.Start(sInfo);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
