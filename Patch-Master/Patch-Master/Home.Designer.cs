﻿
using System;

namespace Patch_Master
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            System.Environment.Exit(0);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logintoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuIAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.connectDbToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.requirementsToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.QueryToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.requirementToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AprovalToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.processesToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.requestToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MakeRequestToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ApproveRequestToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExecuteRequestToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.UserFirstName_label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenu,
            this.databaseToolStripMenu,
            this.requirementsToolStripMenu,
            this.requestToolStripMenu,
            this.reportToolStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            this.menuStrip1.Click += new System.EventHandler(this.menuStrip1_Click);
            // 
            // userToolStripMenu
            // 
            this.userToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logintoolStripMenuItem,
            this.toolStripMenuIAddUser});
            this.userToolStripMenu.Name = "userToolStripMenu";
            this.userToolStripMenu.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenu.Text = "User";
            // 
            // logintoolStripMenuItem
            // 
            this.logintoolStripMenuItem.Name = "logintoolStripMenuItem";
            this.logintoolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.logintoolStripMenuItem.Text = "Logout";
            this.logintoolStripMenuItem.Click += new System.EventHandler(this.menuStripLogin_Click);
            // 
            // toolStripMenuIAddUser
            // 
            this.toolStripMenuIAddUser.Name = "toolStripMenuIAddUser";
            this.toolStripMenuIAddUser.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuIAddUser.Text = "Add User";
            this.toolStripMenuIAddUser.Click += new System.EventHandler(this.UserList_Click);
            // 
            // databaseToolStripMenu
            // 
            this.databaseToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectDbToolStripMenu});
            this.databaseToolStripMenu.Name = "databaseToolStripMenu";
            this.databaseToolStripMenu.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenu.Text = "Database";
            // 
            // connectDbToolStripMenu
            // 
            this.connectDbToolStripMenu.Name = "connectDbToolStripMenu";
            this.connectDbToolStripMenu.Size = new System.Drawing.Size(119, 22);
            this.connectDbToolStripMenu.Text = "Connect";
            this.connectDbToolStripMenu.Click += new System.EventHandler(this.ConnectDb_Click);
            // 
            // requirementsToolStripMenu
            // 
            this.requirementsToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QueryToolStripMenu,
            this.requirementToolStripMenu,
            this.AprovalToolStripMenu,
            this.processesToolStripMenu});
            this.requirementsToolStripMenu.Name = "requirementsToolStripMenu";
            this.requirementsToolStripMenu.Size = new System.Drawing.Size(92, 20);
            this.requirementsToolStripMenu.Text = "Requirements";
            // 
            // QueryToolStripMenu
            // 
            this.QueryToolStripMenu.Name = "QueryToolStripMenu";
            this.QueryToolStripMenu.Size = new System.Drawing.Size(202, 22);
            this.QueryToolStripMenu.Text = "Formulate Query";
            // 
            // requirementToolStripMenu
            // 
            this.requirementToolStripMenu.Name = "requirementToolStripMenu";
            this.requirementToolStripMenu.Size = new System.Drawing.Size(202, 22);
            this.requirementToolStripMenu.Text = "Requirement Definitions";
            this.requirementToolStripMenu.Click += new System.EventHandler(this.DefineRequirements_Click);
            // 
            // AprovalToolStripMenu
            // 
            this.AprovalToolStripMenu.Name = "AprovalToolStripMenu";
            this.AprovalToolStripMenu.Size = new System.Drawing.Size(202, 22);
            this.AprovalToolStripMenu.Text = "Define Approvals";
            // 
            // processesToolStripMenu
            // 
            this.processesToolStripMenu.Name = "processesToolStripMenu";
            this.processesToolStripMenu.Size = new System.Drawing.Size(202, 22);
            this.processesToolStripMenu.Text = "Processes";
            this.processesToolStripMenu.Click += new System.EventHandler(this.Processes_Click);
            // 
            // requestToolStripMenu
            // 
            this.requestToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MakeRequestToolStripMenu,
            this.ApproveRequestToolStripMenu,
            this.ExecuteRequestToolStripMenu});
            this.requestToolStripMenu.Name = "requestToolStripMenu";
            this.requestToolStripMenu.Size = new System.Drawing.Size(66, 20);
            this.requestToolStripMenu.Text = "Requests";
            // 
            // MakeRequestToolStripMenu
            // 
            this.MakeRequestToolStripMenu.Name = "MakeRequestToolStripMenu";
            this.MakeRequestToolStripMenu.Size = new System.Drawing.Size(164, 22);
            this.MakeRequestToolStripMenu.Text = "Make Request";
            // 
            // ApproveRequestToolStripMenu
            // 
            this.ApproveRequestToolStripMenu.Name = "ApproveRequestToolStripMenu";
            this.ApproveRequestToolStripMenu.Size = new System.Drawing.Size(164, 22);
            this.ApproveRequestToolStripMenu.Text = "Approve Request";
            // 
            // ExecuteRequestToolStripMenu
            // 
            this.ExecuteRequestToolStripMenu.Name = "ExecuteRequestToolStripMenu";
            this.ExecuteRequestToolStripMenu.Size = new System.Drawing.Size(164, 22);
            this.ExecuteRequestToolStripMenu.Text = "Execute Request";
            // 
            // reportToolStripMenu
            // 
            this.reportToolStripMenu.Name = "reportToolStripMenu";
            this.reportToolStripMenu.Size = new System.Drawing.Size(59, 20);
            this.reportToolStripMenu.Text = "Reports";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(668, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserFirstName_label
            // 
            this.UserFirstName_label.Location = new System.Drawing.Point(725, 35);
            this.UserFirstName_label.Name = "UserFirstName_label";
            this.UserFirstName_label.Size = new System.Drawing.Size(57, 15);
            this.UserFirstName_label.TabIndex = 4;
            this.UserFirstName_label.Text = "xxx";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserFirstName_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "PatchMaster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem logintoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuIAddUser;
        private System.Windows.Forms.ToolStripMenuItem connectDbToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem requirementsToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem requestToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem QueryToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem requirementToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem AprovalToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem processesToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem MakeRequestToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem ApproveRequestToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem ExecuteRequestToolStripMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserFirstName_label;
    }
}

