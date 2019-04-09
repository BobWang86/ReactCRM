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
    public partial class UC_ManageExpenses : UserControl
    {
        string ExpenseID;

        dbExpense expenses = new dbExpense();

        DataTable selectedExpense = new DataTable();

        public UC_ManageExpenses()
        {
            InitializeComponent();

            expenses.connect();
            if (expenses.connOpen() == true)
            {
                dgvExpenses.DataSource = expenses.Query($"SELECT * FROM `tbExpense`").Tables[0];
            }
            expenses.connClose();

            foreach (DataGridViewColumn column in dgvExpenses.Columns)
            {
                selectedExpense.Columns.Add(column.Name, typeof(string));
            }

            StackChart();

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
                if (expenses.connOpen() == true)
                {
                    expenses.deleteExpense(ExpenseID);
                    dgvExpenses.DataSource = expenses.Query($"SELECT * FROM `tbExpense`").Tables[0];
                }
                expenses.connClose();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            expenses.connect();
            if (expenses.connOpen() == true)
            {
                dgvExpenses.DataSource = expenses.Query($"SELECT * FROM `tbExpense`").Tables[0];
            }
            expenses.connClose();
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

        private void StackChart()
        {
            cartesianChart1.Series = new SeriesCollection
            {
                new StackedColumnSeries
                {
                    Values = new ChartValues<double> {4, 5, 6, 8},
                    StackMode = StackMode.Values, // this is not necessary, values is the default stack mode
                    DataLabels = true
                },
                new StackedColumnSeries
                {
                    Values = new ChartValues<double> {2, 5, 6, 7},
                    StackMode = StackMode.Values,
                    DataLabels = true
                }
            };

            //adding series updates and animates the chart
            cartesianChart1.Series.Add(new StackedColumnSeries
            {
                Values = new ChartValues<double> { 6, 2, 7 },
                StackMode = StackMode.Values
            });

            //adding values also updates and animates
            cartesianChart1.Series[2].Values.Add(4d);

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Browser",
                Labels = new[] { "Chrome", "Mozilla", "Opera", "IE" },
                Separator = DefaultAxes.CleanSeparator
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Usage",
                LabelFormatter = value => value + " Mill"
            });
        }

        private void DonutChart()
        {
            pieChart1.InnerRadius = 100;
            pieChart1.LegendLocation = LegendLocation.Right;

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Chrome",
                    Values = new ChartValues<double> {8},
                    PushOut = 15,
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Mozilla",
                    Values = new ChartValues<double> {6},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Opera",
                    Values = new ChartValues<double> {10},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Explorer",
                    Values = new ChartValues<double> {4},
                    DataLabels = true
                }
            };
        }
    }
}
