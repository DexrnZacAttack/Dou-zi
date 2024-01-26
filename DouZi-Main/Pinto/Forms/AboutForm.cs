using System;
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
            if (Program.hasServerInfo == true)
            {
                label4.Text = $"Server ID: {Program.ServerID}";
                label2.Text = $"Server Software: {Program.ServerSoftware}";
            }
            if (Program.hasSpoofedVersion == true)
            {
                lVersion.Text = $"Version {Program.VERSION_STRING} ({Program.VERSION_STRING_NOSPOOF})";
            }
            else
            {
                lVersion.Text = $"Version {Program.VERSION_STRING}";
            }
            if (Program.hasSpoofedPVN == true)
            {
                label6.Text = $"Protocol Version {Program.PROTOCOL_VERSION_NOSPOOF} ({Program.PROTOCOL_VERSION_NOSPOOF})";
            }
            else
            {
                label6.Text = $"Protocol Version {Program.PROTOCOL_VERSION}";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox1.Image = Logo.LOGO_RED;
            DbgForm form = new DbgForm();
            form.ShowDialog();
        }

        private void lInfo_Click(object sender, EventArgs e)
        {
        }
    }
}