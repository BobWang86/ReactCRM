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

namespace ReactCRM.UserControls
{
    public partial class UC_ManageClients : UserControl
    {
        string ClientID;

        dbClient clients = new dbClient();

        public DataTable selectedClient = new DataTable();

        public UC_ManageClients()
        {
            InitializeComponent();

            clients.connect();
            if (clients.connOpen() == true)
            {
                dgvClients.DataSource = clients.Query($"SELECT * FROM `tbClient`").Tables[0];
            }
            clients.connClose();

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this client?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (clients.connOpen() == true)
                {
                    clients.deleteClient(ClientID);
                    dgvClients.DataSource = clients.Query($"SELECT * FROM `tbClient`").Tables[0];
                }
                clients.connClose();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clients.connect();
            if (clients.connOpen() == true)
            {
                dgvClients.DataSource = clients.Query($"SELECT * FROM `tbClient`").Tables[0];
            }
            clients.connClose();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

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
            cartesianChart1.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "2015",
                    Values = new ChartValues<double> { 10, 50, 39, 50 }
                }
            };

            //adding series will update and animate the chart automatically
            cartesianChart1.Series.Add(new ColumnSeries
            {
                Title = "2016",
                Values = new ChartValues<double> { 11, 56, 42 }
            });

            //adding values updates and animates the chart automatically
            cartesianChart1.Series[1].Values.Add(48d);

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Sales Man",
                Labels = new[] { "Maria", "Susan", "Charles", "Frida" }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Sold Apps",
                LabelFormatter = value => value.ToString("N")
            });
        }

        private void PieChart()
        {
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

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
