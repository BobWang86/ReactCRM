using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReactCRM
{
    public partial class PassengersForm : Form
    {
        //Database Connections.
        UserDbConn userDbConn = new UserDbConn();
        PassengerDbConn passengerDbConn = new PassengerDbConn();

        string UserID; 
        string PassengerID;

        public PassengersForm()
        {
            InitializeComponent();

            //Get user ID of current user.
            UserID = userDbConn.GetUserID();

            //Display all passengers that belong to current user's account.
            passengerDbConn.connect();
            if (passengerDbConn.connOpen() == true)
            {
                dgvPassenger.DataSource = passengerDbConn.Query($"SELECT * FROM `viewPassenger` WHERE `UserID`={UserID}").Tables[0];
            }
            passengerDbConn.connClose();

            BindData();
        }

        //Constrain the input of gender combobox to 'male' and 'female'.
        private void BindData()
        {
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");
        }

        //Get passenger info from the selected passenger.
        private void dgvPassenger_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPassenger.SelectedRows.Count > 0)
            {
            PassengerID = dgvPassenger.SelectedRows[0].Cells[0].Value.ToString();
            tbFName.Text = dgvPassenger.SelectedRows[0].Cells[1].Value.ToString();
            tbLName.Text = dgvPassenger.SelectedRows[0].Cells[2].Value.ToString();
            tbTelNum.Text = dgvPassenger.SelectedRows[0].Cells[3].Value.ToString();
            tbNation.Text = dgvPassenger.SelectedRows[0].Cells[4].Value.ToString();
            cbGender.Text = dgvPassenger.SelectedRows[0].Cells[5].Value.ToString();
            dtpBirthDate.Text = dgvPassenger.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        //Add new passenger and refresh passenger list.
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (passengerDbConn.connOpen() == true && ValidateForm())
            {
                passengerDbConn.insertPassenger(tbFName.Text, tbLName.Text, tbTelNum.Text, tbNation.Text, cbGender.Text, dtpBirthDate.Text, UserID);
                dgvPassenger.DataSource = passengerDbConn.Query($"SELECT * FROM `viewPassenger` WHERE `UserID`={UserID}").Tables[0];
            }
            passengerDbConn.connClose();
        }

        //Update existing passenger and refresh passenger list.
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (passengerDbConn.connOpen() == true && ValidateForm())
            {
                passengerDbConn.updatePassenger(PassengerID, tbFName.Text, tbLName.Text, tbTelNum.Text, tbNation.Text, cbGender.Text, dtpBirthDate.Text, UserID);
                dgvPassenger.DataSource = passengerDbConn.Query($"SELECT * FROM `viewPassenger` WHERE `UserID`={UserID}").Tables[0];
            }
            passengerDbConn.connClose();
        }

        //Delete selected passenger and refresh passenger list.
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            //Get confirmation message before deleting a passenger.
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this passenger?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (passengerDbConn.connOpen() == true)
                {
                    passengerDbConn.deletePassenger(PassengerID);
                    dgvPassenger.DataSource = passengerDbConn.Query($"SELECT * FROM `viewPassenger` WHERE `UserID`={UserID}").Tables[0];
                }
                passengerDbConn.connClose();
            }
        }

        //Form validation function that returns a boolean value.
        private bool ValidateForm()
        {
            if (tbFName.Text.Length == 0)
            {
                return false;
            }

            if (tbLName.Text.Length == 0)
            {
                return false;
            }

            if (tbTelNum.Text.Length == 0)
            {
                return false;
            }

            if (tbNation.Text.Length == 0)
            {
                return false;
            }

            if (cbGender.Text.Length == 0)
            {
                return false;
            }

            if (dtpBirthDate.Text.Length == 0)
            {
                return false;
            }

            return true;
        }
    }
}
