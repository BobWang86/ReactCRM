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
    public partial class AdminUserForm : Form
    {
        //Database Connections.
        PassengerDbConn passengerDbConn = new PassengerDbConn();
        BookingsDbConn bookingDbConn = new BookingsDbConn();
        UserDbConn userDbConn = new UserDbConn();

        string UserID;
        List<string> passengerList;

        public AdminUserForm()
        {
            InitializeComponent();

            //Get the information of all registered users using stored procedure.
            dgvSystemUser.DataSource = userDbConn.GetUserInfo();
        }

        //Get user ID of the selected user.
        private void dgvSystemUser_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSystemUser.SelectedRows.Count > 0)
            {
                UserID = dgvSystemUser.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        //Delete the selected user.
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            //Get confirmation message before deleting an user.
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this user along with all the records?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                bookingDbConn.Connect();

                if (bookingDbConn.ConnOpen() == true)
                {
                    passengerDbConn.Connect();

                    if (passengerDbConn.ConnOpen() == true)
                    {
                        //Get all passengers that belong to the selected user.
                        DataTable passengerTable = passengerDbConn.getPassengerByUser(passengerDbConn, UserID);
                        passengerList = new List<string>();

                        //Add all passenger IDs to passengerList.
                        foreach (DataRow row in passengerTable.Rows)
                        {
                            passengerList.Add(row["CusID"].ToString());
                        }

                        //Delete each passenger's booking records.
                        foreach (string id in passengerList)
                        {
                            bookingDbConn.Connect();

                            if (bookingDbConn.ConnOpen() == true)
                            {
                                bookingDbConn.deleteBookingByPassenger(id);
                            }
                        }

                        if (passengerDbConn.ConnOpen() == true)
                        {
                            //Delete all passengers that belong to the selected user.
                            passengerDbConn.deletePassengerByUser(UserID);

                            //Since all foreign key constrints are removed.
                            //Delete the selected user.
                            userDbConn.DeleteUser(UserID);

                            //Refresh user list.
                            dgvSystemUser.DataSource = userDbConn.GetUserInfo();
                        }
                        else
                        {
                            MessageBox.Show("Operation Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Operation Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show("Operation Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Operation Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
