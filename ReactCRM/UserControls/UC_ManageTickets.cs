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
    public partial class UC_ManageTickets : UserControl
    {
        string TicketID;

        dbTicket tickets = new dbTicket();

        DataTable selectedTicket = new DataTable();

        public UC_ManageTickets()
        {
            InitializeComponent();

            tickets.connect();
            if (tickets.connOpen() == true)
            {
                dgvTickets.DataSource = tickets.query($"SELECT * FROM `tbTicket`").Tables[0];
            }
            tickets.connClose();

            foreach (DataGridViewColumn column in dgvTickets.Columns)
            {
                selectedTicket.Columns.Add(column.Name, typeof(string));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (Form_AddTicket form = new Form_AddTicket())
            {
                form.ShowDialog();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (Form_EditTicket form = new Form_EditTicket(selectedTicket))
            {
                form.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this ticket?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (tickets.connOpen() == true)
                {
                    tickets.deleteTicket(TicketID);
                    dgvTickets.DataSource = tickets.query($"SELECT * FROM `tbTicket`").Tables[0];
                }
                tickets.connClose();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tickets.connect();
            if (tickets.connOpen() == true)
            {
                dgvTickets.DataSource = tickets.query($"SELECT * FROM `tbTicket`").Tables[0];
            }
            tickets.connClose();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dgvTickets_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTickets.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvTickets.SelectedRows.Count; i++)
                {
                    selectedTicket.Rows.Add();
                    for (int j = 0; j < dgvTickets.Columns.Count; j++)
                    {
                        selectedTicket.Rows[i][j] = dgvTickets.SelectedRows[i].Cells[j].Value;
                    }
                }

                TicketID = dgvTickets.SelectedRows[0].Cells[0].Value.ToString();
            }
        }
    }
}
