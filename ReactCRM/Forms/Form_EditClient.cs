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
    public partial class Form_EditClient : Form
    {
        dbClient clients = new dbClient();
        string ClientID;
        string AddDate;

        public Form_EditClient(DataTable selectedClient)
        {
            InitializeComponent();

            ClientID = selectedClient.Rows[0][0].ToString();
            tbName.Text = selectedClient.Rows[0][1].ToString();
            tbEmail.Text = selectedClient.Rows[0][2].ToString();
            tbPhone.Text = selectedClient.Rows[0][3].ToString();
            tbInstitute.Text = selectedClient.Rows[0][4].ToString();
            tbSource.Text = selectedClient.Rows[0][5].ToString();
            tbValue.Text = selectedClient.Rows[0][6].ToString();
            tbPipeline.Text = selectedClient.Rows[0][7].ToString();
            AddDate = selectedClient.Rows[0][8].ToString();
            tbDate.Text = selectedClient.Rows[0][9].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clients.connect();
            if (clients.connOpen() == true && FormValidate())
            {
                clients.updateClient(ClientID, tbName.Text, tbEmail.Text, tbPhone.Text, tbInstitute.Text, tbSource.Text, tbValue.Text, tbPipeline.Text, AddDate, tbDate.Value.ToString("yyyy-MM-dd"));

                MessageBox.Show("Client Info Updated!", "Edit Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill in all the fields!", "Edit Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clients.connClose();
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
