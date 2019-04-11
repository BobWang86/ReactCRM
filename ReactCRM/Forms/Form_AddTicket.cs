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
    public partial class Form_AddTicket : Form
    {
        dbClient clients = new dbClient();
        dbTicket tickets = new dbTicket();
        string ClientID;

        public Form_AddTicket()
        {
            InitializeComponent();

            clients.connect();
            if (clients.connOpen() == true)
            {
                dgvClients.DataSource = clients.query($"SELECT * FROM `tbClient`").Tables[0];
            }
            clients.connClose();

            tbType.DropDownStyle = ComboBoxStyle.DropDownList;
            tbType.Items.AddRange(new string[] { "Order Status", "Bug Report", "Feature Request", "Technical Support" });
            tbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            tbStatus.Items.AddRange(new string[] { "Pending", "Responding", "Unsolved", "Solved" });
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            tickets.connect();
            if (tickets.connOpen() == true && FormValidate())
            {
                tickets.addTicket(ClientID, tbDetail.Text, tbType.Text, tbStatus.Text, tbDate.Value.ToString("yyyy-MM-dd"));

                MessageBox.Show("New Ticket Added!", "Add Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill in all the fields!", "Add Ticket", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tickets.connClose();
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
            if (tbType.Text.Length == 0)
            {
                return false;
            }

            if (tbStatus.Text.Length == 0)
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
