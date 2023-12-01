﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace PintoNS.Forms
{
    public partial class ConsoleForm : Form
    {
        public ConsoleForm()
        {
            InitializeComponent();
        }

        public void WriteMessage(string msg)
        {
            WriteMessage(msg, true);
        }

        public void WriteMessage(string msg, bool newLine = true)
        {
            Invoke(new Action(() => 
            {
                if (Disposing || IsDisposed) return;

                Invoke(new Action(() =>
                {
                    rtxtLog.SelectionStart = rtxtLog.TextLength;
                    rtxtLog.SelectionLength = 0;
                    rtxtLog.AppendText(msg + (newLine ? Environment.NewLine : ""));
                }));
            }));
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string cmd = txtInput.Text.Trim();
            txtInput.Text = "";

            WriteMessage("Commands are currently unavailable!");
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void ConsoleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
