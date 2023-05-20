﻿
namespace PintoNS.Forms
{
    partial class ServerListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerListForm));
            this.btnUse = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvServersOfficial = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.users = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max_users = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcSections = new System.Windows.Forms.TabControl();
            this.tpLoading = new System.Windows.Forms.TabPage();
            this.lLoading = new System.Windows.Forms.Label();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.tpServers = new System.Windows.Forms.TabPage();
            this.tcServers = new System.Windows.Forms.TabControl();
            this.tpServersOfficial = new System.Windows.Forms.TabPage();
            this.tpServersUnofficial = new System.Windows.Forms.TabPage();
            this.dgvServersUnofficial = new System.Windows.Forms.DataGridView();
            this.name2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.port2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.users2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max_users2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tags2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServersOfficial)).BeginInit();
            this.tcSections.SuspendLayout();
            this.tpLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.tpServers.SuspendLayout();
            this.tcServers.SuspendLayout();
            this.tpServersOfficial.SuspendLayout();
            this.tpServersUnofficial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServersUnofficial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUse
            // 
            this.btnUse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUse.Location = new System.Drawing.Point(599, 425);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(75, 23);
            this.btnUse.TabIndex = 0;
            this.btnUse.Text = "Use";
            this.btnUse.UseVisualStyleBackColor = true;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(518, 425);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvServersOfficial
            // 
            this.dgvServersOfficial.AllowUserToAddRows = false;
            this.dgvServersOfficial.AllowUserToDeleteRows = false;
            this.dgvServersOfficial.AllowUserToResizeColumns = false;
            this.dgvServersOfficial.AllowUserToResizeRows = false;
            this.dgvServersOfficial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServersOfficial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServersOfficial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.ip,
            this.port,
            this.users,
            this.max_users,
            this.tags});
            this.dgvServersOfficial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServersOfficial.Location = new System.Drawing.Point(3, 3);
            this.dgvServersOfficial.MultiSelect = false;
            this.dgvServersOfficial.Name = "dgvServersOfficial";
            this.dgvServersOfficial.ReadOnly = true;
            this.dgvServersOfficial.RowHeadersVisible = false;
            this.dgvServersOfficial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServersOfficial.ShowEditingIcon = false;
            this.dgvServersOfficial.Size = new System.Drawing.Size(634, 343);
            this.dgvServersOfficial.TabIndex = 2;
            this.dgvServersOfficial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServersOfficial_CellContentClick);
            this.dgvServersOfficial.SelectionChanged += new System.EventHandler(this.dgvServers_SelectionChanged);
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // ip
            // 
            this.ip.HeaderText = "IP";
            this.ip.Name = "ip";
            this.ip.ReadOnly = true;
            // 
            // port
            // 
            this.port.HeaderText = "Port";
            this.port.Name = "port";
            this.port.ReadOnly = true;
            // 
            // users
            // 
            this.users.HeaderText = "Users";
            this.users.Name = "users";
            this.users.ReadOnly = true;
            // 
            // max_users
            // 
            this.max_users.HeaderText = "Max Users";
            this.max_users.Name = "max_users";
            this.max_users.ReadOnly = true;
            // 
            // tags
            // 
            this.tags.HeaderText = "Tags";
            this.tags.Name = "tags";
            this.tags.ReadOnly = true;
            // 
            // tcSections
            // 
            this.tcSections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcSections.Controls.Add(this.tpLoading);
            this.tcSections.Controls.Add(this.tpServers);
            this.tcSections.Location = new System.Drawing.Point(12, 12);
            this.tcSections.Name = "tcSections";
            this.tcSections.SelectedIndex = 0;
            this.tcSections.Size = new System.Drawing.Size(662, 407);
            this.tcSections.TabIndex = 3;
            // 
            // tpLoading
            // 
            this.tpLoading.Controls.Add(this.lLoading);
            this.tpLoading.Controls.Add(this.pbLoading);
            this.tpLoading.Location = new System.Drawing.Point(4, 22);
            this.tpLoading.Name = "tpLoading";
            this.tpLoading.Size = new System.Drawing.Size(654, 381);
            this.tpLoading.TabIndex = 1;
            this.tpLoading.Text = "Loading";
            this.tpLoading.UseVisualStyleBackColor = true;
            // 
            // lLoading
            // 
            this.lLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lLoading.AutoSize = true;
            this.lLoading.Location = new System.Drawing.Point(309, 260);
            this.lLoading.Name = "lLoading";
            this.lLoading.Size = new System.Drawing.Size(45, 13);
            this.lLoading.TabIndex = 1;
            this.lLoading.Text = "Loading";
            // 
            // pbLoading
            // 
            this.pbLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLoading.Image = global::PintoNS.Logo.LOADING;
            this.pbLoading.Location = new System.Drawing.Point(267, 107);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(128, 128);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoading.TabIndex = 0;
            this.pbLoading.TabStop = false;
            this.pbLoading.Click += new System.EventHandler(this.pbLoading_Click);
            // 
            // tpServers
            // 
            this.tpServers.Controls.Add(this.tcServers);
            this.tpServers.Location = new System.Drawing.Point(4, 22);
            this.tpServers.Name = "tpServers";
            this.tpServers.Padding = new System.Windows.Forms.Padding(3);
            this.tpServers.Size = new System.Drawing.Size(654, 381);
            this.tpServers.TabIndex = 0;
            this.tpServers.Text = "Servers";
            this.tpServers.UseVisualStyleBackColor = true;
            // 
            // tcServers
            // 
            this.tcServers.Controls.Add(this.tpServersOfficial);
            this.tcServers.Controls.Add(this.tpServersUnofficial);
            this.tcServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcServers.Location = new System.Drawing.Point(3, 3);
            this.tcServers.Name = "tcServers";
            this.tcServers.SelectedIndex = 0;
            this.tcServers.Size = new System.Drawing.Size(648, 375);
            this.tcServers.TabIndex = 3;
            // 
            // tpServersOfficial
            // 
            this.tpServersOfficial.Controls.Add(this.dgvServersOfficial);
            this.tpServersOfficial.Location = new System.Drawing.Point(4, 22);
            this.tpServersOfficial.Name = "tpServersOfficial";
            this.tpServersOfficial.Padding = new System.Windows.Forms.Padding(3);
            this.tpServersOfficial.Size = new System.Drawing.Size(640, 349);
            this.tpServersOfficial.TabIndex = 0;
            this.tpServersOfficial.Text = "Official";
            this.tpServersOfficial.UseVisualStyleBackColor = true;
            // 
            // tpServersUnofficial
            // 
            this.tpServersUnofficial.Controls.Add(this.dgvServersUnofficial);
            this.tpServersUnofficial.Location = new System.Drawing.Point(4, 22);
            this.tpServersUnofficial.Name = "tpServersUnofficial";
            this.tpServersUnofficial.Padding = new System.Windows.Forms.Padding(3);
            this.tpServersUnofficial.Size = new System.Drawing.Size(640, 349);
            this.tpServersUnofficial.TabIndex = 1;
            this.tpServersUnofficial.Text = "Un-official";
            this.tpServersUnofficial.UseVisualStyleBackColor = true;
            // 
            // dgvServersUnofficial
            // 
            this.dgvServersUnofficial.AllowUserToAddRows = false;
            this.dgvServersUnofficial.AllowUserToDeleteRows = false;
            this.dgvServersUnofficial.AllowUserToResizeColumns = false;
            this.dgvServersUnofficial.AllowUserToResizeRows = false;
            this.dgvServersUnofficial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServersUnofficial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServersUnofficial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name2,
            this.ip2,
            this.port2,
            this.users2,
            this.max_users2,
            this.tags2});
            this.dgvServersUnofficial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServersUnofficial.Location = new System.Drawing.Point(3, 3);
            this.dgvServersUnofficial.MultiSelect = false;
            this.dgvServersUnofficial.Name = "dgvServersUnofficial";
            this.dgvServersUnofficial.ReadOnly = true;
            this.dgvServersUnofficial.RowHeadersVisible = false;
            this.dgvServersUnofficial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServersUnofficial.ShowEditingIcon = false;
            this.dgvServersUnofficial.Size = new System.Drawing.Size(634, 343);
            this.dgvServersUnofficial.TabIndex = 3;
            this.dgvServersUnofficial.SelectionChanged += new System.EventHandler(this.dgvServersUnofficial_SelectionChanged);
            // 
            // name2
            // 
            this.name2.HeaderText = "Name";
            this.name2.Name = "name2";
            this.name2.ReadOnly = true;
            // 
            // ip2
            // 
            this.ip2.HeaderText = "IP";
            this.ip2.Name = "ip2";
            this.ip2.ReadOnly = true;
            // 
            // port2
            // 
            this.port2.HeaderText = "Port";
            this.port2.Name = "port2";
            this.port2.ReadOnly = true;
            // 
            // users2
            // 
            this.users2.HeaderText = "Users";
            this.users2.Name = "users2";
            this.users2.ReadOnly = true;
            // 
            // max_users2
            // 
            this.max_users2.HeaderText = "Max Users";
            this.max_users2.Name = "max_users2";
            this.max_users2.ReadOnly = true;
            // 
            // tags2
            // 
            this.tags2.HeaderText = "Tags";
            this.tags2.Name = "tags2";
            this.tags2.ReadOnly = true;
            // 
            // lError
            // 
            this.lError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lError.AutoSize = true;
            this.lError.ForeColor = System.Drawing.Color.Red;
            this.lError.Location = new System.Drawing.Point(13, 422);
            this.lError.Name = "lError";
            this.lError.Size = new System.Drawing.Size(54, 13);
            this.lError.TabIndex = 4;
            this.lError.Text = "Error: null ";
            this.lError.Visible = false;
            // 
            // ServerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 460);
            this.Controls.Add(this.lError);
            this.Controls.Add(this.tcSections);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(291, 323);
            this.Name = "ServerListForm";
            this.Text = "Pinto! - Server List";
            this.Load += new System.EventHandler(this.ServerListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServersOfficial)).EndInit();
            this.tcSections.ResumeLayout(false);
            this.tpLoading.ResumeLayout(false);
            this.tpLoading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.tpServers.ResumeLayout(false);
            this.tcServers.ResumeLayout(false);
            this.tpServersOfficial.ResumeLayout(false);
            this.tpServersUnofficial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServersUnofficial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvServersOfficial;
        private System.Windows.Forms.TabControl tcSections;
        private System.Windows.Forms.TabPage tpServers;
        private System.Windows.Forms.TabPage tpLoading;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Label lLoading;
        private System.Windows.Forms.Label lError;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn port;
        private System.Windows.Forms.DataGridViewTextBoxColumn users;
        private System.Windows.Forms.DataGridViewTextBoxColumn max_users;
        private System.Windows.Forms.DataGridViewTextBoxColumn tags;
        private System.Windows.Forms.TabControl tcServers;
        private System.Windows.Forms.TabPage tpServersOfficial;
        private System.Windows.Forms.TabPage tpServersUnofficial;
        private System.Windows.Forms.DataGridView dgvServersUnofficial;
        private System.Windows.Forms.DataGridViewTextBoxColumn name2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip2;
        private System.Windows.Forms.DataGridViewTextBoxColumn port2;
        private System.Windows.Forms.DataGridViewTextBoxColumn users2;
        private System.Windows.Forms.DataGridViewTextBoxColumn max_users2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tags2;
    }
}