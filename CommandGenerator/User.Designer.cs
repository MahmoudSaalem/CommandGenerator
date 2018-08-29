﻿namespace CommandGenerator
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Commands = new System.Windows.Forms.TabPage();
            this.pnlCommands = new System.Windows.Forms.Panel();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ExcuteBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CmdGrid = new System.Windows.Forms.DataGridView();
            this.Refresh = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BrowzeBtn = new System.Windows.Forms.Button();
            this.SheetsCB = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ManageUsers = new System.Windows.Forms.TabPage();
            this.pnlManageUsers = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usersGB = new System.Windows.Forms.GroupBox();
            this.btnAdd = new CommandGenerator.CircularButton();
            this.usersGrid = new System.Windows.Forms.DataGridView();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ManageNetwork = new System.Windows.Forms.TabPage();
            this.pnlManageNetwork = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.circularButton1 = new CommandGenerator.CircularButton();
            this.NetworkGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.Commands.SuspendLayout();
            this.pnlCommands.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmdGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.ManageUsers.SuspendLayout();
            this.pnlManageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.usersGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).BeginInit();
            this.ManageNetwork.SuspendLayout();
            this.pnlManageNetwork.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NetworkGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Commands);
            this.tabControl1.Controls.Add(this.ManageUsers);
            this.tabControl1.Controls.Add(this.ManageNetwork);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1006, 721);
            this.tabControl1.TabIndex = 2;
            // 
            // Commands
            // 
            this.Commands.Controls.Add(this.pnlCommands);
            this.Commands.Location = new System.Drawing.Point(4, 26);
            this.Commands.Name = "Commands";
            this.Commands.Padding = new System.Windows.Forms.Padding(3);
            this.Commands.Size = new System.Drawing.Size(998, 691);
            this.Commands.TabIndex = 0;
            this.Commands.Text = "Commands";
            this.Commands.UseVisualStyleBackColor = true;
            // 
            // pnlCommands
            // 
            this.pnlCommands.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCommands.BackgroundImage")));
            this.pnlCommands.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCommands.Controls.Add(this.ClearBtn);
            this.pnlCommands.Controls.Add(this.ExcuteBtn);
            this.pnlCommands.Controls.Add(this.groupBox2);
            this.pnlCommands.Controls.Add(this.BrowzeBtn);
            this.pnlCommands.Controls.Add(this.SheetsCB);
            this.pnlCommands.Controls.Add(this.pictureBox2);
            this.pnlCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCommands.Location = new System.Drawing.Point(3, 3);
            this.pnlCommands.Name = "pnlCommands";
            this.pnlCommands.Size = new System.Drawing.Size(992, 685);
            this.pnlCommands.TabIndex = 0;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(27, 474);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(115, 58);
            this.ClearBtn.TabIndex = 12;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ExcuteBtn
            // 
            this.ExcuteBtn.Enabled = false;
            this.ExcuteBtn.Location = new System.Drawing.Point(187, 474);
            this.ExcuteBtn.Name = "ExcuteBtn";
            this.ExcuteBtn.Size = new System.Drawing.Size(115, 58);
            this.ExcuteBtn.TabIndex = 11;
            this.ExcuteBtn.Text = "Excute";
            this.ExcuteBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CmdGrid);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(326, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 679);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commands Sheet";
            // 
            // CmdGrid
            // 
            this.CmdGrid.AllowUserToAddRows = false;
            this.CmdGrid.AllowUserToDeleteRows = false;
            this.CmdGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CmdGrid.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.CmdGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CmdGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Refresh});
            this.CmdGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmdGrid.Location = new System.Drawing.Point(3, 19);
            this.CmdGrid.Name = "CmdGrid";
            this.CmdGrid.ReadOnly = true;
            this.CmdGrid.RowTemplate.Height = 24;
            this.CmdGrid.Size = new System.Drawing.Size(655, 657);
            this.CmdGrid.TabIndex = 6;
            this.CmdGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CmdGrid_CellContentClick);
            // 
            // Refresh
            // 
            this.Refresh.HeaderText = "Refresh";
            this.Refresh.Name = "Refresh";
            this.Refresh.ReadOnly = true;
            // 
            // BrowzeBtn
            // 
            this.BrowzeBtn.Location = new System.Drawing.Point(27, 281);
            this.BrowzeBtn.Name = "BrowzeBtn";
            this.BrowzeBtn.Size = new System.Drawing.Size(115, 58);
            this.BrowzeBtn.TabIndex = 8;
            this.BrowzeBtn.Text = "Browse";
            this.BrowzeBtn.UseVisualStyleBackColor = true;
            this.BrowzeBtn.Click += new System.EventHandler(this.BrowzeBtn_Click);
            // 
            // SheetsCB
            // 
            this.SheetsCB.FormattingEnabled = true;
            this.SheetsCB.Location = new System.Drawing.Point(27, 203);
            this.SheetsCB.Name = "SheetsCB";
            this.SheetsCB.Size = new System.Drawing.Size(275, 25);
            this.SheetsCB.TabIndex = 7;
            this.SheetsCB.SelectedIndexChanged += new System.EventHandler(this.SheetsCB_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 582);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(30, 32, 30, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // ManageUsers
            // 
            this.ManageUsers.Controls.Add(this.pnlManageUsers);
            this.ManageUsers.Location = new System.Drawing.Point(4, 26);
            this.ManageUsers.Name = "ManageUsers";
            this.ManageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.ManageUsers.Size = new System.Drawing.Size(998, 691);
            this.ManageUsers.TabIndex = 1;
            this.ManageUsers.Text = "Manage Users";
            this.ManageUsers.UseVisualStyleBackColor = true;
            // 
            // pnlManageUsers
            // 
            this.pnlManageUsers.BackColor = System.Drawing.Color.Transparent;
            this.pnlManageUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlManageUsers.BackgroundImage")));
            this.pnlManageUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlManageUsers.Controls.Add(this.pictureBox1);
            this.pnlManageUsers.Controls.Add(this.usersGB);
            this.pnlManageUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlManageUsers.Location = new System.Drawing.Point(3, 3);
            this.pnlManageUsers.Name = "pnlManageUsers";
            this.pnlManageUsers.Size = new System.Drawing.Size(992, 685);
            this.pnlManageUsers.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 582);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(30, 32, 30, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // usersGB
            // 
            this.usersGB.Controls.Add(this.btnAdd);
            this.usersGB.Controls.Add(this.usersGrid);
            this.usersGB.ForeColor = System.Drawing.Color.White;
            this.usersGB.Location = new System.Drawing.Point(326, 3);
            this.usersGB.Name = "usersGB";
            this.usersGB.Size = new System.Drawing.Size(661, 679);
            this.usersGB.TabIndex = 5;
            this.usersGB.TabStop = false;
            this.usersGB.Text = "Users";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(586, 608);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(52, 51);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // usersGrid
            // 
            this.usersGrid.AllowUserToAddRows = false;
            this.usersGrid.AllowUserToDeleteRows = false;
            this.usersGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.usersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersGrid.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.usersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Remove});
            this.usersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.usersGrid.Location = new System.Drawing.Point(3, 19);
            this.usersGrid.Name = "usersGrid";
            this.usersGrid.RowTemplate.Height = 24;
            this.usersGrid.Size = new System.Drawing.Size(655, 657);
            this.usersGrid.TabIndex = 0;
            this.usersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersGrid_CellContentClick);
            this.usersGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersGrid_CellDoubleClick);
            this.usersGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersGrid_CellEndEdit);
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove";
            this.Remove.Name = "Remove";
            this.Remove.Text = "";
            // 
            // ManageNetwork
            // 
            this.ManageNetwork.Controls.Add(this.pnlManageNetwork);
            this.ManageNetwork.Location = new System.Drawing.Point(4, 26);
            this.ManageNetwork.Name = "ManageNetwork";
            this.ManageNetwork.Padding = new System.Windows.Forms.Padding(3);
            this.ManageNetwork.Size = new System.Drawing.Size(998, 691);
            this.ManageNetwork.TabIndex = 2;
            this.ManageNetwork.Text = "Manage Network";
            this.ManageNetwork.UseVisualStyleBackColor = true;
            // 
            // pnlManageNetwork
            // 
            this.pnlManageNetwork.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlManageNetwork.BackgroundImage")));
            this.pnlManageNetwork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlManageNetwork.Controls.Add(this.groupBox1);
            this.pnlManageNetwork.Controls.Add(this.pictureBox3);
            this.pnlManageNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlManageNetwork.Location = new System.Drawing.Point(3, 3);
            this.pnlManageNetwork.Name = "pnlManageNetwork";
            this.pnlManageNetwork.Size = new System.Drawing.Size(992, 685);
            this.pnlManageNetwork.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.circularButton1);
            this.groupBox1.Controls.Add(this.NetworkGrid);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(326, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 679);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Networks";
            // 
            // circularButton1
            // 
            this.circularButton1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.circularButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.circularButton1.Image = ((System.Drawing.Image)(resources.GetObject("circularButton1.Image")));
            this.circularButton1.Location = new System.Drawing.Point(586, 608);
            this.circularButton1.Name = "circularButton1";
            this.circularButton1.Size = new System.Drawing.Size(52, 51);
            this.circularButton1.TabIndex = 1;
            this.circularButton1.UseVisualStyleBackColor = false;
            this.circularButton1.Click += new System.EventHandler(this.circularButton1_Click);
            // 
            // NetworkGrid
            // 
            this.NetworkGrid.AllowUserToAddRows = false;
            this.NetworkGrid.AllowUserToDeleteRows = false;
            this.NetworkGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NetworkGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.NetworkGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NetworkGrid.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.NetworkGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NetworkGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1});
            this.NetworkGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NetworkGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.NetworkGrid.Location = new System.Drawing.Point(3, 19);
            this.NetworkGrid.Name = "NetworkGrid";
            this.NetworkGrid.RowTemplate.Height = 24;
            this.NetworkGrid.Size = new System.Drawing.Size(655, 657);
            this.NetworkGrid.TabIndex = 0;
            this.NetworkGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NetworkGrid_CellContentClick);
            this.NetworkGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NetworkGrid_CellContentDoubleClick);
            this.NetworkGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.NetworkGrid_CellEndEdit);
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Remove";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(27, 582);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(30, 32, 30, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 74);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Command Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_FormClosing);
            this.Load += new System.EventHandler(this.User_Load);
            this.tabControl1.ResumeLayout(false);
            this.Commands.ResumeLayout(false);
            this.pnlCommands.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CmdGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ManageUsers.ResumeLayout(false);
            this.pnlManageUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.usersGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).EndInit();
            this.ManageNetwork.ResumeLayout(false);
            this.pnlManageNetwork.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NetworkGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Commands;
        private System.Windows.Forms.TabPage ManageUsers;
        private System.Windows.Forms.Panel pnlManageUsers;
        private System.Windows.Forms.GroupBox usersGB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.Panel pnlCommands;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage ManageNetwork;
        private System.Windows.Forms.Panel pnlManageNetwork;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.DataGridView usersGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView NetworkGrid;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.Button ExcuteBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView CmdGrid;
        private System.Windows.Forms.Button BrowzeBtn;
        private System.Windows.Forms.ComboBox SheetsCB;
        private System.Windows.Forms.DataGridViewButtonColumn Refresh;
        private CommandGenerator.CircularButton btnAdd;
        private CommandGenerator.CircularButton circularButton1;
        private System.Windows.Forms.Button ClearBtn;
    }
}