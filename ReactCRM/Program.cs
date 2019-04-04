using ReactCRM.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

            SignInForm signInForm = new SignInForm();
            SignUpForm signUpForm = new SignUpForm();

            dbConn SqlConnection = new dbConn();

            SqlConnection.connect();

            //Verify database connection.
            if (SqlConnection.connOpen() == true)
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
            }
            else
            {
                //Prevent the application from running offline.
                MessageBox.Show("System is currently offline!", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Exit();
            }
            SqlConnection.connClose();
        }
    }
}
