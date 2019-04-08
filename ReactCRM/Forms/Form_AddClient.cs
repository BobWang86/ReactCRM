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
    public partial class Form_AddClient : Form
    {
        dbClient clients = new dbClient();

        public Form_AddClient()
        {
            InitializeComponent();

            BindOptions();
        }

        private void BindOptions()
        {
            tbPipeline.DropDownStyle = ComboBoxStyle.DropDownList;
            tbSource.DropDownStyle = ComboBoxStyle.DropDownList;
            tbPipeline.Items.AddRange(new string[] { "Awareness", "Interest", "Decision", "Action" });
            tbSource.Items.AddRange(new string[] { "Call", "Email", "Referal", "Partner", "Campaign", "WebForm", "SocialMedia" });
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            clients.connect();
            if (clients.connOpen() == true && FormValidate())
            {
                clients.addClient(tbName.Text, tbEmail.Text, tbPhone.Text, tbInstitute.Text, tbSource.Text, tbValue.Text, tbPipeline.Text, tbDate.Value.ToString("yyyy-MM-dd"), tbDate.Value.ToString("yyyy-MM-dd"));

                MessageBox.Show("New Client Added!", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill in all the fields!", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clients.connClose();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Clients Generated!", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool FormValidate()
        {
            if (tbName.Text.Length == 0)
            {
                return false;
            }

            if (tbEmail.Text.Length == 0)
            {
                return false;
            }

            if (tbPhone.Text.Length == 0)
            {
                return false;
            }

            if (tbInstitute.Text.Length == 0)
            {
                return false;
            }

            if (tbSource.Text.Length == 0)
            {
                return false;
            }

            if (tbValue.Text.Length == 0)
            {
                return false;
            }

            if (tbPipeline.Text.Length == 0)
            {
                return false;
            }

            if (tbDate.Text.Length == 0)
            {
                return false;
            }

            return true;
        }
    }
}
