using System.Windows.Forms;

namespace PintoNS.Forms
{
    partial class MessageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            this.btnSend = new System.Windows.Forms.Button();
            this.rtxtInput = new System.Windows.Forms.RichTextBox();
            this.rtxtMessages = new System.Windows.Forms.RichTextBox();
            this.btnTalk = new System.Windows.Forms.Button();
            this.ilButtons = new System.Windows.Forms.ImageList(this.components);
            this.btnBlock = new System.Windows.Forms.Button();
            this.ssStatusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslStatusBarTypingList = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnColor = new System.Windows.Forms.Button();
            this.cdPicker = new System.Windows.Forms.ColorDialog();
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.tpContactsMessageForm = new System.Windows.Forms.TabPage();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.tsddbMenuBarFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiMenuBarFileClearSavedData = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearchBox = new PintoNS.Controls.TextBoxWithPlaceholderSupport();
            this.MSGFormAddContactButton = new System.Windows.Forms.Button();
            this.contactStatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.contactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssStatusStrip.SuspendLayout();
            this.tcTabs.SuspendLayout();
            this.tpContactsMessageForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(475, 444);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(69, 20);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "&Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtxtInput
            // 
            this.rtxtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtInput.HideSelection = false;
            this.rtxtInput.Location = new System.Drawing.Point(148, 403);
            this.rtxtInput.MaxLength = 384;
            this.rtxtInput.Name = "rtxtInput";
            this.rtxtInput.Size = new System.Drawing.Size(395, 35);
            this.rtxtInput.TabIndex = 0;
            this.rtxtInput.Text = "";
            this.rtxtInput.SelectionChanged += new System.EventHandler(this.rtxtInput_SelectionChanged);
            this.rtxtInput.TextChanged += new System.EventHandler(this.rtxtInput_TextChanged);
            this.rtxtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxtInput_KeyDown);
            // 
            // rtxtMessages
            // 
            this.rtxtMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtMessages.BackColor = System.Drawing.SystemColors.Window;
            this.rtxtMessages.Location = new System.Drawing.Point(148, 75);
            this.rtxtMessages.Name = "rtxtMessages";
            this.rtxtMessages.ReadOnly = true;
            this.rtxtMessages.Size = new System.Drawing.Size(396, 322);
            this.rtxtMessages.TabIndex = 2;
            this.rtxtMessages.Text = "";
            this.rtxtMessages.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtxtMessages_LinkClicked);
            this.rtxtMessages.TextChanged += new System.EventHandler(this.rtxtMessages_TextChanged);
            // 
            // btnTalk
            // 
            this.btnTalk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTalk.BackColor = System.Drawing.SystemColors.Control;
            this.btnTalk.FlatAppearance.BorderSize = 0;
            this.btnTalk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTalk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTalk.ImageKey = "TALK";
            this.btnTalk.ImageList = this.ilButtons;
            this.btnTalk.Location = new System.Drawing.Point(475, 28);
            this.btnTalk.Name = "btnTalk";
            this.btnTalk.Size = new System.Drawing.Size(68, 41);
            this.btnTalk.TabIndex = 3;
            this.btnTalk.Text = "Talk";
            this.btnTalk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTalk.UseVisualStyleBackColor = false;
            this.btnTalk.Click += new System.EventHandler(this.btnTalk_Click);
            // 
            // ilButtons
            // 
            this.ilButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilButtons.ImageStream")));
            this.ilButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilButtons.Images.SetKeyName(0, "BLOCK");
            this.ilButtons.Images.SetKeyName(1, "TALK");
            // 
            // btnBlock
            // 
            this.btnBlock.BackColor = System.Drawing.SystemColors.Control;
            this.btnBlock.FlatAppearance.BorderSize = 0;
            this.btnBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlock.ImageKey = "BLOCK";
            this.btnBlock.ImageList = this.ilButtons;
            this.btnBlock.Location = new System.Drawing.Point(148, 28);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(73, 41);
            this.btnBlock.TabIndex = 4;
            this.btnBlock.Text = "Block";
            this.btnBlock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBlock.UseVisualStyleBackColor = false;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // ssStatusStrip
            // 
            this.ssStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatusBarTypingList});
            this.ssStatusStrip.Location = new System.Drawing.Point(0, 471);
            this.ssStatusStrip.Name = "ssStatusStrip";
            this.ssStatusStrip.Size = new System.Drawing.Size(555, 22);
            this.ssStatusStrip.TabIndex = 5;
            this.ssStatusStrip.Text = "statusStrip1";
            // 
            // tsslStatusBarTypingList
            // 
            this.tsslStatusBarTypingList.Name = "tsslStatusBarTypingList";
            this.tsslStatusBarTypingList.Size = new System.Drawing.Size(0, 17);
            // 
            // btnColor
            // 
            this.btnColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColor.Location = new System.Drawing.Point(411, 444);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(58, 20);
            this.btnColor.TabIndex = 6;
            this.btnColor.Text = "Color";
            this.btnColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // tcTabs
            // 
            this.tcTabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tcTabs.Controls.Add(this.tpContactsMessageForm);
            this.tcTabs.Location = new System.Drawing.Point(12, 28);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(130, 431);
            this.tcTabs.TabIndex = 7;
            // 
            // tpContactsMessageForm
            // 
            this.tpContactsMessageForm.BackColor = System.Drawing.SystemColors.Window;
            this.tpContactsMessageForm.Controls.Add(this.dgvContacts);
            this.tpContactsMessageForm.ImageKey = "CONTACT.png";
            this.tpContactsMessageForm.Location = new System.Drawing.Point(4, 22);
            this.tpContactsMessageForm.Name = "tpContactsMessageForm";
            this.tpContactsMessageForm.Padding = new System.Windows.Forms.Padding(3);
            this.tpContactsMessageForm.Size = new System.Drawing.Size(122, 405);
            this.tpContactsMessageForm.TabIndex = 1;
            this.tpContactsMessageForm.Text = "Contacts";
            // 
            // dgvContacts
            // 
            this.dgvContacts.AllowUserToAddRows = false;
            this.dgvContacts.AllowUserToDeleteRows = false;
            this.dgvContacts.AllowUserToResizeColumns = false;
            this.dgvContacts.AllowUserToResizeRows = false;
            this.dgvContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContacts.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvContacts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContacts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvContacts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.ColumnHeadersVisible = false;
            this.dgvContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contactStatus,
            this.contactName});
            this.dgvContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContacts.Location = new System.Drawing.Point(3, 3);
            this.dgvContacts.MultiSelect = false;
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.ReadOnly = true;
            this.dgvContacts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvContacts.RowHeadersVisible = false;
            this.dgvContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContacts.Size = new System.Drawing.Size(116, 399);
            this.dgvContacts.TabIndex = 0;
            // 
            // tsddbMenuBarFile
            // 
            this.tsddbMenuBarFile.Name = "tsddbMenuBarFile";
            this.tsddbMenuBarFile.Size = new System.Drawing.Size(23, 23);
            // 
            // tsmiMenuBarFileClearSavedData
            // 
            this.tsmiMenuBarFileClearSavedData.Name = "tsmiMenuBarFileClearSavedData";
            this.tsmiMenuBarFileClearSavedData.Size = new System.Drawing.Size(32, 19);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtSearchBox.BackColor = System.Drawing.Color.White;
            this.txtSearchBox.Enabled = false;
            this.txtSearchBox.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearchBox.Location = new System.Drawing.Point(12, 2);
            this.txtSearchBox.Multiline = true;
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.PlaceholderText = "Search";
            this.txtSearchBox.PlaceholderTextForeColor = System.Drawing.Color.DimGray;
            this.txtSearchBox.Size = new System.Drawing.Size(89, 21);
            this.txtSearchBox.TabIndex = 8;
            this.txtSearchBox.Text = " Search";
            this.txtSearchBox.TextForeColor = System.Drawing.Color.Black;
            // 
            // MSGFormAddContactButton
            // 
            this.MSGFormAddContactButton.Image = global::PintoNS.Assets.ADDCONTACT_ENABLED;
            this.MSGFormAddContactButton.Location = new System.Drawing.Point(101, 1);
            this.MSGFormAddContactButton.Name = "MSGFormAddContactButton";
            this.MSGFormAddContactButton.Size = new System.Drawing.Size(34, 23);
            this.MSGFormAddContactButton.TabIndex = 9;
            this.MSGFormAddContactButton.UseVisualStyleBackColor = true;
            this.MSGFormAddContactButton.Click += new System.EventHandler(this.tsmiMenuBarFileAddContact_Click);
            // 
            // contactStatus
            // 
            this.contactStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.contactStatus.FillWeight = 24F;
            this.contactStatus.HeaderText = "Contact Status";
            this.contactStatus.Name = "contactStatus";
            this.contactStatus.ReadOnly = true;
            this.contactStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.contactStatus.Width = 24;
            // 
            // contactName
            // 
            this.contactName.FillWeight = 84F;
            this.contactName.HeaderText = "Contact Name";
            this.contactName.Name = "contactName";
            this.contactName.ReadOnly = true;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 493);
            this.Controls.Add(this.MSGFormAddContactButton);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.ssStatusStrip);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnTalk);
            this.Controls.Add(this.rtxtMessages);
            this.Controls.Add(this.rtxtInput);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tcTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageForm";
            this.Activated += new System.EventHandler(this.MessageForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MessageForm_FormClosing);
            this.ssStatusStrip.ResumeLayout(false);
            this.ssStatusStrip.PerformLayout();
            this.tcTabs.ResumeLayout(false);
            this.tpContactsMessageForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtxtInput;
        private System.Windows.Forms.RichTextBox rtxtMessages;
        private System.Windows.Forms.Button btnTalk;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.ImageList ilButtons;
        private System.Windows.Forms.StatusStrip ssStatusStrip;
        public System.Windows.Forms.ToolStripStatusLabel tsslStatusBarTypingList;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog cdPicker;
        private System.Windows.Forms.TabControl tcTabs;
        private System.Windows.Forms.TabPage tpContactsMessageForm;
        public System.Windows.Forms.DataGridView dgvContacts;
        private ToolStripDropDownButton tsddbMenuBarFile;
        private ToolStripMenuItem tsmiMenuBarFileClearSavedData;
        private Controls.TextBoxWithPlaceholderSupport txtSearchBox;
        private System.Windows.Forms.Button MSGFormAddContactButton;
        private DataGridViewImageColumn contactStatus;
        private DataGridViewTextBoxColumn contactName;
    }
}