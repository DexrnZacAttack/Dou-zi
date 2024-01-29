using PintoNS.UI;
using System;
using System.Windows.Forms;

// Dexrn: We burning down the house with this code

namespace PintoNS.Forms
{
    public partial class DbgForm : Form
    {
        private string currentPVN = Program.PROTOCOL_VERSION.ToString();

        public DbgForm()
        {
            InitializeComponent();
            currentPVN = Program.PROTOCOL_VERSION.ToString();
            // Dexrn: why do I leave the names to their defaults?
            label1.Text = Program.VERSION_STRING;
            label2.Text = Program.VERSION_STRING;
            // Dexrn: Why does making this reference anything related to the PROTOCOL_VERSION cause it to be unchangable
            label3.Text = currentPVN;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (Program.VERSION_STRING != Program.VERSION_STRING_NOSPOOF)
                {
                    Program.hasSpoofedVersion = true;
                    Program.VERSION_STRING = label1.Text;
                    label2.Text = Program.VERSION_STRING;
                }
                else
                {
                    Program.hasSpoofedVersion = false;

                    Program.VERSION_STRING = label1.Text;
                    label2.Text = Program.VERSION_STRING;
                }
            }
            else
            {
                try
                {

                    if (Program.PROTOCOL_VERSION.ToString() != Program.PROTOCOL_VERSION_NOSPOOF.ToString())
                    {
                        Program.hasSpoofedPVN = true;
                        Program.PROTOCOL_VERSION = byte.Parse(label1.Text);
                    }
                    else
                    {
                        Program.hasSpoofedPVN = false;
                        Program.PROTOCOL_VERSION = byte.Parse(label1.Text);
                    }
                }
                catch (Exception ex)
                {
                    if (ex is FormatException || ex is OverflowException)
                    {
                        Program.Console.WriteMessage($"Protocol Version must be of type Byte: {ex}", DouZiResources.ConsoleTypes.NETWORKING);
                        MsgBox.Show(this, $"Error: Protocol Version must be of type Byte", "Error", MsgBoxIconType.ERROR);
                    }
                    else
                        throw;
                }
            }
            currentPVN = Program.PROTOCOL_VERSION.ToString();
            label3.Text = currentPVN;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Program.ignoreNonAlphaChars = true;
            }
            else
            {
                Program.ignoreNonAlphaChars = false;
            }
        }

        private void DbgForm_Load(object sender, EventArgs e)
        {
        }

        private void rateLimitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Program.ignoreRateLimit = true;
            }
            else
            {
                Program.ignoreRateLimit = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = Program.VERSION_STRING;
            } else
            {
                label1.Text = Program.PROTOCOL_VERSION.ToString();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label1.Text = Program.PROTOCOL_VERSION.ToString();
            }
            else
            {
                label1.Text = Program.VERSION_STRING;
            }
        }
    }
}