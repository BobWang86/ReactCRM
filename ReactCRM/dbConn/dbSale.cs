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

        public List<double> getSales(dbSale Sales, string Type)
        {
            List<double> List = new List<double>();

            Sales.connect();
            if (Sales.connOpen() == true)
            {
                for (int i = 1; i <= 6; i++)
                {
                    DataTable table = Sales.superQuery($"SELECT SUM(Price) FROM `tbSale` WHERE `Product` = '{Type}' && `Date` Like '%2019-0{i}%'").Tables[0];
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
            Sales.connClose();

            return List;
        }

        public List<double> getSalesByDate(dbSale Sales)
        {
            List<double> List = new List<double>();

            Sales.connect();
            if (Sales.connOpen() == true)
            {
                for (int i = 1; i <= 6; i++)
                {
                    DataTable table = Sales.superQuery($"SELECT SUM(Price) FROM `tbSale` WHERE `Date` Like '%2019-0{i}%'").Tables[0];
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
            Sales.connClose();

            return List;
        }

        public List<double> getSalesByType(dbSale Sales)
        {
            List<double> List = new List<double>();

            List<string> Types = new List<string> { "Interactive Timetabling", "Automated Timetabling", "Attendance Monitoring", "Room Booking", "Pay Claim", "Integration", "Consultancy", "Training" };

            Sales.connect();
            if (Sales.connOpen() == true)
            {
                foreach (var item in Types)
                {
                    DataTable table = Sales.superQuery($"SELECT SUM(Price) FROM `tbSale` WHERE `Product` = '{item}'").Tables[0];

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
            Sales.connClose();

            return List;
        }
    }
}
