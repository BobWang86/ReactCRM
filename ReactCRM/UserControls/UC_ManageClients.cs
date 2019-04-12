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

        private void btnEmail_Click(object sender, EventArgs e)
        {

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
