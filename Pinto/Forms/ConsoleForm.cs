﻿using PintoNS.DouZiResources;
using System;
using System.Windows.Forms;

namespace PintoNS.Forms
{
    public partial class ConsoleForm : Form
    {
        private const int SM_ITEM_CLEAR = 0x01;

        public ConsoleForm()
        {
            InitializeComponent();
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (Program.RunningUnderMono) return;
            IntPtr sysMenu = PInvoke.GetSystemMenu(Handle, false);
            PInvoke.AppendMenu(sysMenu, PInvoke.MF_SEPARATOR, 0x00, "");
            PInvoke.AppendMenu(sysMenu, PInvoke.MF_STRING, SM_ITEM_CLEAR, "&Clear Console");
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (Program.RunningUnderMono) return;
            if (m.Msg == PInvoke.WM_SYSCOMMAND &&
                (int)m.WParam == SM_ITEM_CLEAR)
            {
                rtxtLog.Clear();
            }
        }

        public void WriteMessage(string msg, ConsoleTypes type = ConsoleTypes.GENERAL)
        {
            WriteMessage(msg, true, type);
        }

        public void WriteMessage(string msg, bool newLine = true, ConsoleTypes type = ConsoleTypes.GENERAL)
        {
            Invoke(new Action(() =>
            {
                if (Disposing || IsDisposed) return;

                Invoke(new Action(() =>
                {
                    rtxtLog.SelectionStart = rtxtLog.TextLength;
                    rtxtLog.SelectionLength = 0;
                    switch (type)
                    {
                        default:
                        case ConsoleTypes.GENERAL:
                            rtxtLog.AppendText("[General]" + $" {msg}" + (newLine ? Environment.NewLine : ""));

                            break;

                        case ConsoleTypes.NETWORKING:
                            rtxtLog.AppendText("[Networking]" + $" {msg}" + (newLine ? Environment.NewLine : ""));
                            break;

                        case ConsoleTypes.SCRIPTING:
                            rtxtLog.AppendText("[Scripting]" + $" {msg}" + (newLine ? Environment.NewLine : ""));
                            break;

                        case ConsoleTypes.CONTACTS:
                            rtxtLog.AppendText("[Contacts]" + $" {msg}" + (newLine ? Environment.NewLine : ""));
                            break;

                        case ConsoleTypes.MESSAGING:
                            rtxtLog.AppendText("[Messaging] " + $" {msg}" + (newLine ? Environment.NewLine : ""));
                            break;

                        case ConsoleTypes.UPDATER:
                            rtxtLog.AppendText("[Updater]" + $" {msg}" + (newLine ? Environment.NewLine : ""));
                            break;

                        case ConsoleTypes.CALLMGR:
                            rtxtLog.AppendText("[CallManager]" + $" {msg}" + (newLine ? Environment.NewLine : ""));
                            break;

                        case ConsoleTypes.BROWSER:
                            rtxtLog.AppendText("[BrowserWindow]" + $" {msg}" + (newLine ? Environment.NewLine : ""));
                            break;
                    }
                }));
            }));
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string cmd = txtInput.Text.Trim();
            txtInput.Text = "";

            WriteMessage("Commands are currently unavailable!", ConsoleTypes.GENERAL);
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