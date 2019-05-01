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
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Media;
using DGVPrinterHelper;

namespace ReactCRM.UserControls
{
    public partial class UC_ManageClients : UserControl
    {
        string ClientID;

        dbClient clients = new dbClient();

        DGVPrinter printer = new DGVPrinter();

        public DataTable selectedClient = new DataTable();

        public UC_ManageClients()
        {
            InitializeComponent();

            clients.Connect();
            if (clients.ConnOpen() == true)
            {
                dgvClients.DataSource = clients.SuperQuery($"SELECT * FROM `viewClient`").Tables[0];
            }
            clients.ConnClose();

            foreach (DataGridViewColumn column in dgvClients.Columns)
            {
                selectedClient.Columns.Add(column.Name, typeof(string));
            }

            LineChart();

            PieChart();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (Form_AddClient form = new Form_AddClient())
            {
                form.ShowDialog();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (Form_EditClient form = new Form_EditClient(selectedClient))
            {
                form.ShowDialog();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clients.Connect();
            if (clients.ConnOpen() == true)
            {
                dgvClients.DataSource = clients.SuperQuery($"SELECT * FROM `viewClient`").Tables[0];
            }
            clients.ConnClose();

            LineChartReload();

            PieChart();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this client?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (clients.ConnOpen() == true)
                {
                    clients.DeleteClient(ClientID);
                    dgvClients.DataSource = clients.SuperQuery($"SELECT * FROM `viewClient`").Tables[0];
                }
                clients.ConnClose();
            }
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            using (Form_EmailProduct form = new Form_EmailProduct(selectedClient))
            {
                form.ShowDialog();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Client_Info";

            for (int i = 1; i < dgvClients.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dgvClients.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgvClients.Rows.Count; i++)
            {
                for (int j = 0; j < dgvClients.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvClients.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Client_Info";
            saveFileDialog.DefaultExt = ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            excel.Quit();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printer.Title = "DigitalHub Clients Information";
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

            printer.PrintDataGridView(dgvClients);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = tbSearch.Text;

            clients.Connect();
            if (clients.ConnOpen() == true)
            {
                dgvClients.DataSource = clients.SuperQuery($"SELECT * FROM `viewClient` Where Name LIKE '%{keyword}%' || Institute LIKE '%{keyword}%' || Source LIKE '%{keyword}%' || Pipeline LIKE '%{keyword}%'").Tables[0];
            }
            clients.ConnClose();
        }

        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvClients.SelectedRows.Count; i++)
                {
                    selectedClient.Rows.Add();
                    for (int j = 0; j < dgvClients.Columns.Count; j++)
                    {
                        selectedClient.Rows[i][j] = dgvClients.SelectedRows[i].Cells[j].Value;
                    }
                }

                ClientID = dgvClients.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void LineChart()
        {
            cartesianChart1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));

            List<int> Clients = clients.GetClientByMonth(clients);

            cartesianChart1.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "2019",
                    Values = new ChartValues<int> { Clients[0], Clients[1], Clients[2], Clients[3], Clients[4], Clients[5] }
                }
            };

            cartesianChart1.AxisX.Add(new Axis
            {
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "June" },
                Separator = new Separator
                {
                    Step = 1,
                    IsEnabled = false 
                },
                LabelsRotation = 15
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Clients",
                LabelFormatter = value => value.ToString("N")
            });
        }

        private void LineChartReload()
        {
            List<int> Clients = clients.GetClientByMonth(clients);

            cartesianChart1.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "2019",
                    Values = new ChartValues<int> { Clients[0], Clients[1], Clients[2], Clients[3], Clients[4], Clients[5] }
                }
            };
        }

        private void PieChart()
        {
            pieChart1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));

            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            List<int> Clients = clients.GetClientBySource(clients);

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Call",
                    Values = new ChartValues<double> {Clients[0]},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Email",
                    Values = new ChartValues<double> {Clients[1]},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Referal",
                    Values = new ChartValues<double> {Clients[2]},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Partner",
                    Values = new ChartValues<double> {Clients[3]},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Campaign",
                    Values = new ChartValues<double> {Clients[4]},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "WebForm",
                    Values = new ChartValues<double> {Clients[5]},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "SocialMedia",
                    Values = new ChartValues<double> {Clients[6]},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
            };

            pieChart1.LegendLocation = LegendLocation.Right;
        }
    }
}
