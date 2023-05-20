using PintoNS.Forms.Notification;
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
    public partial class DebugForm : Form
    {
        public DebugForm()
        {
            InitializeComponent();
            CurrentProtocolText.Text = $"Current Protocol Version: {Program.PROTOCOL_VERSION}";
            CurrentVersionText.Text = $"Current Client Version: {Program.VERSION}";
            VersionReportedToServerTextBox.Text = $"{Program.VERSION}";
            DebugProtocolTextbox.Text = $"{Program.PROTOCOL_VERSION}";
            ServerListURLTextBox.Text = $"{ServerListForm.SERVERS_URL}";
            SVLUrlText.Text = $"Current Server List URL: {ServerListForm.SERVERS_URL}";
        }

        private void DebugProtocolTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SetProtocolButton_Click(object sender, EventArgs e)
        {
            byte protocolVersion;
            if (!byte.TryParse(DebugProtocolTextbox.Text, out protocolVersion))
            {
                MsgBox.ShowNotification(this,
                    "Must be byte.",
                    "Error", MsgBoxIconType.ERROR);
            }
            else
            {
                Program.PROTOCOL_VERSION = protocolVersion;
            }


            CurrentProtocolText.Text = $"Current Protocol Version: {Program.PROTOCOL_VERSION}";
            CurrentVersionText.Text = $"Current Client Version: {Program.VERSION}";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void DebugForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void SetVersionReportedToServerButton_Click(object sender, EventArgs e)
        {
            Program.VERSION = (VersionReportedToServerTextBox.Text);
            CurrentVersionText.Text = $"Current Client Version: {Program.VERSION}";
        }

        private void VersionReportedToServerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CurrentProtocolText_Click(object sender, EventArgs e)
        {

        }

        private void CurrentVersionText_Click(object sender, EventArgs e)
        {

        }

        private void SetServerListURLButton_Click(object sender, EventArgs e)
        {
            ServerListForm.SERVERS_URL = (ServerListURLTextBox.Text);
            SVLUrlText.Text = $"Current Server List URL: {ServerListForm.SERVERS_URL}";
        }

        private void ServerListURLTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServerListForm.SERVERS_URL = "http://api.fieme.net:8880/pinto-server-list/servers.php";
            ServerListURLTextBox.Text = $"{ServerListForm.SERVERS_URL}";
            SVLUrlText.Text = $"Current Server List URL: {ServerListForm.SERVERS_URL}";
        }
    }
}
