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
    public partial class MainForm : Form
    {
        dbConn dbConn = new dbConn();

        public MainForm()
        {
            InitializeComponent();

            dbConn = new dbConn();
            dbConn.connect();
            if (dbConn.connOpen() == true)
            {
                MessageBox.Show("Successfully Connected to Cpanel!");
            }
            dbConn.connClose();
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            Close(); // close the current form
            PassengersForm custForm = new PassengersForm();
            custForm.Show();
        }

        private void btnManageFlights_Click(object sender, EventArgs e)
        {
            Close(); // close the current form
            FlightsForm flightsForm = new FlightsForm();
            flightsForm.Show();
        }

        private void btnManageBookings_Click(object sender, EventArgs e)
        {
            Close(); // close the current form
            AdminBookingForm bookingsForm = new AdminBookingForm();
            bookingsForm.Show();
        }
    }
}
