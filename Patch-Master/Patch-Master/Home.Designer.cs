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
            this.tabControl_home = new System.Windows.Forms.TabControl();
            this.hometabPage_mine = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label_processCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hometabPage_all = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.AllProcessCount_label = new System.Windows.Forms.Label();
            this.ViewAllProcesses_label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl_home.SuspendLayout();
            this.hometabPage_mine.SuspendLayout();
            this.hometabPage_all.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1086, 24);
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
            this.logintoolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.logintoolStripMenuItem.Text = "Logout";
            this.logintoolStripMenuItem.Click += new System.EventHandler(this.menuStripLogin_Click);
            // 
            // toolStripMenuIAddUser
            // 
            this.toolStripMenuIAddUser.Name = "toolStripMenuIAddUser";
            this.toolStripMenuIAddUser.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuIAddUser.Text = "Manage Users";
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
            this.QueryToolStripMenu.Click += new System.EventHandler(this.FormulateQuery_Click);
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(866, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(653, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Go to Query builder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            //             // UserFirstName_label
            // 
            this.UserFirstName_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserFirstName_label.Location = new System.Drawing.Point(934, 39);
            this.UserFirstName_label.Name = "UserFirstName_label";
            this.UserFirstName_label.Size = new System.Drawing.Size(57, 15);
            this.UserFirstName_label.TabIndex = 4;
            this.UserFirstName_label.Text = "xxx";
            // 
            // tabControl_home
            // 
            this.tabControl_home.Controls.Add(this.hometabPage_mine);
            this.tabControl_home.Controls.Add(this.hometabPage_all);
            this.tabControl_home.Location = new System.Drawing.Point(0, 57);
            this.tabControl_home.Name = "tabControl_home";
            this.tabControl_home.SelectedIndex = 0;
            this.tabControl_home.Size = new System.Drawing.Size(964, 373);
            this.tabControl_home.TabIndex = 5;
            // 
            // hometabPage_mine
            // 
            this.hometabPage_mine.Controls.Add(this.label4);
            this.hometabPage_mine.Controls.Add(this.label_processCount);
            this.hometabPage_mine.Controls.Add(this.label2);
            this.hometabPage_mine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hometabPage_mine.Location = new System.Drawing.Point(4, 24);
            this.hometabPage_mine.Name = "hometabPage_mine";
            this.hometabPage_mine.Padding = new System.Windows.Forms.Padding(3);
            this.hometabPage_mine.Size = new System.Drawing.Size(956, 345);
            this.hometabPage_mine.TabIndex = 0;
            this.hometabPage_mine.Text = "View";
            this.hometabPage_mine.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(185, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "View";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // label_processCount
            // 
            this.label_processCount.AutoSize = true;
            this.label_processCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_processCount.Location = new System.Drawing.Point(142, 19);
            this.label_processCount.Name = "label_processCount";
            this.label_processCount.Size = new System.Drawing.Size(19, 21);
            this.label_processCount.TabIndex = 1;
            this.label_processCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Your Processes:";
            // 
            // hometabPage_all
            // 
            this.hometabPage_all.Controls.Add(this.ViewAllProcesses_label);
            this.hometabPage_all.Controls.Add(this.AllProcessCount_label);
            this.hometabPage_all.Controls.Add(this.label3);
            this.hometabPage_all.Location = new System.Drawing.Point(4, 24);
            this.hometabPage_all.Name = "hometabPage_all";
            this.hometabPage_all.Padding = new System.Windows.Forms.Padding(3);
            this.hometabPage_all.Size = new System.Drawing.Size(956, 345);
            this.hometabPage_all.TabIndex = 1;
            this.hometabPage_all.Text = "All";
            this.hometabPage_all.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "All Processes:";
            // 
            // AllProcessCount_label
            // 
            this.AllProcessCount_label.AutoSize = true;
            this.AllProcessCount_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AllProcessCount_label.Location = new System.Drawing.Point(130, 16);
            this.AllProcessCount_label.Name = "AllProcessCount_label";
            this.AllProcessCount_label.Size = new System.Drawing.Size(19, 21);
            this.AllProcessCount_label.TabIndex = 1;
            this.AllProcessCount_label.Text = "0";
            // 
            // ViewAllProcesses_label
            // 
            this.ViewAllProcesses_label.AutoSize = true;
            this.ViewAllProcesses_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewAllProcesses_label.Location = new System.Drawing.Point(183, 16);
            this.ViewAllProcesses_label.Name = "ViewAllProcesses_label";
            this.ViewAllProcesses_label.Size = new System.Drawing.Size(44, 21);
            this.ViewAllProcesses_label.TabIndex = 2;
            this.ViewAllProcesses_label.Text = "View";
            this.ViewAllProcesses_label.MouseEnter += new System.EventHandler(this.ViewAllProcesses_label_MouseEnter);
            this.ViewAllProcesses_label.MouseLeave += new System.EventHandler(this.ViewAllProcesses_label_MouseLeave);

            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
         //   this.Controls.Add(this.button1);
            this.ClientSize = new System.Drawing.Size(1086, 591);
            this.Controls.Add(this.tabControl_home);
            this.Controls.Add(this.UserFirstName_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.Text = "PatchMaster";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl_home.ResumeLayout(false);
            this.hometabPage_mine.ResumeLayout(false);
            this.hometabPage_mine.PerformLayout();
            this.hometabPage_all.ResumeLayout(false);
            this.hometabPage_all.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl_home;
        private System.Windows.Forms.TabPage hometabPage_mine;
        private System.Windows.Forms.TabPage hometabPage_all;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_processCount;
        private System.Windows.Forms.Label ViewAllProcesses_label;
        private System.Windows.Forms.Label AllProcessCount_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

