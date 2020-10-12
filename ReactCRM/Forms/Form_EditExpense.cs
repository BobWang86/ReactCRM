using ReactCRM.dbConn;
using System;
using System.Data;
using System.Windows.Forms;

namespace ReactCRM.Forms
{
    public partial class Form_EditExpense : Form
    {
        dbExpense expenses = new dbExpense();

        public Form_EditExpense(DataTable selectedExpense)
        {
            InitializeComponent();

            tbExpense.Text = selectedExpense.Rows[0][0].ToString();
            tbType.Text = selectedExpense.Rows[0][1].ToString();
            tbAmount.Text = selectedExpense.Rows[0][2].ToString();
            tbDate.Text = selectedExpense.Rows[0][3].ToString();

            tbType.DropDownStyle = ComboBoxStyle.DropDownList;
            tbType.Items.AddRange(new string[] { "Employee salaries", "Office Expenses", "Vehicles Expenses", "Equipment Expenses", "Maintenance Expenses", "Business Insurances", "Consultancy Fees", "Marketing Costs", "Miscellaneous Expenses" });
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            expenses.Connect();
            if (expenses.ConnOpen() == true && FormValidate())
            {
                expenses.UpdateExpense(tbExpense.Text, tbType.Text, tbAmount.Value, tbDate.Value.ToString("yyyy-MM-dd"));

                MessageBox.Show("Sale Info Updated!", "Edit Expense", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill in all the fields!", "Edit Expense", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            expenses.ConnClose();
        }

        private bool FormValidate()
        {
            if (tbType.Text.Length == 0)
            {
                return false;
            }

            if (tbAmount.Text.Length == 0)
            {
                return false;
            }

            if (tbDate.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

    }
}
