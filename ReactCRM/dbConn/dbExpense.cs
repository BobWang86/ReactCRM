using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
    }
}
