using ReactCRM.dbConn;
using System;
using System.Windows.Forms;

namespace ReactCRM.Forms
{
    public partial class Form_SignUp : Form
    {
        dbUser userDbConn = new dbUser();
        int UserID = 0;

        public Form_SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (ValidateForm() && IsValidEmail(tbEmail.Text))
            {
                //Create new user account.
                //Insert user's email address and password into database using stored procedure.
                userDbConn.SignUp(UserID, tbEmail.Text, tbPassword1.Text);

                MessageBox.Show("Sign Up Successfully!");
            }
            else
            {
                MessageBox.Show("Invalid Input!");
            }
        }

        //Validate user input.
        private bool ValidateForm()
        {
            if (tbEmail.Text.Length == 0)
            {
                return false;
            }

            if (tbPassword1.Text.Length == 0)
            {
                return false;
            }

            if (tbPassword2.Text.Length == 0)
            {
                return false;
            }

            if (tbPassword1.Text != tbPassword2.Text)
            {
                return false;
            }

            return true;
        }

        //Validate email format.
        bool IsValidEmail(string email)
        {
            try
            {
                var validator = new System.Net.Mail.MailAddress(email);
                return validator.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
