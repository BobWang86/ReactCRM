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
    class dbSale : dbSQL
    {   
        public void addSale(string Client, string Product, string Price, string Date)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tbSale` (`SaleID`, `Client`, `Product`, `Price`, `Date`)" +
                "VALUES (NULL,@Client, @Product, @Price, @Date);";
            comm.Parameters.AddWithValue("@Client", Client);
            comm.Parameters.AddWithValue("@Product", Product);
            comm.Parameters.AddWithValue("@Price", Price);
            comm.Parameters.AddWithValue("@Date", Date);
            comm.ExecuteNonQuery();
            connClose();
        }

        public void updateSale(string SaleID, string Client, string Product, string Price, string Date)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tbSale` SET `Client`=@Client,`Product`=@Product,`Price`=@Price, `Date`=@Date WHERE SaleID = @SaleID";
            comm.Parameters.AddWithValue("@SaleID", SaleID);
            comm.Parameters.AddWithValue("@Client", Client);
            comm.Parameters.AddWithValue("@Product", Product);
            comm.Parameters.AddWithValue("@Price", Price);
            comm.Parameters.AddWithValue("@Date", Date);
            comm.ExecuteNonQuery();
            connClose();
        }

        public void deleteSale(string SaleID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tbSale` WHERE SaleID = @SaleID";
            comm.Parameters.AddWithValue("@SaleID", SaleID);
            comm.ExecuteNonQuery();
            connClose();
        }
    }
}
