using ReactCRM.dbConn;
using ReactCRM.Models;
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
        string clientID;
        int clientCount;

        public Form_AddTicket()
        {
            InitializeComponent();

            clients.Connect();
            if (clients.ConnOpen() == true)
            {
                dgvClients.DataSource = clients.Query($"SELECT * FROM `tbClient`").Tables[0];
                clientCount = clients.GetClientCount(clients);
            }
            clients.ConnClose();

            tbType.DropDownStyle = ComboBoxStyle.DropDownList;
            tbType.Items.AddRange(new string[] { "Order Status", "Bug Report", "Feature Request", "Technical Support" });
            tbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            tbStatus.Items.AddRange(new string[] { "Pending", "Responding", "Unsolved", "Solved" });
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            tickets.Connect();
            if (tickets.ConnOpen() == true && FormValidate())
            {
                tickets.AddTicket(clientID, tbDetail.Text, tbType.Text, tbStatus.Text, tbDate.Value.ToString("yyyy-MM-dd"), tbDate.Value.ToString("yyyy-MM-dd"));

                clients.Connect();
                if (clients.ConnOpen() == true)
                {
                    clients.UpdateClientPipeline(clientID, "Interest");
                }
                clients.ConnClose();

                MessageBox.Show("New Ticket Added!", "Add Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill in all the fields!", "Add Ticket", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tickets.ConnClose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = tbSearch.Text;

            clients.Connect();
            if (clients.ConnOpen() == true)
            {
                dgvClients.DataSource = clients.SuperQuery($"SELECT * FROM `tbClient` Where Name LIKE '%{keyword}%' || Institute LIKE '%{keyword}%'").Tables[0];
            }
            clients.ConnClose();
        }

        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                clientID = dgvClients.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            Ticket bogusTicket = new Ticket(clientCount);

            tickets.Connect();
            if (tickets.ConnOpen() == true)
            {
                tickets.AddTicket(bogusTicket.ClientID, bogusTicket.Detail, bogusTicket.TicType, bogusTicket.TicStatus, bogusTicket.ReportDate, bogusTicket.RespondDate);
            }
            tickets.ConnClose();

            clients.Connect();
            if (clients.ConnOpen() == true)
            {
                clients.UpdateClientPipeline(bogusTicket.ClientID, "Interest");
            }
            clients.ConnClose();

            MessageBox.Show("New Tickets Generated!", "Add Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
