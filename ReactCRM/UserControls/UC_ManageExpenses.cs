using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ReactCRM.Forms;
using ReactCRM.dbConn;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Media;

namespace ReactCRM.UserControls
{
    public partial class UC_ManageExpenses : UserControl
    {
        string ExpenseID;

        dbExpense expenses = new dbExpense();

        DataTable selectedExpense = new DataTable();

        public UC_ManageExpenses()
        {
            InitializeComponent();

            expenses.Connect();
            if (expenses.ConnOpen() == true)
            {
                dgvExpenses.DataSource = expenses.Query($"SELECT * FROM `tbExpense`").Tables[0];
            }
            expenses.ConnClose();

            foreach (DataGridViewColumn column in dgvExpenses.Columns)
            {
                selectedExpense.Columns.Add(column.Name, typeof(string));
            }

            LineChart();

            DonutChart();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (Form_AddExpense form = new Form_AddExpense())
            {
                form.ShowDialog();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (Form_EditExpense form = new Form_EditExpense(selectedExpense))
            {
                form.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (expenses.ConnOpen() == true)
                {
                    expenses.DeleteExpense(ExpenseID);
                    dgvExpenses.DataSource = expenses.Query($"SELECT * FROM `tbExpense`").Tables[0];
                }
                expenses.ConnClose();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            expenses.Connect();
            if (expenses.ConnOpen() == true)
            {
                dgvExpenses.DataSource = expenses.Query($"SELECT * FROM `tbExpense`").Tables[0];
            }
            expenses.ConnClose();

            LineChartReload();

            DonutChart();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dgvExpenses_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvExpenses.SelectedRows.Count; i++)
                {
                    selectedExpense.Rows.Add();
                    for (int j = 0; j < dgvExpenses.Columns.Count; j++)
                    {
                        selectedExpense.Rows[i][j] = dgvExpenses.SelectedRows[i].Cells[j].Value;
                    }
                }

                ExpenseID = dgvExpenses.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void LineChart()
        {
            cartesianChart1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));

            List<double> Expenses = expenses.GetExpensesByDate(expenses);

            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Expenses",
                    Values = new ChartValues<double> {Expenses[0], Expenses[1], Expenses[2], Expenses[3], Expenses[4], Expenses[5] }
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
                Title = "Expenses",
                LabelFormatter = value => value.ToString("C")
            });
        }

        private void LineChartReload()
        {
            List<double> Expenses = expenses.GetExpensesByDate(expenses);

            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Expenses",
                    Values = new ChartValues<double> {Expenses[0], Expenses[1], Expenses[2], Expenses[3], Expenses[4], Expenses[5] }
                }
            };
        }

        private void DonutChart()
        {
            pieChart1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));

            pieChart1.InnerRadius = 100;
            pieChart1.LegendLocation = LegendLocation.Right;

            List<double> Expenses = expenses.GetExpensesByType(expenses);

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Employee salaries",
                    Values = new ChartValues<double> {Expenses[0]},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Office Expenses",
                    Values = new ChartValues<double> {Expenses[1]},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Vehicles Expenses",
                    Values = new ChartValues<double> {Expenses[2]},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Equipment Expenses",
                    Values = new ChartValues<double> {Expenses[3]},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Maintenance Expenses",
                    Values = new ChartValues<double> {Expenses[4]},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Business Insurances",
                    Values = new ChartValues<double> {Expenses[5]},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Consultancy Fees",
                    Values = new ChartValues<double> {Expenses[6]},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Marketing Costs",
                    Values = new ChartValues<double> {Expenses[7]},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Miscellaneous Expenses",
                    Values = new ChartValues<double> {Expenses[8]},
                    DataLabels = true
                }
            };
        }
    }
}
