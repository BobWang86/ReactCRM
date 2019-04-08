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
    }
}
