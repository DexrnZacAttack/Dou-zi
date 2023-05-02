﻿using PintoNS.Localization;
using PintoNS.Networking;
using PintoNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PintoNS.Forms.Notification;
using System.Threading.Tasks;
using PintoNS.Forms;
using PintoNS.General;
using System.Media;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

namespace PintoNS
{
    public partial class MainForm : Form
    {
        public readonly string DataFolder = Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.ApplicationData), "Pinto!");
        public readonly LocalizationManager LocalizationMgr = new LocalizationManager();
        public ContactsManager ContactsMgr;
        public InWindowPopupController InWindowPopupController;
        public PopupController PopupController;
        public NetworkManager NetManager;
        public User CurrentUser = new User();
        public List<MessageForm> MessageForms;
        /*
        public AudioRecorderPlayer AudioRecPlyr;
        public bool InCall;
        public string CallTarget;
        public UdpClient CallClient;
        public IPEndPoint CallTargetIP;
        public Thread CallReceiveThread;*/
        
        public MainForm()
        {
            InitializeComponent();
            InWindowPopupController = new InWindowPopupController(this, 70);
            PopupController = new PopupController();
        }

        internal void OnLogin() 
        {
            tcTabs.TabPages.Clear();
            tcTabs.TabPages.Add(tpContacts);
            OnStatusChange(UserStatus.ONLINE);

            dgvContacts.Rows.Clear();
            ContactsMgr = new ContactsManager(this);
            MessageForms = new List<MessageForm>();
            // TODO: Currently pointless
            //txtSearchBox.Enabled = true;
            tsmiMenuBarFileAddContact.Enabled = true;
            tsmiMenuBarFileRemoveContact.Enabled = true;
            tsmiMenuBarFileLogOut.Enabled = true;
            Text = $"豆子 - {CurrentUser.Name}";

            new SoundPlayer(Sounds.LOGIN).Play();
        }

        internal void OnStatusChange(UserStatus status) 
        {
            tsddbStatusBarStatus.Enabled = status != UserStatus.OFFLINE;
            tsddbStatusBarStatus.Image = User.StatusToBitmap(status);
            tsslStatusBarStatusText.Text = status != UserStatus.OFFLINE ? User.StatusToText(status) : "Not logged in";
            CurrentUser.Status = status;
            SyncTray();
        }

        internal void OnLogout(bool noSound = false)
        {
            tcTabs.TabPages.Clear();
            tcTabs.TabPages.Add(tpLogin);
            OnStatusChange(UserStatus.OFFLINE);

            if (MessageForms != null && MessageForms.Count > 0) 
            {
                foreach (MessageForm msgForm in MessageForms.ToArray())
                {
                    msgForm.Hide();
                    msgForm.Dispose();
                }
            }

            ContactsMgr = null;
            MessageForms = null;
            btnStartCall.Enabled = false;
            btnStartCall.Image = Assets.STARTCALL_DISABLED;
            btnEndCall.Enabled = false;
            btnEndCall.Image = Assets.ENDCALL_DISABLED;
            txtSearchBox.Text = "";
            txtSearchBox.ChangeTextDisplayed();
            txtSearchBox.Enabled = false;
            tsmiMenuBarFileAddContact.Enabled = false;
            tsmiMenuBarFileRemoveContact.Enabled = false;
            tsmiMenuBarFileLogOut.Enabled = false;
            Text = "豆子!";
            //InCall = false;

            if (!noSound)
                new SoundPlayer(Sounds.LOGOUT).Play();
        }

        public void SyncTray()
        {
            niTray.Visible = true;
            niTray.Icon = User.StatusToIcon(CurrentUser.Status);
            niTray.Text = $"豆子! - " + 
                (CurrentUser.Status != UserStatus.OFFLINE ? 
                $"{CurrentUser.Name} - {User.StatusToText(CurrentUser.Status)}" : "Not logged in");
        }

        /*
        internal void OnCallStart()
        {
            InCall = true;
            CallClient = new UdpClient();
            AudioRecPlyr = new AudioRecorderPlayer();
            CallReceiveThread = new Thread(new ThreadStart(() => 
            {
                while (InCall)
                {
                    try
                    {
                        if (CallClient != null && CallTargetIP != null && AudioRecPlyr != null)
                        {
                            byte[] data = CallClient.Receive(ref CallTargetIP);
                            AudioRecPlyr.Play(data);
                        }
                    }
                    catch (Exception ex)
                    {
                        new SoundPlayer(Sounds.CALL_ERROR1).Play();
                        EndCall();
                        Program.Console.WriteMessage($"[Calling] Call error: {ex}");
                        InWindowPopupController.CreatePopup("Your call has ended due to an error");
                    }
                }
            }));

            btnStartCall.Enabled = false;
            btnStartCall.Image = Assets.STARTCALL_DISABLED;
            btnEndCall.Enabled = true;
            btnEndCall.Image = Assets.ENDCALL_ENABLED;

            lCallTarget.Text = $"In call with {CallTarget}";
            tpCall.Text = CallTarget;

            tcTabs.TabPages.Add(tpCall);
            tcTabs.SelectedTab = tpCall;

            AudioRecPlyr.MicrophoneDataAvailable += delegate (object sender, byte[] data) 
            {
                if (InCall && CallClient != null && CallTargetIP != null)
                {
                    try
                    {
                        CallClient.Send(data, data.Length, CallTargetIP);
                    }
                    catch (Exception ex)
                    {
                        new SoundPlayer(Sounds.CALL_ERROR1).Play();
                        EndCall();
                        Program.Console.WriteMessage($"[Calling] Call error: {ex}");
                        InWindowPopupController.CreatePopup("Your call has ended due to an error");
                    }
                }
            };

            CallClient.Client.Bind(new IPEndPoint(IPAddress.Any, 0));
            AudioRecPlyr.Start();
            CallReceiveThread.Start();
        }

        internal void OnCallStop()
        {
            if (CallClient != null && CallClient.Client != null) 
            {
                CallClient.Client.Close();
                CallClient.Close();
            }
            AudioRecPlyr.Stop();

            InCall = false;
            CallClient = null;
            CallTarget = null;
            CallTargetIP = null;
            AudioRecPlyr = null;
            CallReceiveThread = null;

            if (dgvContacts.SelectedRows.Count > 0)
            {
                btnStartCall.Enabled = true;
                btnStartCall.Image = Assets.STARTCALL_ENABLED;
            }
            else
            {
                btnStartCall.Enabled = false;
                btnStartCall.Image = Assets.STARTCALL_DISABLED;
            }
            btnEndCall.Enabled = false;
            btnEndCall.Image = Assets.ENDCALL_DISABLED;

            lCallTarget.Text = $"In call with";
            tcTabs.SelectedTab = tpContacts;
            tcTabs.TabPages.Remove(tpCall);
        }*/

        public async Task Connect(string ip, int port, string username, string password) 
        {
            tcTabs.TabPages.Clear();
            tcTabs.TabPages.Add(tpConnecting);
            lConnectingStatus.Text = "Connecting...";
            Program.Console.WriteMessage($"[Networking] Signing in as {username} at {ip}:{port}...");

            NetManager = new NetworkManager(this);
            (bool, Exception) connectResult = await NetManager.Connect(ip, port);

            if (!connectResult.Item1)
            {
                Disconnect();
                Program.Console.WriteMessage($"[Networking] Unable to connect to {ip}:{port}: {connectResult.Item2}");
                MsgBox.ShowNotification(this, $"Unable to connect to {ip}:{port}:" +
                    $" {connectResult.Item2.Message}", "Connection Error", MsgBoxIconType.ERROR);
            }
            else 
            {
                CurrentUser.Name = username;
                lConnectingStatus.Text = "Authenticating...";
                NetManager.Login(username, password);
            }
        }

        public async Task ConnectRegister(string ip, int port, string username, string password)
        {
            tcTabs.TabPages.Clear();
            tcTabs.TabPages.Add(tpConnecting);
            lConnectingStatus.Text = "Connecting...";
            Program.Console.WriteMessage($"[Networking] Registering in as {username} at {ip}:{port}...");

            NetManager = new NetworkManager(this);
            (bool, Exception) connectResult = await NetManager.Connect(ip, port);

            if (!connectResult.Item1)
            {
                Disconnect();
                Program.Console.WriteMessage($"[Networking] Unable to connect to {ip}:{port}: {connectResult.Item2}");
                MsgBox.ShowNotification(this, $"Unable to connect to {ip}:{port}:" +
                    $" {connectResult.Item2.Message}", "Connection Error", MsgBoxIconType.ERROR);
            }
            else
            {
                CurrentUser.Name = username;
                lConnectingStatus.Text = "Registering...";
                NetManager.Register(username, password);
            }
        }

        public void Disconnect() 
        {
            Program.Console.WriteMessage("[Networking] Disconnecting...");
            bool wasLoggedIn = false;
            if (NetManager != null) 
            {
                wasLoggedIn = NetManager.NetHandler.LoggedIn;
                if (NetManager.IsActive)
                    NetManager.Disconnect("User requested disconnect");
            }
            OnLogout(!wasLoggedIn);
            NetManager = null;
        }
        
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

        /*
        public void EndCall()
        {
            if (!InCall) return;
            Program.Console.WriteMessage("[General] Ending call...");
            NetManager.NetHandler.SendCallEndPacket();
            OnCallStop();
        }*/

        private void MainForm_Load(object sender, EventArgs e)
        {
            Program.Console.WriteMessage("Performing first time initialization...");
            OnLogout(true);
            if (!Directory.Exists(DataFolder)) 
            {
                Directory.CreateDirectory(DataFolder);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Console.WriteMessage("Quitting...");
            /*
            if (InCall)
            {
                OnCallStop();
                NetManager.NetHandler.SendCallEndPacket();
            }*/
            Disconnect();
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

        private void llLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new UsingPintoForm(this).ShowDialog();
        }

        private void tsmiMenuBarFileLogOut_Click(object sender, EventArgs e)
        {
            if (NetManager == null) return;
            Disconnect();
        }

        private void tsmiMenuBarHelpAbout_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog(this);
        }

        private void tsmiStatusBarStatusOnline_Click(object sender, EventArgs e)
        {
            if (NetManager == null) return;
            Program.Console.WriteMessage("[General] Changing status...");
            NetManager.ChangeStatus(UserStatus.ONLINE);
        }

        private void tsmiStatusBarStatusAway_Click(object sender, EventArgs e)
        {
            if (NetManager == null) return;
            Program.Console.WriteMessage("[General] Changing status...");
            NetManager.ChangeStatus(UserStatus.AWAY);
        }

        private void tsmiStatusBarStatusBusy_Click(object sender, EventArgs e)
        {
            if (NetManager == null) return;
            Program.Console.WriteMessage("[General] Changing status...");
            NetManager.ChangeStatus(UserStatus.BUSY);
        }

        private void tsmiStatusBarStatusInvisible_Click(object sender, EventArgs e)
        {
            if (NetManager == null) return;
            Program.Console.WriteMessage("[General] Changing status...");
            MsgBox.ShowPromptNotification(this, "If you choose to change your status to invisible," +
                " your contacts will not be able to send you messages. Are you sure you want to continue?", "Status change confirmation", 
                MsgBoxIconType.WARNING, false, (MsgBoxButtonType button) => 
            {
                if (button == MsgBoxButtonType.YES)
                    NetManager.ChangeStatus(UserStatus.INVISIBLE);
            });
        }

        private void tsmiMenuBarFileAddContact_Click(object sender, EventArgs e)
        {
            if (NetManager == null) return;
            AddContactForm addContactForm = new AddContactForm(this);
            addContactForm.ShowDialog(this);
        }

        private void tsmiMenuBarFileRemoveContact_Click(object sender, EventArgs e)
        {
            if (NetManager == null) return;
            if (dgvContacts.SelectedRows.Count < 1)
            {
                MsgBox.ShowNotification(this, "You have not selected any contact!", "Error", MsgBoxIconType.ERROR);
                return;
            }
            string contactName = ContactsMgr.GetContactNameFromRow(dgvContacts.SelectedRows[0].Index);
            NetManager.NetHandler.SendRemoveContactPacket(contactName);
        }

        private void dgvContacts_SelectionChanged(object sender, EventArgs e)
        {
            /*
            if (InCall) return;

            if (dgvContacts.SelectedRows.Count > 0)
            {
                btnStartCall.Enabled = true;
                btnStartCall.Image = Assets.STARTCALL_ENABLED;
            }
            else
            {
                btnStartCall.Enabled = false;
                btnStartCall.Image = Assets.STARTCALL_DISABLED;
            }*/
        }

        private void btnStartCall_Click(object sender, EventArgs e)
        {
            /*
            if (InCall) return;

            string contactName = ContactsMgr.GetContactNameFromRow(dgvContacts.SelectedRows[0].Index);
            Contact contact = ContactsMgr.GetContact(contactName);

            CallTarget = contactName;
            Program.Console.WriteMessage("[General] Starting call...");
            OnCallStart();

            new SoundPlayer(Sounds.CALL_INIT).Play();
            NetManager.NetHandler.SendCallStartPacket(contactName);
            if (CallClient != null && CallClient.Client != null && CallClient.Client.LocalEndPoint != null)
                NetManager.NetHandler.SendCallPartyInfoPacket(((IPEndPoint)CallClient.Client.LocalEndPoint).Port);
            else
                Program.Console.WriteMessage("[Networking] Unable to send the UDP client port!");*/
        }

        private void btnEndCall_Click(object sender, EventArgs e)
        {
            //EndCall();
        }

        private void tsmiMenuBarHelpToggleConsole_Click(object sender, EventArgs e)
        {
            if (Program.Console.Visible)
                Program.Console.Hide();
            else
                Program.Console.Show();
        }

        private void tsmiTrayExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized) 
            {
                Hide();
                niTray.ShowBalloonTip(0, "Minimization Notice", "豆子 has been minimized to the system tray!" +
                    " You can restore 豆子 by clicking on the system tray icon!", ToolTipIcon.Info);
            }
        }

        private void niTray_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void tsmiMenuBarToolsOptions_Click(object sender, EventArgs e)
        {
            OptionsForm optionsForm = new OptionsForm();
            optionsForm.ShowDialog(this);
        }

        private void tpLogin_Click(object sender, EventArgs e)
        {

        }
    }
}