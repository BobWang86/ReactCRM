using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReactCRM.dbConn;
using ReactCRM.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Media;

namespace ReactCRM.UserControls
{
    public partial class UC_ManageSales : UserControl
    {
        string SaleID;

        dbSale sales = new dbSale();

        public DataTable selectedSale = new DataTable();

        public UC_ManageSales()
        {
            InitializeComponent();

            sales.connect();
            if (sales.connOpen() == true)
            {
                dgvSales.DataSource = sales.Query($"SELECT * FROM `tbSale`").Tables[0];
            }
            sales.connClose();

            foreach (DataGridViewColumn column in dgvSales.Columns)
            {
                selectedSale.Columns.Add(column.Name, typeof(string));
            }

            LineChart();

            PieChart();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (Form_AddSale form = new Form_AddSale())
            {
                form.ShowDialog();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (Form_EditSale form = new Form_EditSale(selectedSale))
            {
                form.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (sales.connOpen() == true)
                {
                    sales.deleteSale(SaleID);
                    dgvSales.DataSource = sales.Query($"SELECT * FROM `tbClient`").Tables[0];
                }
                sales.connClose();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            sales.connect();
            if (sales.connOpen() == true)
            {
                dgvSales.DataSource = sales.Query($"SELECT * FROM `tbSale`").Tables[0];
            }
            sales.connClose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dgvSales_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSales.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvSales.SelectedRows.Count; i++)
                {
                    selectedSale.Rows.Add();
                    for (int j = 0; j < dgvSales.Columns.Count; j++)
                    {
                        selectedSale.Rows[i][j] = dgvSales.SelectedRows[i].Cells[j].Value;
                    }
                }

                SaleID = dgvSales.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void LineChart()
        {
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Series 1",
                    Values = new ChartValues<double> {4, 6, 5, 2, 7}
                },
                new LineSeries
                {
                    Title = "Series 2",
                    Values = new ChartValues<double> {6, 7, 3, 4, 6},
                    PointGeometry = null
                },
                new LineSeries
                {
                    Title = "Series 2",
                    Values = new ChartValues<double> {5, 2, 8, 3},
                    PointGeometry = DefaultGeometries.Square,
                    PointGeometrySize = 15
                }
            };

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Sales",
                LabelFormatter = value => value.ToString("C")
            });

            cartesianChart1.LegendLocation = LegendLocation.Right;

            //modifying the series collection will animate and update the chart
            cartesianChart1.Series.Add(new LineSeries
            {
                Values = new ChartValues<double> { 5, 3, 2, 4, 5 },
                LineSmoothness = 0, //straight lines, 1 really smooth lines
                PointGeometry = Geometry.Parse("m 25 70.36218 20 -28 -20 22 -8 -6 z"),
                PointGeometrySize = 50,
                PointForeground = Brushes.Gray
            });

            //modifying any series values will also animate and update the chart
            cartesianChart1.Series[2].Values.Add(5d);
        }

        private void PieChart()
        {
            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Maria",
                    Values = new ChartValues<double> {3},
                    PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Charles",
                    Values = new ChartValues<double> {4},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Frida",
                    Values = new ChartValues<double> {6},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Frederic",
                    Values = new ChartValues<double> {2},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };

            pieChart1.LegendLocation = LegendLocation.Bottom;
        }
    }
}
