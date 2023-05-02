using PintoNS.Networking;
using System;
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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            lVersion.Text = $"Client Version {Program.DOUZIVERSION}";
            lProtocolVersion.Text = $"Protocol Version {Program.PROTOCOL_VERSION}";
            lVersionReportedtoServer.Text = $"Version reported to server: {Program.VERSION}";
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
    }
}
