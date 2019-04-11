using ReactCRM.dbConn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace ReactCRM.Forms
{
    public partial class DashBoardForm : Form
    {
        //Database Connections.
        UserDbConn userDbConn = new UserDbConn();
        FlightsDbConn flightDbConn = new FlightsDbConn();

        //Datagridview Printer.
        DGVPrinter printer = new DGVPrinter();
        //DataTable to be passed into a new BookingForm.
        public DataTable selectedFlight = new DataTable();

        string currentDate;

        public DashBoardForm()
        {
            InitializeComponent();

            //Get current date.
            currentDate = DateTime.Now.Date.ToString("yyyy/MM/dd");

            flightDbConn.connect();

            //Display today's flights by default.
            if (flightDbConn.connOpen() == true)
            {
                dgvFlight.DataSource = flightDbConn.searchFlightByDate(flightDbConn, currentDate);
            }
            flightDbConn.connClose();

            // Resize the DataGridView columns to fit the newly loaded data.
            dgvFlight.AutoResizeColumns();

            // Make sure that the columns automatically adjust widths when the data changes.
            dgvFlight.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Initialize the format of the selectedFlight DataTable.
            foreach (DataGridViewColumn column in dgvFlight.Columns)
            {
                selectedFlight.Columns.Add(column.Name, typeof(string));
            }
        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {
            //Display current user's Email.
            lbUserEmail.Text = "Current User: " + userDbConn.GetUserEmail();

            //Make admin menu only accessible for system administer.
            if (userDbConn.GetUserEmail() == "admin@gmail.com")
            {
                toolStripMenuAdmin.Enabled = true;
            }
        }


        //Search flight by entering city name.
        private void btnSearchByCity_Click(object sender, EventArgs e)
        {
            if (flightDbConn.connOpen() == true && tbSearchValue.Text.Length != 0)
            {
                dgvFlight.DataSource = flightDbConn.searchFlight(flightDbConn, tbSearchValue.Text, dtpSearchValue.Text);
            }
            flightDbConn.connClose();
        }

        //Search flight by specifying flight date.
        private void dtpSearchValue_ValueChanged(object sender, EventArgs e)
        {
            if (flightDbConn.connOpen() == true)
            {
                dgvFlight.DataSource = flightDbConn.searchFlightByDate(flightDbConn, dtpSearchValue.Text);
            }
            flightDbConn.connClose();
        }

        //Update selectedFlight DataTable whenever a new flight gets selected.
        private void dgvFlight_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvFlight.SelectedRows.Count; i++)
            {
                selectedFlight.Rows.Add();
                for (int j = 0; j < dgvFlight.Columns.Count; j++)
                {                   
                    selectedFlight.Rows[i][j] = dgvFlight.SelectedRows[i].Cells[j].Value;
                }
            }
        }

        //Display all flight information stored in the database.
        private void linklbDisplayAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (flightDbConn.connOpen() == true)
            {
                dgvFlight.DataSource = flightDbConn.query("SELECT * FROM `viewFlight`").Tables[0];
            }
            flightDbConn.connClose();
        }

        //Open a new booking form and pass selectedFlight DataTable into it.
        private void btnBookFlight_Click(object sender, EventArgs e)
        {
            new BookingsForm(selectedFlight).Show();
        }

        //Open a new FlightsForm as an Admin.
        private void tsmiManageFlights_Click(object sender, EventArgs e)
        {
            new FlightsForm().Show();
        }

        //Open a new UsersForm as an Admin.
        private void tsmiManageUsers_Click(object sender, EventArgs e)
        {
            new AdminUserForm().Show();
        }

        //Open a new BookingForm as an Admin
        private void tsmiManageBookings_Click(object sender, EventArgs e)
        {
            new AdminBookingForm().Show();
        }

        //Open a new PassengersForm as a User.
        private void tsmiViewPassenger_Click(object sender, EventArgs e)
        {
            new PassengersForm().Show();
        }

        //Open a new BookingForm as a User.
        private void tsmiViewBooking_Click(object sender, EventArgs e)
        {
            new UserBookingForm().Show();
        }

        //Update user login status and restart the program.
        private void tsmiSignOut_Click(object sender, EventArgs e)
        {
            userDbConn.SignOutStatus();

            Close();

            Application.Restart();
        }

        //Export flight information as an excel file.
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "FlightInfo";

            //Get column titles.
            for (int i = 1; i < dgvFlight.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dgvFlight.Columns[i - 1].HeaderText;
            }

            //Get cell content.
            for (int i = 0; i < dgvFlight.Rows.Count; i++)
            {
                for (int j = 0; j < dgvFlight.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvFlight.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "FlightInfo";
            saveFileDialog.DefaultExt = ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            excel.Quit();
        }

        //Display print page.
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initializeDataPrinter();

            printer.PrintDataGridView(dgvFlight);
        }

        //Display print preview page.
        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initializeDataPrinter();

            printer.PrintPreviewNoDisplay(dgvFlight);
        }

        //Set up flight info printer.
        private void initializeDataPrinter()
        {
            printer.Title = "Flight Search Results";
            printer.SubTitle = string.Format($"Date: {DateTime.Now.Date.ToString("yyyy/MM/dd")}");
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.Footer = "Azman Airline";
            printer.FooterSpacing = 15;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.ColumnWidth = DGVPrinter.ColumnWidthSetting.DataWidth;
        }

        //Update user login status and exit. 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userDbConn.SignOutStatus();

            Application.Exit();
        }

        //Update user login status and exit. 
        //Make sure that current user gets logged out whenever application exits.
        private void DashBoardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            userDbConn.SignOutStatus();

            Application.Exit();
        }
    }
}
