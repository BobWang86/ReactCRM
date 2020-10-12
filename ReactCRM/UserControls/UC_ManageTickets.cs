using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using ReactCRM.Forms;
using ReactCRM.dbConn;
using DGVPrinterHelper;

namespace ReactCRM.UserControls
{
    public partial class UC_ManageTickets : UserControl
    {
        string TicketID;

        dbTicket tickets = new dbTicket();

        DGVPrinter printer = new DGVPrinter();

        DataTable selectedTicket = new DataTable();

        public UC_ManageTickets()
        {
            InitializeComponent();

            tickets.Connect();
            if (tickets.ConnOpen() == true)
            {
                dgvTickets.DataSource = tickets.SuperQuery($"SELECT * FROM `viewTicket`").Tables[0];
            }
            tickets.ConnClose();

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tickets.Connect();
            if (tickets.ConnOpen() == true)
            {
                dgvTickets.DataSource = tickets.SuperQuery($"SELECT * FROM `viewTicket`").Tables[0];
            }
            tickets.ConnClose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this ticket?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (tickets.ConnOpen() == true)
                {
                    tickets.DeleteTicket(TicketID);
                    dgvTickets.DataSource = tickets.SuperQuery($"SELECT * FROM `viewTicket`").Tables[0];
                }
                tickets.ConnClose();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Ticket_Info";

            for (int i = 1; i < dgvTickets.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dgvTickets.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgvTickets.Rows.Count; i++)
            {
                for (int j = 0; j < dgvTickets.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvTickets.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Ticket_Info";
            saveFileDialog.DefaultExt = ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            excel.Quit();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printer.Title = "DigitalHub Tickets Information";
            printer.SubTitle = string.Format($"Date: {DateTime.Now.Date.ToString("yyyy/MM/dd")}");
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.Footer = "DigitalHub";
            printer.FooterSpacing = 15;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.ColumnWidth = DGVPrinter.ColumnWidthSetting.DataWidth;

            printer.PrintDataGridView(dgvTickets);
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            using (Form_EmailTicket form = new Form_EmailTicket(selectedTicket))
            {
                form.ShowDialog();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = tbSearch.Text;

            tickets.Connect();
            if (tickets.ConnOpen() == true)
            {
                dgvTickets.DataSource = tickets.SuperQuery($"SELECT * FROM `viewTicket` Where Name LIKE ''%{keyword}% || Detail LIKE '%{keyword}%' || Type LIKE '%{keyword}%'").Tables[0];
            }
            tickets.ConnClose();
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
