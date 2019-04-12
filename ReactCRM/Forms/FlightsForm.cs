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

namespace ReactCRM
{
    public partial class FlightsForm : Form
    {
        FlightsDbConn flightDbConn;

        //Flight Information.
        string AircraftID; //Represents Aircraft Models.
        string AirportID; //Represents Flight Cities.
        string flightEntry; //A string that contains complete flight information to be inserted into database. 
        int randomMinutes1; //A random number to get flight departure time.
        int randomMinutes2; //A random number to get flight arrival time.
        List<string> flightCities = new List<string>(); //A list containing all available flight cities.
        List<string> flightModels = new List<string>(); //A list containing all available aircraft model.
        List<string> flightInfo = new List<string>(); //A list containing randomly generated flight entries.
        TimeSpan flightTimeSpan;
        string flightDuration;
        string dateGenerator;

        public FlightsForm()
        {
            InitializeComponent();

            //Disable text input of the following comboboxes.
            cbAirCraft.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepartureCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbArrivalCity.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FlightsForm_Load(object sender, EventArgs e)
        {
            flightDbConn = new FlightsDbConn();

            flightDbConn.Connect();

            //Display all flight information stored in the database.
            if (flightDbConn.ConnOpen() == true)
            {
                dgvFlight.DataSource = flightDbConn.Query("SELECT * FROM `viewFlight`").Tables[0];

                //Refresh the content of flightCities and flightModels Lists.
                RefreshList();
            }
            flightDbConn.ConnClose();
        }

        private void RefreshList()
        {
            //Get all available aircraft models from database.
            DataTable modelTable = flightDbConn.GetAircraftModel(flightDbConn);
            //Get all available flight cities from database.
            DataTable cityTable = flightDbConn.GetAirportName(flightDbConn);

            //Refresh the content of flightModels list.
            flightModels.Clear();
            foreach (DataRow row in modelTable.Rows)
            {
                flightModels.Add(row["AircraftModel"].ToString());
            }

            //Refresh the content of flightCities list.
            flightCities.Clear();
            foreach (DataRow row in cityTable.Rows)
            {
                flightCities.Add(row["AirportName"].ToString());
            }

            //Fill data into Aircraft Models combobox.
            cbAirCraft.DataSource = modelTable;
            cbAirCraft.DisplayMember = "label";
            cbAirCraft.ValueMember = "AircraftModel";

            //Fill data into Flight Cities combobox.
            foreach (string item in flightCities)
            {
                cbDepartureCity.Items.Add(item);
                cbArrivalCity.Items.Add(item);
            }
        }

        //Add flight and refresh flight list.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (flightDbConn.ConnOpen() == true && ValidateForm())
            {
                flightDbConn.insertFlight(cbAirCraft.Text, dtpDeparDateTime.Text, dtpArrDateTime.Text, cbDepartureCity.Text, cbArrivalCity.Text, GetFlightDuration(), tbAdultPrice.Text, tbChildPrice.Text, tbInfantPrice.Text);
                dgvFlight.DataSource = flightDbConn.Query("SELECT * FROM `viewFlight`").Tables[0];
            }
            flightDbConn.ConnClose();
        }

        //Update flight and refresh flight list.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (flightDbConn.ConnOpen() == true && ValidateForm())
            {
                flightDbConn.updateFlight(tbFlightID.Text, cbAirCraft.Text, dtpDeparDateTime.Text, dtpArrDateTime.Text, cbDepartureCity.Text, cbArrivalCity.Text, GetFlightDuration(), tbAdultPrice.Text, tbChildPrice.Text, tbInfantPrice.Text);
                dgvFlight.DataSource = flightDbConn.Query("SELECT * FROM `viewFlight`").Tables[0];
            }
            flightDbConn.ConnClose();
        }

        //Delete selected flight and refresh flight list.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (flightDbConn.ConnOpen() == true)
            {
                flightDbConn.deleteFlight(tbFlightID.Text);
                dgvFlight.DataSource = flightDbConn.Query("SELECT * FROM `viewFlight`").Tables[0];
            }
            flightDbConn.ConnClose();
        }

        //Get flight information from the selected flight and pass them into corresponding fields.
        private void dgvFlight_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFlight.SelectedRows.Count > 0)
            {
                tbFlightID.Text = dgvFlight.SelectedRows[0].Cells[0].Value.ToString();
                cbAirCraft.Text = dgvFlight.SelectedRows[0].Cells[1].Value.ToString();
                dtpDeparDateTime.Text = dgvFlight.SelectedRows[0].Cells[2].Value.ToString();
                dtpArrDateTime.Text = dgvFlight.SelectedRows[0].Cells[3].Value.ToString();
                cbDepartureCity.Text = dgvFlight.SelectedRows[0].Cells[4].Value.ToString();
                cbArrivalCity.Text = dgvFlight.SelectedRows[0].Cells[5].Value.ToString();
                tbAdultPrice.Text = dgvFlight.SelectedRows[0].Cells[7].Value.ToString();
                tbChildPrice.Text = dgvFlight.SelectedRows[0].Cells[8].Value.ToString();
                tbInfantPrice.Text = dgvFlight.SelectedRows[0].Cells[9].Value.ToString();
            }
        }

        //Validate user input.
        private bool ValidateForm()
        {
            if (tbAdultPrice.Text.Length == 0)
            {
                return false;
            }

            if (tbAdultPrice.Text == ".")
            {
                return false;
            }
            return true;
        }

        //Prevent user from entering letters or symbols into Price Textbox.
        private void tbAdultPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //Automatically generate child price and infant price based on adult price.
        private void tbAdultPrice_TextChanged(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                double adultPrice = double.Parse(tbAdultPrice.Text);
                tbChildPrice.Text = (adultPrice * 0.4).ToString();
                tbInfantPrice.Text = (adultPrice * 0.2).ToString();
            }
            else
            {
                tbChildPrice.Text = "";
                tbInfantPrice.Text = "";
            }
        }

        //Automatically calculate flight duration based on departuretime and arrival time.
        private string GetFlightDuration()
        {
            TimeSpan flightDuration;
            DateTime deparTime = dtpDeparDateTime.Value;
            DateTime arrTime = dtpArrDateTime.Value;
            flightDuration = arrTime.Subtract(deparTime);

            return flightDuration.ToString();
        }

        //Add a new aircraft model to the database and refresh model list. 
        private void btnAddNewModel_Click(object sender, EventArgs e)
        {
            string AircraftModel = tbNewModel.Text;

            if (flightDbConn.ConnOpen() == true && AircraftModel.Length != 0)
            {
                flightDbConn.addNewModel(AircraftID, AircraftModel);
                tbNewModel.Text = "";
                RefreshList();
            }
            flightDbConn.ConnClose();
        }

        //Add a new flight city to the database and refresh city list. 
        private void btnAddNewCity_Click(object sender, EventArgs e)
        {
            string AirportName = tbNewCity.Text;

            if (flightDbConn.ConnOpen() == true && tbNewCity.Text.Length != 0)
            {
                flightDbConn.addNewCity(AirportID, AirportName);
                tbNewCity.Text = "";
                RefreshList();
            }
            flightDbConn.ConnClose();
        }

        //Randomly generate a certain number of flights for a specified date.
        private void btnGenerateFlight_Click(object sender, EventArgs e)
        {
            //Rollers for random data.
            Random cityRoller = new Random();
            Random modelRoller = new Random();
            Random timeRoller = new Random();
            dateGenerator = dtpFlightGenerater.Value.ToString("yyyy-MM-dd");

            //Clear the container for all flight entries.
            flightInfo.Clear(); 
            //Create 10 random flight entries. 
            for (int i = 0; i < 16; i++)
            {
                int x = cityRoller.Next(0, flightCities.Count); //Get a random departure city.
                int y = cityRoller.Next(0, flightCities.Count); //Get a random arrival city.
                int z = modelRoller.Next(0, flightModels.Count); //Get a random aircraft model.


                TimeSpan rangeStart = TimeSpan.FromHours(0);
                TimeSpan rangeEnd = TimeSpan.FromHours(12);
                TimeSpan span = rangeEnd - rangeStart; //Set a range for departure time and arrival time.
                randomMinutes1 = timeRoller.Next(0, (int)span.TotalMinutes); //Get a random period of time ranging from 0 to 12 hours.
                randomMinutes2 = timeRoller.Next(45, (int)span.TotalMinutes); //Get a random period of time ranging from 45 minutes to 12 hours.

                TimeSpan time1 = rangeStart + TimeSpan.FromMinutes(randomMinutes1); //Get a random flight departure time.
                TimeSpan time2 = rangeStart + TimeSpan.FromMinutes(randomMinutes1 + randomMinutes2); //Get a random flight arrival time.

                string departureTime = dateGenerator.ToString() + " " + time1.ToString(); //Combine the random departure time with specified date.
                string arrivalTime = dateGenerator.ToString() + " " + time2.ToString(); //Combine the random arrival time with specified date.

                flightTimeSpan = TimeSpan.FromMinutes(randomMinutes2);
                flightDuration = flightTimeSpan.ToString(@"hh\:mm"); //Get flight duration by converting minutes to hours.

                string adultPrice = randomMinutes2.ToString(); //Get flight price based on flight duration.
                string childPrice = (Math.Floor(randomMinutes2 * 0.4)).ToString();
                string infantPrice = (Math.Floor(randomMinutes2 * 0.2)).ToString();

                //Complete flight entry to be inserted into database.
                flightEntry = $"(NULL, '{flightModels[z]}', '{departureTime}', '{arrivalTime}', '{flightCities[x]}', '{flightCities[y]}', '{flightDuration}', '{adultPrice}', '{childPrice}', '{infantPrice}');";

                //Eliminate the possibilities of getting the same city as departure city and arrival city.
                //Add flightEntry to the list.
                if (x != y)
                {
                    flightInfo.Add(flightEntry);
                }
            }

            //Add randomly generated flights into database and refresh the flight table. 
            foreach (string entry in flightInfo)
            {
                if (flightDbConn.ConnOpen() == true)
                {
                    flightDbConn.generateFlight(entry);
                }
                flightDbConn.ConnClose();
            }

            if (flightDbConn.ConnOpen() == true)
            {
                dgvFlight.DataSource = flightDbConn.Query("SELECT * FROM `viewFlight`").Tables[0];

                MessageBox.Show($"Flights added to {dateGenerator}!", "Flights Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            flightDbConn.ConnClose();
        }
    }
}
