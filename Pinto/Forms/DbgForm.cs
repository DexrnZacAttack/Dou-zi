using NAudio.Gui;
using PintoNS.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

// Dexrn: We burning down the house with this code

namespace PintoNS.Forms
{
    public partial class DbgForm : Form
    {
        public DbgForm()
        {
            InitializeComponent();
            // Dexrn: why do I leave the names to their defaults?
            label1.Text = Program.VERSION_STRING;
            label2.Text = Program.VERSION_STRING;
            label3.Text = Program.VERSION_STRING;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (label3.Text != Program.VERSION_STRING_NOSPOOF)
                {
                    Program.hasSpoofedVersion = true;
                    Program.VERSION_STRING = label1.Text;
                    label2.Text = Program.VERSION_STRING;
                }
                else
                {
                    Program.hasSpoofedVersion = false;
                    
                    Program.VERSION_STRING = Program.VERSION_STRING_NOSPOOF;
                    label2.Text = Program.VERSION_STRING;
                }
            }
            else
            {
                try
                {
                    if (label3.Text != Program.PROTOCOL_VERSION_NOSPOOF.ToString())
                    {
                        Program.hasSpoofedPVN = true;
                        
                        int PVN = int.Parse(label1.Text);
                        Program.PROTOCOL_VERSION = (byte)PVN;
                        label3.Text = Program.PROTOCOL_VERSION.ToString();
                    }
                    else
                    {
                        Program.hasSpoofedPVN = false;
                        
                        Program.PROTOCOL_VERSION = Program.PROTOCOL_VERSION_NOSPOOF;
                        label3.Text = Program.PROTOCOL_VERSION.ToString();
                    }
                }
                catch (FormatException ex)
                {
                    Program.Console.WriteMessage($"Protocol Version must be of type Byte: {ex}", DouZiResources.ConsoleTypes.NETWORKING);
                    MsgBox.Show(this, $"Error: Protocol Version must be of type Byte", "Error", MsgBoxIconType.ERROR);
                }
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Program.ignoreNonAlphaChars = true;
            } else
            {
                Program.ignoreNonAlphaChars = false;
            }
        }

        private void DbgForm_Load(object sender, EventArgs e)
        {

        }
    }
}
