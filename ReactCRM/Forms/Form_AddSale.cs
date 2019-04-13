using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class Form_AddSale : Form
    {
        dbClient clients = new dbClient();
        dbSale sales = new dbSale();
        string ClientID;
        int clientCount;

        public Form_AddSale()
        {
            InitializeComponent();

            clients.Connect();
            if (clients.ConnOpen() == true)
            {
                dgvClients.DataSource = clients.Query($"SELECT * FROM `tbClient`").Tables[0];
                clientCount = clients.GetClientCount(clients);
            }
            clients.ConnClose();

            tbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            tbProduct.Items.AddRange(new string[] { "Interactive Timetabling", "Automated Timetabling", "Attendance Monitoring", "Room Booking", "Pay Claim", "Integration", "Consultancy", "Training" });
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            sales.Connect();
            if (sales.ConnOpen() == true && FormValidate())
            {
                sales.AddSale(ClientID, tbProduct.Text, tbPrice.Value, tbDate.Value.ToString("yyyy-MM-dd"));

                MessageBox.Show("New Sale Added!", "Add Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill in all the fields!", "Add Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sales.ConnClose();
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
                ClientID = dgvClients.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            Sale bogusSale = new Sale(clientCount);

            sales.Connect();
            if (sales.ConnOpen() == true)
            {
                sales.AddSale(bogusSale.ClientID, bogusSale.Product, bogusSale.Price, bogusSale.Date);

                if (bogusSale.Product == "Integration" || bogusSale.Product == "Consultancy" || bogusSale.Product == "Training")
                {
                    clients.Connect();
                    if (clients.ConnOpen() == true)
                    {
                        clients.UpdateClientPipeline(bogusSale.ClientID, "Decision");
                    }
                    clients.ConnClose();
                }
                else
                {
                    clients.Connect();
                    if (clients.ConnOpen() == true)
                    {
                        clients.UpdateClientPipeline(bogusSale.ClientID, "Action");
                    }
                    clients.ConnClose();
                }

                MessageBox.Show("New Sales Generated!", "Add Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
