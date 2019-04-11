using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactCRM.dbConn
{
    class dbExpense : dbSQL
    {   //ExpenseID	Type Amount CreatedAt
        public void addExpense(string ExpenseID, string Type, string Amount, string Date)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tbExpense` (`ExpenseID`, `Type`, `Amount`, `Date`)" +
                "VALUES (NULL,@Type, @Amount, @Date);";
            comm.Parameters.AddWithValue("@Type", Type);
            comm.Parameters.AddWithValue("@Amount", Amount);
            comm.Parameters.AddWithValue("@Date", Date);
            comm.ExecuteNonQuery();
            connClose();
        }

        public void updateExpense(string ExpenseID, string Type, string Amount, string Date)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tbExpense` SET `Type`=@Type,`Amount`=@Amount, `Date`=@Date WHERE ExpenseID = @ExpenseID";
            comm.Parameters.AddWithValue("@ExpenseID", ExpenseID);
            comm.Parameters.AddWithValue("@Type", Type);
            comm.Parameters.AddWithValue("@Amount", Amount);
            comm.Parameters.AddWithValue("@Date", Date);
            comm.ExecuteNonQuery();
            connClose();
        }

        public void deleteExpense(string ExpenseID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tbExpense` WHERE ExpenseID = @ExpenseID";
            comm.Parameters.AddWithValue("@ExpenseID", ExpenseID);
            comm.ExecuteNonQuery();
            connClose();
        }

        public List<double> getExpensesByDate(dbExpense Expenses)
        {
            List<double> List = new List<double>();

            Expenses.connect();
            if (Expenses.connOpen() == true)
            {
                for (int i = 1; i <= 6; i++)
                {
                    DataTable table = Expenses.superQuery($"SELECT SUM(Amount) FROM `tbExpense` WHERE `Date` Like '%2019-0{i}%'").Tables[0];
                    if (string.IsNullOrEmpty(table.Rows[0][0].ToString()))
                    {
                        List.Add(0);
                    }
                    else
                    {
                        List.Add(double.Parse(table.Rows[0][0].ToString()));
                    }
                }
            }
            Expenses.connClose();

            return List;
        }

        public List<double> getExpensesByType(dbExpense Expenses)
        {
            List<double> List = new List<double>();

            List<string> Types = new List<string> { "Employee salaries", "Office Expenses", "Vehicles Expenses", "Equipment Expenses", "Maintenance Expenses", "Business Insurances", "Consultancy Fees", "Marketing Costs", "Miscellaneous Expenses" };

            Expenses.connect();
            if (Expenses.connOpen() == true)
            {
                foreach (var item in Types)
                {
                    DataTable table = Expenses.superQuery($"SELECT SUM(Amount) FROM `tbExpense` WHERE `Type` = '{item}'").Tables[0];

                    if (string.IsNullOrEmpty(table.Rows[0][0].ToString()))
                    {
                        List.Add(0);
                    }
                    else
                    {
                        List.Add(double.Parse(table.Rows[0][0].ToString()));
                    }
                }
            }
            Expenses.connClose();

            return List;
        }
    }
}
