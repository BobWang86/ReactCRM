using ReactCRM.dbConn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReactCRM.Forms
{
    public partial class Form_AddExpense : Form
    {
        dbExpense expenses = new dbExpense();

        string ExpenseID;

        public Form_AddExpense()
        {
            InitializeComponent();

            tbType.DropDownStyle = ComboBoxStyle.DropDownList;
            tbType.Items.AddRange(new string[] { "Employee salaries", "Office Expenses", "Vehicles Expenses", "Equipment Expenses", "Maintenance Expenses", "Business Insurances", "Consultancy Fees", "Marketing Costs", "Miscellaneous Expenses" });
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            expenses.connect();
            if (expenses.connOpen() == true && FormValidate())
            {
                expenses.addExpense(ExpenseID, tbType.Text, tbAmount.Text, tbDate.Value.ToString("yyyy-MM-dd"));

                MessageBox.Show("New Expense Added!", "Add Expense", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill in all the fields!", "Add Expense", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            expenses.connClose();
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
