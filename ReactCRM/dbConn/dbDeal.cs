using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ReactCRM.dbConn
{
    class dbDeal : dbConn
    {   //DealID Client Product Amount Date

        //Insert passenger function.
        public void addDeal(string Client, string Product, string Amount, string Date)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tbDeal` (`DealID`, `Client`, `Product`, `Amount`, `Date`)" +
                "VALUES (NULL,@Client, @Product, @Amount, @Date);";
            comm.Parameters.AddWithValue("@Client", Client);
            comm.Parameters.AddWithValue("@Product", Product);
            comm.Parameters.AddWithValue("@Amount", Amount);
            comm.Parameters.AddWithValue("@Date", Date);
            comm.ExecuteNonQuery();
            connClose();
        }

        //Updata passenger function.
        public void updatePassenger(string DealID, string Client, string Product, string Amount, string Date)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tbDeal` SET `Client`=@Client,`Product`=@Product,`Amount`=@Amount, `Date`=@Date WHERE DealID = @DealID";
            comm.Parameters.AddWithValue("@DealID", DealID);
            comm.Parameters.AddWithValue("@Client", Client);
            comm.Parameters.AddWithValue("@Product", Product);
            comm.Parameters.AddWithValue("@Amount", Amount);
            comm.Parameters.AddWithValue("@Date", Date);
            comm.ExecuteNonQuery();
            connClose();
        }

        //Function to delete passenger by passenger ID.
        public void deletePassenger(string DealID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tbDeal` WHERE DealID = @DealID";
            comm.Parameters.AddWithValue("@DealID", DealID);
            comm.ExecuteNonQuery();
            connClose();
        }
    }
}
