﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ReactCRM
{
    class dbConn
    {
        ///// DB CONFIG START //////////////////////////////////////////////////////
        public string varConfigServer { get; set; }
        public string varConfigDatabase { get; set; }
        public string varConfigUser { get; set; }
        public string varConfigPass { get; set; }

        private string connString;
        public MySqlConnection conn;
        public MySqlDataAdapter sqlDA;


        ///// DB CONFIG END ////////////////////////////////////////////////////////


        public void connect()
        {//Connect to database (insecure, not using SSL or stored procedures)
            connString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;
            conn = new MySqlConnection(connString);
        }

        public bool connOpen()
        {
            try { conn.Open(); return true; }
            catch (MySqlException err)
            {//Connection error handling control statement
                switch (err.Number)
                {
                    case 0:
                        MessageBox.Show("Server connection failure");
                        break;
                    case 1045:
                        MessageBox.Show("User/Password Error");
                        break;
                    default:
                        MessageBox.Show(err.Message);
                        break;
                }
                return false;
            }
        }

        public bool connClose()
        {//Connection close with error handling
            try { conn.Close(); return true; }
            catch (MySqlException err) { MessageBox.Show("Error: " + err.Message); return false; }
        }

        public DataSet Query(string sql)
        {//Run sql query in argument and return dataset
            sqlDA = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds);
            connClose();
            return ds;
        }
    }
}
