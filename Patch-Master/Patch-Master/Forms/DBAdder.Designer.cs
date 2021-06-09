﻿namespace Patch_Master.Forms
{
    partial class DBAdder
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.connectProgress = new System.Windows.Forms.ProgressBar();
            this.passWord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.connectToDB = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IntegratedSecurity = new System.Windows.Forms.RadioButton();
            this.ServerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            //this.dataBaseListCheckBox = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select and add the database into your system";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connectProgress);
            this.groupBox1.Controls.Add(this.passWord);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.connectToDB);
            this.groupBox1.Controls.Add(this.userName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.IntegratedSecurity);
            this.groupBox1.Controls.Add(this.ServerName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 369);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // connectProgress
            // 
            this.connectProgress.Location = new System.Drawing.Point(12, 313);
            this.connectProgress.Name = "connectProgress";
            this.connectProgress.Size = new System.Drawing.Size(291, 20);
            this.connectProgress.TabIndex = 7;
            // 
            // passWord
            // 
            this.passWord.Location = new System.Drawing.Point(86, 199);
            this.passWord.Name = "passWord";
            this.passWord.Size = new System.Drawing.Size(217, 23);
            this.passWord.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // connectToDB
            // 
            this.connectToDB.Location = new System.Drawing.Point(210, 262);
            this.connectToDB.Name = "connectToDB";
            this.connectToDB.Size = new System.Drawing.Size(99, 32);
            this.connectToDB.TabIndex = 4;
            this.connectToDB.Text = "Connect";
            this.connectToDB.UseVisualStyleBackColor = true;
            this.connectToDB.Click += new System.EventHandler(this.connectToDB_Click);
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(86, 156);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(217, 23);
            this.userName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "User name";
            // 
            // IntegratedSecurity
            // 
            this.IntegratedSecurity.AutoSize = true;
            this.IntegratedSecurity.Location = new System.Drawing.Point(23, 87);
            this.IntegratedSecurity.Name = "IntegratedSecurity";
            this.IntegratedSecurity.Size = new System.Drawing.Size(195, 19);
            this.IntegratedSecurity.TabIndex = 2;
            this.IntegratedSecurity.TabStop = true;
            this.IntegratedSecurity.Text = "Use windows Intregated security";
            this.IntegratedSecurity.UseVisualStyleBackColor = true;
            // 
            // ServerName
            // 
            this.ServerName.Location = new System.Drawing.Point(86, 41);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(217, 23);
            this.ServerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Server Name";
            // 
            // groupBox2
            // 
           // this.groupBox2.Controls.Add(this.dataBaseListCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(363, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 368);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(556, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 367);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(756, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataBaseListCheckBox
            // 
            /*this.dataBaseListCheckBox.FormattingEnabled = true;
            this.dataBaseListCheckBox.Location = new System.Drawing.Point(16, 29);
            this.dataBaseListCheckBox.Name = "dataBaseListCheckBox";
            this.dataBaseListCheckBox.Size = new System.Drawing.Size(133, 310);
            this.dataBaseListCheckBox.TabIndex = 0;*/
            // 
            // DBAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 473);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "DBAdder";
            this.Text = "DataBase Adder";
            this.Load += new System.EventHandler(this.DBAdder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar connectProgress;
        private System.Windows.Forms.TextBox passWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button connectToDB;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton IntegratedSecurity;
        private System.Windows.Forms.TextBox ServerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        //private System.Windows.Forms.CheckedListBox dataBaseListCheckBox;
    }
}