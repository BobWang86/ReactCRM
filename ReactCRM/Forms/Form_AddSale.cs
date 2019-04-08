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
    public partial class Form_AddSale : Form
    {
        dbClient clients = new dbClient();
        dbSale sales = new dbSale();
        string ClientID;

        public Form_AddSale()
        {
            InitializeComponent();

            clients.connect();
            if (clients.connOpen() == true)
            {
                dgvClients.DataSource = clients.Query($"SELECT * FROM `tbClient`").Tables[0];
            }
            clients.connClose();

            tbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            tbProduct.Items.AddRange(new string[] { "Interactive Timetabling", "Automated Timetabling", "Attendance Monitoring", "Room Booking", "Pay Claim", "Integration", "Consultancy", "Training" });
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            sales.connect();
            if (sales.connOpen() == true && FormValidate())
            {
                sales.addSale(ClientID, tbProduct.Text, tbPrice.Text, tbDate.Value.ToString("yyyy-MM-dd"));

                MessageBox.Show("New Sale Added!", "Add Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill in all the fields!", "Add Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sales.connClose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                ClientID = dgvClients.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private bool FormValidate()
        {
            if (tbProduct.Text.Length == 0)
            {
                return false;
            }

            if (tbPrice.Text.Length == 0)
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
