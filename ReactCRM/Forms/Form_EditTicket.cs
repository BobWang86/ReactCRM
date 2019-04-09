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
    public partial class Form_EditTicket : Form
    {
        string TicketID;

        string ReportDate;

        dbTicket tickets = new dbTicket();

        public Form_EditTicket(DataTable selectedTicket)
        {
            InitializeComponent();

            TicketID = selectedTicket.Rows[0][0].ToString();
            tbClient.Text = selectedTicket.Rows[0][1].ToString();
            tbDetail.Text = selectedTicket.Rows[0][2].ToString();
            tbType.Text = selectedTicket.Rows[0][3].ToString();
            tbStatus.Text = selectedTicket.Rows[0][4].ToString();
            ReportDate = selectedTicket.Rows[0][5].ToString();
            tbDate.Text = selectedTicket.Rows[0][6].ToString();

            tbType.DropDownStyle = ComboBoxStyle.DropDownList;
            tbType.Items.AddRange(new string[] { "Order Status", "Bug Report", "Feature Request", "Technical Support" });
            tbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            tbStatus.Items.AddRange(new string[] { "Pending", "Responding", "Unsolved", "Solved" });
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tickets.connect();
            if (tickets.connOpen() == true && FormValidate())
            {
                tickets.updateTicket(TicketID, tbClient.Text, tbDetail.Text, tbType.Text, tbStatus.Text, ReportDate, tbDate.Value.ToString("yyyy-MM-dd"));

                MessageBox.Show("Ticket Info Updated!", "Edit Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill in all the fields!", "Edit Ticket", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tickets.connClose();
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
            return true;
        }

    }
}
