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
        }

        private void DebugProtocolTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SetProtocolButton_Click(object sender, EventArgs e)
        {
            Program.PROTOCOL_VERSION = byte.Parse(DebugProtocolTextbox.Text);
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
    }
}
