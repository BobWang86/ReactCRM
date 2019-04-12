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

            sales.Connect();
            if (sales.ConnOpen() == true)
            {
                dgvSales.DataSource = sales.Query($"SELECT * FROM `tbSale`").Tables[0];
            }
            sales.ConnClose();

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
                if (sales.ConnOpen() == true)
                {
                    sales.DeleteSale(SaleID);
                    dgvSales.DataSource = sales.Query($"SELECT * FROM `tbClient`").Tables[0];
                }
                sales.ConnClose();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            sales.Connect();
            if (sales.ConnOpen() == true)
            {
                dgvSales.DataSource = sales.Query($"SELECT * FROM `tbSale`").Tables[0];
            }
            sales.ConnClose();

            LineChartReload();

            PieChart();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = tbSearch.Text;

            sales.Connect();
            if (sales.ConnOpen() == true)
            {
                dgvSales.DataSource = sales.SuperQuery($"SELECT * FROM `tbSale` Where Product LIKE '%{keyword}%'").Tables[0];
            }
            sales.ConnClose();
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
            cartesianChart1.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));

            List<double> productA = sales.GetSales(sales, "Interactive Timetabling");
            List<double> productB = sales.GetSales(sales, "Automated Timetabling");
            List<double> productC = sales.GetSales(sales, "Attendance Monitoring");
            List<double> productD = sales.GetSales(sales, "Room Booking");
            List<double> productE = sales.GetSales(sales, "Pay Claim");
            List<double> Products = new List<double>();
            for (int i = 0; i < 6; i++)
            {
                Products.Add(productA[i] + productB[i] + productC[i] + productD[i] + productE[i]);
            }

            List<double> serviceA = sales.GetSales(sales, "Integration");
            List<double> serviceB = sales.GetSales(sales, "Consultancy");
            List<double> serviceC = sales.GetSales(sales, "Training");
            List<double> Services = new List<double>();
            for (int i = 0; i < 6; i++)
            {
                Services.Add(serviceA[i] + serviceB[i] + serviceC[i]);
            }

            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Products",
                    Values = new ChartValues<double> {Products[0], Products[1], Products[2], Products[3], Products[4], Products[5] }
                },
                new LineSeries
                {
                    Title = "Services",
                    Values = new ChartValues<double> {Services[0], Services[1], Services[2], Services[3], Services[4], Services[5]},
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
                Title = "Sales",
                LabelFormatter = value => value.ToString("C")
            });

            cartesianChart1.LegendLocation = LegendLocation.Right;
        }

        private void LineChartReload()
        {
            List<double> productA = sales.GetSales(sales, "Interactive Timetabling");
            List<double> productB = sales.GetSales(sales, "Automated Timetabling");
            List<double> productC = sales.GetSales(sales, "Attendance Monitoring");
            List<double> productD = sales.GetSales(sales, "Room Booking");
            List<double> productE = sales.GetSales(sales, "Pay Claim");
            List<double> Products = new List<double>();
            for (int i = 0; i < 6; i++)
            {
                Products.Add(productA[i] + productB[i] + productC[i] + productD[i] + productE[i]);
            }

            List<double> serviceA = sales.GetSales(sales, "Integration");
            List<double> serviceB = sales.GetSales(sales, "Consultancy");
            List<double> serviceC = sales.GetSales(sales, "Training");
            List<double> Services = new List<double>();
            for (int i = 0; i < 6; i++)
            {
                Services.Add(serviceA[i] + serviceB[i] + serviceC[i]);
            }

            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Product",
                    Values = new ChartValues<double> {Products[0], Products[1], Products[2], Products[3], Products[4], Products[5] }
                },
                new LineSeries
                {
                    Title = "Service",
                    Values = new ChartValues<double> {Services[0], Services[1], Services[2], Services[3], Services[4], Services[5]},
                }
            };
        }

        private void PieChart()
        {
            pieChart1.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));

            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            List<double> Sales = sales.GetSalesByType(sales);

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Interactive Timetabling",
                    Values = new ChartValues<double> { Sales[0]},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Automated Timetabling",
                    Values = new ChartValues<double> { Sales[1]},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Attendance Monitoring",
                    Values = new ChartValues<double> { Sales[2]},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Room Booking",
                    Values = new ChartValues<double> { Sales[3]},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Pay Claim",
                    Values = new ChartValues<double> { Sales[4]},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Integration",
                    Values = new ChartValues<double> { Sales[5]},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Consultancy",
                    Values = new ChartValues<double> { Sales[6]},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Training",
                    Values = new ChartValues<double> { Sales[7]},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };

            pieChart1.LegendLocation = LegendLocation.Right;
        }
    }
}
