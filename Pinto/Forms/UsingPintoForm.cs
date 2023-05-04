using PintoNS.Forms.Notification;
using PintoNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace PintoNS.Forms
{
    public partial class UsingPintoForm : Form
    {
        private MainForm mainForm;

        public UsingPintoForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void LoadLogin()
        {
            Program.Console.WriteMessage("[General] Loading saved login information...");
            try
            {
                string filePath = Path.Combine(mainForm.DataFolder, "login.json");
                if (!File.Exists(filePath)) return;

                string fileData = File.ReadAllText(filePath);
                JObject data = JsonConvert.DeserializeObject<JObject>(fileData);

                txtUsername.Text = data["username"].Value<string>();
                txtPassword.Text = data["password"].Value<string>();
                txtIP.Text = data["ip"].Value<string>();
                nudPort.Value = data["port"].Value<int>();
            }
            catch (Exception ex)
            {
                Program.Console.WriteMessage($"[General]" +
                    $" Unable to load the saved login information: {ex}");
                MsgBox.ShowNotification(this,
                    "Unable to load the saved login information!",
                    "Error", MsgBoxIconType.ERROR);
            }
        }

        private void SaveLogin()
        {
            Program.Console.WriteMessage("[General] Saving login information...");
            try
            {
                string filePath = Path.Combine(mainForm.DataFolder, "login.json");
                JObject data = new JObject();

                data.Add("username", txtUsername.Text);
                data.Add("password", txtPassword.Text);
                data.Add("ip", txtIP.Text);
                data.Add("port", (int)nudPort.Value);

                File.WriteAllText(filePath, data.ToString(Formatting.Indented));
            }
            catch (Exception ex)
            {
                Program.Console.WriteMessage($"[General]" +
                    $" Unable to save the login information: {ex}");
                MsgBox.ShowNotification(this,
                    "Unable to save the login information!",
                    "Error", MsgBoxIconType.ERROR);
            }
        }

        private void DeleteLogin()
        {
            Program.Console.WriteMessage("[General] Deleting saved login information...");
            try
            {
                string filePath = Path.Combine(mainForm.DataFolder, "login.json");
                if (File.Exists(filePath))
                    File.Delete(filePath);
            }
            catch (Exception ex)
            {
                Program.Console.WriteMessage($"[General]" +
                    $" Unable to delete the saved login information: {ex}");
                MsgBox.ShowNotification(this,
                    "Unable to delete the saved login information!",
                    "Error", MsgBoxIconType.ERROR);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MsgBox.ShowNotification(this, "Blank username or password!",
                    "Error", MsgBoxIconType.ERROR);
                return;
            }

            string ip = txtIP.Text.Trim();
            int port = (int)nudPort.Value;
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (cbSavePassword.Checked)
                SaveLogin();
            Close();
            await mainForm.Connect(ip, port, username, password);
        }


        private void UsingPintoForm_Load(object sender, EventArgs e)
        {
            tcSections.Appearance = TabAppearance.FlatButtons;
            tcSections.ItemSize = new Size(0, 1);
            tcSections.SizeMode = TabSizeMode.Fixed;
            LoadLogin();
            // Add a button to navigate to the registration page
            Button btnRegisterPage = new Button();
            btnRegisterPage.Text = "Register";
            btnRegisterPage.Size = new Size(75, 23);
            btnRegisterPage.Location = new Point(12, 12);
            btnRegisterPage.Click += BtnRegisterPage_Click;
            this.Controls.Add(btnRegisterPage);
        }

        private void BtnRegisterPage_Click(object sender, EventArgs e)
        {
            // Switch to the registration tab
            tcSections.SelectedTab = tpRegister;
        }


        private async void btnRegister_Click(object sender, EventArgs e)
        {
            string ip = txtRegisterIP.Text.Trim();
            int port = (int)nudRegisterPort.Value;
            string username = txtRegisterUsername.Text.Trim();
            string password = txtRegisterPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MsgBox.ShowNotification(this, "Blank username or password!",
                    "Error", MsgBoxIconType.ERROR);
                return;
            }

            Close();
            await mainForm.ConnectRegister(ip, port, username, password);
        }

        private void btnRegisterBack_Click(object sender, EventArgs e)
        {
            tcSections.SelectedTab = tpMain;
        }

        private void cbSavePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbSavePassword.Checked)
                DeleteLogin();
        }

        private void pbAd_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxWithPlaceholderSupport1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegisterPage_Click_1(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegisterPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Switch to the registration tab
            tcSections.SelectedTab = tpRegister;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tcSections_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DebugForm().ShowDialog();
        }

    }
}
