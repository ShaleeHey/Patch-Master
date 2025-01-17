﻿using Patch_Master.DbContext.Database;
using Patch_Master.DbContext.QueryReader;
using Patch_Master.DBHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Patch_Master.Forms
{
    public partial class DBAdder : Form
    {
        public DBAdder()
        {
            InitializeComponent();
        }

        private void connectToDB_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security = true;", ServerName.Text.Trim(), "master");

            if (!ConnectionIntregatedSecurity.Checked)
            {
                if (userName.Text.Trim() == "")
                {
                    MessageBox.Show("Please add username", "Empty username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", ServerName.Text.Trim(), "master", userName.Text.Trim(), passWord.Text.Trim());
            }       
            try
            {
                sqlHelper helper = new sqlHelper(connectionString);
                if (helper.IsConnection)
                {
                    IList<string> databaseNameList = helper.databaseNameList();
                    if (databaseNameList.Count > 0)
                    {
                        //AddDatabasesCheckboxButton(databaseNameList);
                        AddDatabaselist(databaseNameList);
                    }

                    List<string> SavedDatabasesNameList = getAvailableDatabses(ServerName.Text.ToString().Trim());
                    SavedDBChecklist.Items.Clear();
                    foreach (string savedDB in SavedDatabasesNameList)
                    {
                        SavedDBChecklist.Items.Add(savedDB,CheckState.Indeterminate);
                        for(int i =0;i< DatabaseCheckList.Items.Count; i++)
                        {
                            if (DatabaseCheckList.Items[i].ToString() == savedDB)
                            {
                                DatabaseCheckList.SetItemChecked(i,true);
                            }
                        }
                       
                    }
                    

                    // MessageBox.Show("Test connection succeeded.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DBAdder_Load(object sender, EventArgs e)
        {
            ServerName.Text = string.Format(@"{0}\SQLEXPRESS", Environment.MachineName);
            //cboServer.Items.Add(".");
            //cboServer.Items.Add("(local)");
            //cboServer.Items.Add(@".\SQLEXPRESS");
            //cboServer.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            //cboServer.SelectedIndex = 3;
        }

        public void AddDatabaselist(IList<string> databaseNameList)
        {
            DatabaseCheckList.Items.Clear();
            for (int i = 0; i < databaseNameList.Count; i++)
            {
                DatabaseCheckList.Items.Add(databaseNameList[i]);
            }

        }
        public void AddDatabasesCheckboxButton(IList<string> databaseNameList)
        {
            for (int i = 0; i < databaseNameList.Count; i++)
            {
                CheckBox rdo = new CheckBox();
                rdo.Name = "DBCheckboxButton" + i;
                rdo.Text = databaseNameList[i];
                rdo.Location = new Point(15, 30 + 30 * i);
                this.Controls.Add(rdo);
                groupBox2.Controls.Add(rdo);
            }

        }

        public void AddDatabaseToSelectedGroup(IList<string> databaseNameList)
        {

            /* TextBox tbox = new TextBox();
             tbox.Name = "DBAliasTextBox" + i;
             tbox.Text = databaseNameList[i];
             tbox.Location = new Point(15, 30 + 30 * i);
             this.Controls.Add(tbox);
             groupBox3.Controls.Add(tbox);*/

        }

        private void button2_Click(object sender, EventArgs e) //save btn
        {
            List<string> DatabaseList = new List<string>();
            List<string> RemovableDatabaseList = new List<string>();

            for (int i = 0; i <= (DatabaseCheckList.Items.Count - 1); i++)
            {
                if (DatabaseCheckList.GetItemChecked(i))
                {
                    bool IsSavedDatabase = false;
                    for (int j = 0; j < SavedDBChecklist.Items.Count; j++)
                    {
                        if (SavedDBChecklist.Items[j].ToString() == DatabaseCheckList.Items[i].ToString())
                        {
                            IsSavedDatabase = true;
                           
                        }
                    }
                    if (!IsSavedDatabase)
                    {
                        DatabaseList.Add(DatabaseCheckList.Items[i].ToString());
                    }
                    
                }
                else
                {
                    RemovableDatabaseList.Add(DatabaseCheckList.Items[i].ToString());
                }

            }

            if (RemovableDatabaseList.Count > 0)
            {
                string DatabaseServerName = ServerName.Text.ToString();
                foreach (string removeDBname in RemovableDatabaseList)
                {
                    removeDatabase(DatabaseServerName, removeDBname);
                }
            }

            if (DatabaseList.Count > 0)
            {
                foreach (string DatabaseName in DatabaseList)
                {

                    int i = 0;
                    int databaseId = SaveDatabaseDetails(DatabaseName);
                    if (databaseId > 1)
                    {
                        SavedDBChecklist.Items.Add(DatabaseName,CheckState.Checked);

                    }
                }

            }

            //get available database list
            List<string> SavedDatabasesNameList = getAvailableDatabses(ServerName.Text.ToString().Trim());
            SavedDBChecklist.Items.Clear();
            foreach (string savedDB in SavedDatabasesNameList)
            {
                SavedDBChecklist.Items.Add(savedDB, CheckState.Indeterminate);
                for (int i = 0; i < DatabaseCheckList.Items.Count; i++)
                {
                    if (DatabaseCheckList.Items[i].ToString() == savedDB)
                    {
                        DatabaseCheckList.SetItemChecked(i, true);
                    }
                }

            }


        }

        public void removeDatabase(string DatabaseServerName, string removeDBname)
        {
            DbConnector dbContext = new DbConnector();

            // DbContext dbContext = new DbContext();
            string queryString = SqlQueryStringReader.GetQueryStringById("removeDatabasefromName", "DBConnections");
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("DBName", removeDBname));
            sqlParams.Add(new SqlParameter("ServerName", DatabaseServerName));


            var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);

            if (dataReaders.Length == 0)
            {
                //label_errorMessage.Text = "Incorrect Username or Password.";
                //return 0;
            }
            var reader = dataReaders[0];

            while (reader.Read())
            {
               // DatabaseId = Convert.ToInt32(reader["DB_Id"].ToString());
            }

            dbContext.CloseConnection();
            //return DatabaseId;
        }
        public int SaveDatabaseDetails(string DatabaseName)
        {
            int DatabaseId = 0;
            string DatabaseServerName = ServerName.Text.ToString();
            string UserName = userName.Text.ToString();
            string Password = passWord.Text.ToString();
            bool isIntregatedSecurity = ConnectionIntregatedSecurity.Checked;//IntegratedSecurity.Checked;

            DbConnector dbContext = new DbConnector();

            // DbContext dbContext = new DbContext();
            string queryString = SqlQueryStringReader.GetQueryStringById("SaveDatabaseDetails", "DBConnections");
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("DBName", DatabaseName));
            sqlParams.Add(new SqlParameter("ServerName", DatabaseServerName));
            sqlParams.Add(new SqlParameter("UserName", UserName));
            sqlParams.Add(new SqlParameter("Password", Password));
            sqlParams.Add(new SqlParameter("Is_Intregatedsecurity", isIntregatedSecurity));
            sqlParams.Add(new SqlParameter("CreatedBy", 10));


            var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);

            if (dataReaders.Length == 0)
            {
                //label_errorMessage.Text = "Incorrect Username or Password.";
                return 0;
            }
            var reader = dataReaders[0];

            while (reader.Read())
            {
                DatabaseId = Convert.ToInt32(reader["DB_Id"].ToString());
            }

            dbContext.CloseConnection();
            return DatabaseId;
        }

        private void DatabaseCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void DatabaseCheckList_ItemCheck(Object sender, ItemCheckEventArgs e)
        {
            //if (e.NewValue == CheckState.Checked)
            //{

            //}
        }

        private List<string> getAvailableDatabses(string DBserverName)
        {
            List<string> AvailableDatabases = new List<string>();
            string DatabaseServerName = ServerName.Text.ToString();
            string UserName = userName.Text.ToString();
            string Password = passWord.Text.ToString();
            bool isIntregatedSecurity = ConnectionIntregatedSecurity.Checked;

           DbConnector dbContext = new DbConnector();

            // DbContext dbContext = new DbContext();
            string queryString = SqlQueryStringReader.GetQueryStringById("getAvailableDatabses", "DBConnections");
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("ServerName", DBserverName));
            
            var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);

            if (dataReaders.Length == 0)
            {
                //label_errorMessage.Text = "Incorrect Username or Password.";
                return null;
            }
            var reader = dataReaders[0];

            while (reader.Read())
            {
                AvailableDatabases.Add(reader["DBName"].ToString());
            }

            dbContext.CloseConnection();
            return AvailableDatabases;

        }
    }
}
