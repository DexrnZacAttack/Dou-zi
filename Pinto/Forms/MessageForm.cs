using PintoNS.Forms.Notification;
using PintoNS.General;
using static PintoNS.General.ContactsManager;
using static PintoNS.General.Contact;
using static PintoNS.General.User;
using PintoNS;
using static PintoNS.MainForm;
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
using System.Diagnostics;
using System.IO;

namespace PintoNS.Forms
{
    public partial class MessageForm : Form
    {
        private MainForm mainForm;
        public NetworkManager NetManager;
        public Contact Receiver;
        public List<MessageForm> MessageForms;
        public ContactsManager ContactsMgr;
        private bool isTypingLastStatus;
        public bool HasBeenInactive;
        public InWindowPopupController InWindowPopupController;
        private MessageForm messageForm;
        private Contact contact;

        public event EventHandler OnChange = new EventHandler((object sender, EventArgs e) => { });

        public MessageForm GetMessageFormFromReceiverName(string name)
        {
            Program.Console.WriteMessage($"Getting MessageForm for {name}...");

            foreach (MessageForm msgForm in MessageForms.ToArray())
            {
                if (msgForm.Receiver.Name == name)
                    return msgForm;
            }

            Program.Console.WriteMessage($"Creating MessageForm for {name}...");
            MessageForm messageForm = new MessageForm(this, ContactsMgr.GetContact(name));
            MessageForms.Add(messageForm);
            messageForm.Show();

            return messageForm;
        }

        public MessageForm(MainForm mainForm, Contact receiver)
        {
            //dgvContacts.Rows.Clear();
            ContactsMgr = new ContactsManager(this);
            MessageForms = new List<MessageForm>();
            InitializeComponent();
            this.mainForm = mainForm;
            InWindowPopupController = new InWindowPopupController(this, 25);
            Receiver = receiver;
            Text = $"Pinto! - Instant Messaging - Chatting with {Receiver.Name}";
            UpdateColorPicker();
            LoadChat();
        }

                private DataGridViewRow GetContactListEntry(string name) 
        {
            if (name == null) return null;

            foreach (DataGridViewRow row in dgvContacts.Rows) 
            {
                if (((string)row.Cells[1].Value) == name) 
                    return row;
            }

            return null;
        }

        private void AddContactListEntry(Contact contact)
        {
            if (GetContactListEntry(contact.Name) == null)
            {
                dgvContacts.Rows.Add(User.StatusToBitmap(contact.Status), contact.Name);
                OnChange.Invoke(this, EventArgs.Empty);
            }
        }

        private void dgvContacts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string contactName = ContactsMgr.GetContactNameFromRow(e.RowIndex);
            Contact contact = ContactsMgr.GetContact(contactName);

            if (contactName != null && contact != null)
            {
                MessageForm messageForm = GetMessageFormFromReceiverName(contactName);
                messageForm.WindowState = FormWindowState.Normal;
                messageForm.BringToFront();
                messageForm.Focus();
            }
        }

        public MessageForm(MessageForm messageForm, Contact contact)
        {
            this.messageForm = messageForm;
            this.contact = contact;
        }

        private void LoadChat()
        {
            Program.Console.WriteMessage("[General] Loading chat...");
            try
            {
                string filePath = Path.Combine(mainForm.DataFolder, "chats", $"{Receiver.Name}.txt");
                if (!File.Exists(filePath)) return;
                rtxtMessages.Rtf = File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {
                Program.Console.WriteMessage($"[General]" +
                    $" Unable to load the chat: {ex}");
                MsgBox.ShowNotification(this,
                    "Unable to load the chat!",
                    "Error", MsgBoxIconType.ERROR);
            }
        }

        private void SaveChat()
        {
            Program.Console.WriteMessage("[General] Saving chat...");
            try
            {
                string filePath = Path.Combine(mainForm.DataFolder, "chats", $"{Receiver.Name}.txt");
                File.WriteAllText(filePath, rtxtMessages.Rtf);
            }
            catch (Exception ex)
            {
                Program.Console.WriteMessage($"[General]" +
                    $" Unable to save the chat: {ex}");
                MsgBox.ShowNotification(this,
                    "Unable to save the chat",
                    "Error", MsgBoxIconType.ERROR);
            }
        }

        private void DeleteChat()
        {
            Program.Console.WriteMessage("[General] Deleting chat...");
            try
            {
                string filePath = Path.Combine(mainForm.DataFolder, "chats", $"{Receiver.Name}.txt");
                if (!File.Exists(filePath)) return;
                File.Delete(filePath);
            }
            catch (Exception ex)
            {
                Program.Console.WriteMessage($"[General]" +
                    $" Unable to delete the chat: {ex}");
                MsgBox.ShowNotification(this,
                    "Unable to delete the chat",
                    "Error", MsgBoxIconType.ERROR);
            }
        }




        public void WriteMessage(string msg, Color color, bool newLine = true)
        {
            Invoke(new Action(() =>
            {
                rtxtMessages.SelectionStart = rtxtMessages.TextLength;
                rtxtMessages.SelectionLength = 0;
                rtxtMessages.SelectionColor = color;
                rtxtMessages.AppendText(msg + (newLine ? Environment.NewLine : ""));
                rtxtMessages.SelectionColor = rtxtMessages.ForeColor;
                SaveChat();
            }));
        }

        public void WriteRTF(string msg)
        {
            Invoke(new Action(() =>
            {
                rtxtMessages.SelectionStart = rtxtMessages.TextLength;
                rtxtMessages.SelectionLength = 0;
                rtxtMessages.SelectionColor = Color.Black;
                try
                {
                    rtxtMessages.SelectedRtf = msg;
                }
                catch
                { 
                    WriteMessage("** IMPROPERLY FORMATED MESSAGE **", Color.Red); 
                }
                SaveChat();
            }));
        }

        public void UpdateColorPicker() 
        {
            Bitmap b = new Bitmap(16, 16);
            Graphics g = Graphics.FromImage(b);
            g.FillRectangle(new SolidBrush(rtxtInput.SelectionColor), 0, 0, 16, 16);
            btnColor.Image = b;
        }

        private void rtxtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Keyboard.Modifiers.HasFlag(System.Windows
               .Input.ModifierKeys.Control) && e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void rtxtMessages_TextChanged(object sender, EventArgs e)
        {
            rtxtMessages.SelectionStart = rtxtMessages.Text.Length;
            rtxtMessages.ScrollToCaret();
        }
        private void rtxtInput_TextChanged(object sender, EventArgs e)
        {
            if (mainForm.NetManager == null) return;
            string text = rtxtInput.Text;
            if (!string.IsNullOrWhiteSpace(text) && !isTypingLastStatus)
            {
                isTypingLastStatus = true;
                //mainForm.NetManager.NetHandler.SendTypingPacket(Receiver.Name, true);
            }
            else if (string.IsNullOrWhiteSpace(text) && isTypingLastStatus)
            {
                isTypingLastStatus = false;
                //mainForm.NetManager.NetHandler.SendTypingPacket(Receiver.Name, false);
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            string input = rtxtInput.Rtf;
            string inputStripped = rtxtInput.Text;
            if (string.IsNullOrWhiteSpace(inputStripped))
            {
                MsgBox.ShowNotification(this, "The specified message is invalid!", "Error",
                    MsgBoxIconType.ERROR);
                return;
            }
            rtxtInput.Clear();
            if (mainForm.NetManager != null)
            {
                mainForm.NetManager.NetHandler.SendMessagePacket(Receiver.Name, input);
            }
        }
        private void MessageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mainForm.MessageForms != null)
                mainForm.MessageForms.Remove(this);
        }
        private void tsmiMenuBarHelpAbout_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog(this);
        }
        private void MessageForm_Activated(object sender, EventArgs e)
        {
            HasBeenInactive = false;
        }
        private void rtxtMessages_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }
        private void btnTalk_Click(object sender, EventArgs e)
        {
            MsgBox.ShowNotification(this,
                "This option is unavailable in this version!",
                "Option Unavailable",
                MsgBoxIconType.WARNING);
        }
        private void btnBlock_Click(object sender, EventArgs e)
        {
            MsgBox.ShowNotification(this,
                "This option is unavailable in this version!",
                "Option Unavailable",
                MsgBoxIconType.WARNING);
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            cdPicker.ShowDialog();
            rtxtInput.SelectionColor = cdPicker.Color;
            UpdateColorPicker();
        }
        private void rtxtInput_SelectionChanged(object sender, EventArgs e)
        {
            UpdateColorPicker();
        }

        private void tsmiMenuBarFileClearSavedData_Click(object sender, EventArgs e)
        {
            rtxtMessages.Rtf = null;
            DeleteChat();
        }

        private void tsmiMenuBarFileAddContact_Click(object sender, EventArgs e)
        {
            MsgBox.ShowNotification(this,
                "Douzi Error: This option is unavailable in this version!",
                "Option Unavailable",
                MsgBoxIconType.WARNING);
        }

        private void dgvContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
