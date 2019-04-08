using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReactCRM.Forms;
using ReactCRM.dbConn;

namespace ReactCRM.UserControls
{
    public partial class UC_ManageClients : UserControl
    {
        string ClientID;

        dbClient clients = new dbClient();

        public DataTable selectedClient = new DataTable();

        public UC_ManageClients()
        {
            InitializeComponent();

            clients.connect();
            if (clients.connOpen() == true)
            {
                dgvClients.DataSource = clients.Query($"SELECT * FROM `tbClient`").Tables[0];
            }
            clients.connClose();

            foreach (DataGridViewColumn column in dgvClients.Columns)
            {
                selectedClient.Columns.Add(column.Name, typeof(string));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (Form_AddClient form = new Form_AddClient())
            {
                form.ShowDialog();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (Form_EditClient form = new Form_EditClient(selectedClient))
            {
                form.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this client?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (clients.connOpen() == true)
                {
                    clients.deleteClient(ClientID);
                    dgvClients.DataSource = clients.Query($"SELECT * FROM `tbClient`").Tables[0];
                }
                clients.connClose();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clients.connect();
            if (clients.connOpen() == true)
            {
                dgvClients.DataSource = clients.Query($"SELECT * FROM `tbClient`").Tables[0];
            }
            clients.connClose();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvClients.SelectedRows.Count; i++)
                {
                    selectedClient.Rows.Add();
                    for (int j = 0; j < dgvClients.Columns.Count; j++)
                    {
                        selectedClient.Rows[i][j] = dgvClients.SelectedRows[i].Cells[j].Value;
                    }
                }

                ClientID = dgvClients.SelectedRows[0].Cells[0].Value.ToString();
            }
        }
    }
}
