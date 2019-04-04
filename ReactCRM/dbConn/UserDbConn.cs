using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactCRM
{
    public class UserDbConn
    {
        private string connString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;
        public MySqlConnection sqlConn;
        public MySqlDataAdapter sqlDA;

        //User sign in authentication using stored procedure.
        public DataTable SignIn(string Email, string Password)
        {
            sqlConn = new MySqlConnection(connString);

            using (sqlConn)
            {
                sqlConn.Open();
                DataTable table = new DataTable();
                MySqlDataAdapter sqlDA = new MySqlDataAdapter();
                MySqlCommand sqlComm = new MySqlCommand("spSignIN", sqlConn);
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.Parameters.AddWithValue("_UserEmail", Email);
                sqlComm.Parameters.AddWithValue("_UserPwd", Password);
                sqlDA.SelectCommand = sqlComm;
                sqlDA.Fill(table);

                return table;
            }
        }

        //Create a new user account using stored procedure.
        //Insert emailaddress and password into database.
        public void SignUp(int UserID, string UserEmail, string UserPwd)
        {
            sqlConn = new MySqlConnection(connString);

            using (sqlConn)
            {
                sqlConn.Open();
                MySqlCommand sqlComm = new MySqlCommand("spSignUp", sqlConn);
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.Parameters.AddWithValue("_UserID", UserID);
                sqlComm.Parameters.AddWithValue("_UserEmail", UserEmail);
                sqlComm.Parameters.AddWithValue("_UserPwd", UserPwd);

                sqlComm.ExecuteNonQuery();
            }
        }

        //Update user's sign in status by changing the value from '0' to '1' under 'UserStatus' column.
        public void SignInStatus(string Email, string Password)
        {
            sqlConn = new MySqlConnection(connString);

            using (sqlConn)
            {
                sqlConn.Open();
                MySqlCommand sqlComm = new MySqlCommand("spUpdateSignIn", sqlConn);
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.Parameters.AddWithValue("_UserEmail", Email);
                sqlComm.Parameters.AddWithValue("_UserPwd", Password);

                sqlComm.ExecuteNonQuery();
            }
        }

        //Update user's sign out status by changing the value from '1' to '0' under 'UserStatus' column.
        public void SignOutStatus()
        {
            sqlConn = new MySqlConnection(connString);

            using (sqlConn)
            {
                sqlConn.Open();
                MySqlCommand sqlComm = new MySqlCommand("spUpdateSignOut", sqlConn);
                sqlComm.CommandType = CommandType.StoredProcedure;

                sqlComm.ExecuteNonQuery();
            }
        }

        //Delete an existing user using stored procedure.
        public void DeleteUser(string UserID)
        {
            using (sqlConn)
            {
                sqlConn.Open();
                MySqlCommand sqlComm = new MySqlCommand("spDeleteUser", sqlConn);
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.Parameters.AddWithValue("_UserID", UserID);

                sqlComm.ExecuteNonQuery();
            }
        }

        //Get user information from database. 
        public DataTable GetUserInfo()
        {
            sqlConn = new MySqlConnection(connString);

            using (sqlConn)
            {
                sqlConn.Open();
                DataTable table = new DataTable();
                MySqlDataAdapter sqlDA = new MySqlDataAdapter();
                MySqlCommand sqlComm = new MySqlCommand("spGetUserInfo", sqlConn);
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand = sqlComm;
                sqlDA.Fill(table);

                return table;
            }
        }

        //Get user ID from database.
        public string GetUserID()
        {
            sqlConn = new MySqlConnection(connString);

            string output;

            using (sqlConn)
            {
                sqlConn.Open();
                MySqlCommand sqlComm = new MySqlCommand("spGetUserID", sqlConn);
                sqlComm.CommandType = CommandType.StoredProcedure;

                output = sqlComm.ExecuteScalar().ToString();

                return output;
            }
        }

        //Get user email address from database.
        public string GetUserEmail()
        {
            sqlConn = new MySqlConnection(connString);

            string output;

            using (sqlConn)
            {
                sqlConn.Open();
                MySqlCommand sqlComm = new MySqlCommand("spGetUserEmail", sqlConn);
                sqlComm.CommandType = CommandType.StoredProcedure;

                output = sqlComm.ExecuteScalar().ToString();

                return output;
            }
        }
    }
}
