using ReactCRM.dbConn;
using ReactCRM.Forms;
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
    public partial class BookingsForm : Form
    {
        //Database Connections.
        PassengerDbConn passengerDbConn = new PassengerDbConn();
        BookingsDbConn bookingDbConn = new BookingsDbConn();
        UserDbConn userDbConn = new UserDbConn();

        //Booking Data.
        string userID;
        string bookingID;
        string passengerID;
        string passengerName;
        string passengerBirthDate;
        string flightID;
        string flightPrice;
        string adultPrice;
        string childPrice;
        string infantPrice;
        string departureCity;
        string arrivalCity;
        string flightDate;
        string flightTime;

        public BookingsForm(DataTable selectedFlight)
        {
            InitializeComponent();
            
            bookingDbConn.Connect();

            //Get user ID of current user.
            userID = userDbConn.GetUserID();

            //Display the selected flight passed in from DashBoardForm.
            dgvSelectedFlight.DataSource = selectedFlight;

            //Display all available passengers created by current user. 
            passengerDbConn.Connect();
            if (passengerDbConn.ConnOpen() == true)
            {
                dgvPassenger.DataSource = passengerDbConn.Query($"SELECT * FROM `viewPassenger` WHERE `UserID`={userID}").Tables[0];
            }
            passengerDbConn.ConnClose();
        }

        //Open a new PassengerForm.
        private void linklbAddPassenger_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PassengersForm passengersForm = new PassengersForm();

            passengersForm.Show();
        }

        //Get flight information from the selected flight.
        private void dgvSelectedFlight_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSelectedFlight.SelectedRows.Count > 0)
            {
                flightID = dgvSelectedFlight.SelectedRows[0].Cells[0].Value.ToString();
                departureCity = dgvSelectedFlight.SelectedRows[0].Cells[4].Value.ToString();
                arrivalCity = dgvSelectedFlight.SelectedRows[0].Cells[5].Value.ToString();
                flightDate = dgvSelectedFlight.SelectedRows[0].Cells[2].Value.ToString().Substring(0, 10); //Get flight date.
                flightTime = dgvSelectedFlight.SelectedRows[0].Cells[2].Value.ToString().Substring(11, 8); //Get flight time.
                adultPrice = dgvSelectedFlight.SelectedRows[0].Cells[7].Value.ToString();
                childPrice = dgvSelectedFlight.SelectedRows[0].Cells[8].Value.ToString();
                infantPrice = dgvSelectedFlight.SelectedRows[0].Cells[9].Value.ToString();
            }

            BindData();
        }

        //Get passenger information from the selected passenger.
        private void dgvPassenger_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPassenger.SelectedRows.Count > 0)
            {
                passengerID = dgvPassenger.SelectedRows[0].Cells[0].Value.ToString();
                passengerName = dgvPassenger.SelectedRows[0].Cells[1].Value.ToString() + " "
                    + dgvPassenger.SelectedRows[0].Cells[2].Value.ToString(); //Get passenger's fullname.
                passengerBirthDate = dgvPassenger.SelectedRows[0].Cells[6].Value.ToString().Substring(0, 4); //Get passenger's birth year.

                GetBookingPrice(); //Update flight booking price based passenger's age.
            }

            BindData();
        }

        //Display flight info and passenger info on the panel as labels.
        private void BindData()
        {
            lbPassengerName.Text = "Passenger Name: " + passengerName;
            lbDepartureCity.Text = "Departure City: " + departureCity;
            lbArrivalCity.Text = "Arrival City: " + arrivalCity;
            lbFlightDate.Text = "Flight Date: " + flightDate;
            lbFlightTime.Text = "Flight Time: " + flightTime;
            lbFlightPrice.Text = "Flight Price: " + flightPrice;
        }

        private void btnBookFlight_Click(object sender, EventArgs e)
        {
            if (bookingDbConn.ConnOpen() == true)
            {
                //Check if exactly the same booking already exists.
                //Prevent users from booking the same flight for the same passenger. 
                if (bookingDbConn.checkBookingExist(passengerID, flightID))
                {
                    //Create booking record.
                    bookingDbConn.insertBooking(bookingID, passengerID, flightID, flightPrice);

                    MessageBox.Show("Booking Successful!", "Booking Processed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The same passenger has already booked this flight!", "Booking Processed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            bookingDbConn.ConnClose();
        }

        //Open a new booking history page.
        private void btnViewBooking_Click(object sender, EventArgs e)
        {
            UserBookingForm userBookingForm = new UserBookingForm();

            userBookingForm.Show();
        }

        //Refresh the passenger list after passenger form is closed.
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (!CheckOpened("PassengersForm"))
            {
                if (passengerDbConn.ConnOpen() == true)
                {
                    dgvPassenger.DataSource = passengerDbConn.Query($"SELECT * FROM `viewPassenger` WHERE `UserID`={userID}").Tables[0];
                }
                passengerDbConn.ConnClose();
            }
        }

        //Function to calculate the booking price based on passenger's age.
        private void GetBookingPrice()
        {
            //Get current year.
            int currentYear = DateTime.Now.Year;
            int passengerBornYear = int.Parse(passengerBirthDate);

            //Get passenger's age.
            int passengerAge = currentYear - passengerBornYear;

            //Categorized as infant.
            if (passengerAge <= 3)
            {
                flightPrice = infantPrice;
            }

            //Categorized as child.
            if (passengerAge <= 12 && passengerAge > 3)
            {
                flightPrice = childPrice;
            }

            //Categorized as adult.
            if (passengerAge > 12)
            {
                flightPrice = adultPrice;
            }
        }

        //Check if a certain form is open.
        private bool CheckOpened(string name)
        {
            FormCollection allForms = Application.OpenForms;

            foreach (Form form in allForms)
            {
                if (form.Text == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
