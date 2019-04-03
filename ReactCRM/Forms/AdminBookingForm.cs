using DGVPrinterHelper;
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
    public partial class AdminBookingForm : Form
    {
        //Database Connections.
        BookingsDbConn bookingDbConn = new BookingsDbConn();

        string bookingID;

        public AdminBookingForm()
        {
            InitializeComponent();

            bookingDbConn.connect();

            //Display all booking records that belong to the any user.
            if (bookingDbConn.connOpen() == true)
            {
                dgvBookingHistory.DataSource = bookingDbConn.DisplayAllBookingHistory(bookingDbConn);
            }
            bookingDbConn.connClose();
        }

        //Get booking ID of the selected booking record.
        private void dgvBookingHistory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBookingHistory.SelectedRows.Count > 0)
            {
                bookingID = dgvBookingHistory.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        //Delete selected booking record and refresh the list.
        private void btnDeleteEntry_Click(object sender, EventArgs e)
        {
            //Get confirmation message before deleting a booking record.
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (bookingDbConn.connOpen() == true)
                {
                    bookingDbConn.deleteBooking(bookingID);
                    dgvBookingHistory.DataSource = bookingDbConn.DisplayAllBookingHistory(bookingDbConn);
                }
                bookingDbConn.connClose();
            }
        }

        //Print all booking records.
        private void btnPrintRecord_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Booking History";
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

            printer.PrintDataGridView(dgvBookingHistory);
        }

        //Export all booking records as an excel file.
        private void btnExportRecord_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Booking_History";

            for (int i = 1; i < dgvBookingHistory.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dgvBookingHistory.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgvBookingHistory.Rows.Count; i++)
            {
                for (int j = 0; j < dgvBookingHistory.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvBookingHistory.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "BookingHistory";
            saveFileDialog.DefaultExt = ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            excel.Quit();
        }
    }
}
