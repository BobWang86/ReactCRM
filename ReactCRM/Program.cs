using ReactCRM.dbConn;
using ReactCRM.Forms;
using System;
using System.Windows.Forms;

namespace ReactCRM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form_SignIn signInForm = new Form_SignIn();
            Form_SignUp signUpForm = new Form_SignUp();

            DbSQL SqlConnection = new DbSQL();

            SqlConnection.Connect();

            //Verify database connection.
            if (SqlConnection.ConnOpen() == true)
            {
                //User authentication.
                if (signInForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Form_Dashboard());
                }
                else
                {
                    Application.Exit();
                }

                //Application.Run(new Form_Dashboard());
            }
            else
            {
                //Prevent the application from running offline.
                MessageBox.Show("System is currently offline!", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Exit();
            }
            SqlConnection.ConnClose();
        }
    }
}
