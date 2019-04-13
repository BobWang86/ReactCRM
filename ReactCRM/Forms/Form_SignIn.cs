using MySql.Data.MySqlClient;
using ReactCRM.dbConn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReactCRM.Forms
{
    public partial class Form_SignIn : Form
    {
        dbUser userDbConn = new dbUser();

        public Form_SignIn()
        {
            InitializeComponent();
        }

        //Open a new SignUp Form.
        private void linklbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form_SignUp().Show();
        }

        //User authentication by emailadress and password.
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            DataTable table = userDbConn.SignIn(tbEmail.Text, tbPassword.Text);

            if ((table.Rows.Count > 0))
            {
                //Update user's sign in status. 
                userDbConn.SignInStatus(tbEmail.Text, tbPassword.Text);

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
