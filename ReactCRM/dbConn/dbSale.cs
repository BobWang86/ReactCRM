﻿using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace ReactCRM.dbConn
{
    class dbSale : DbSQL
    {   
        public void AddSale(string ClientID, string Product, decimal Price, string Date)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tbSale` (`SaleID`, `Client`, `Product`, `Price`, `Date`)" +
                "VALUES (NULL,@Client, @Product, @Price, @Date);";
            comm.Parameters.AddWithValue("@ClientID", ClientID);
            comm.Parameters.AddWithValue("@Product", Product);
            comm.Parameters.AddWithValue("@Price", Price);
            comm.Parameters.AddWithValue("@Date", Date);
            comm.ExecuteNonQuery();
            ConnClose();
        }

        public void UpdateSale(string SaleID, string ClientID, string Product, decimal Price, string Date)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tbSale` SET `ClientID`=@ClientID,`Product`=@Product,`Price`=@Price, `Date`=@Date WHERE SaleID = @SaleID";
            comm.Parameters.AddWithValue("@SaleID", SaleID);
            comm.Parameters.AddWithValue("@ClientID", ClientID);
            comm.Parameters.AddWithValue("@Product", Product);
            comm.Parameters.AddWithValue("@Price", Price);
            comm.Parameters.AddWithValue("@Date", Date);
            comm.ExecuteNonQuery();
            ConnClose();
        }

        public void DeleteSale(string SaleID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tbSale` WHERE SaleID = @SaleID";
            comm.Parameters.AddWithValue("@SaleID", SaleID);
            comm.ExecuteNonQuery();
            ConnClose();
        }

        public List<double> GetSales(dbSale Sales, string Type)
        {
            List<double> List = new List<double>();

            Sales.Connect();
            if (Sales.ConnOpen() == true)
            {
                for (int i = 1; i <= 6; i++)
                {
                    DataTable table = Sales.SuperQuery($"SELECT SUM(Price) FROM `tbSale` WHERE `Product` = '{Type}' AND year(Date) = 2019 AND month(Date) = {i}").Tables[0];
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
            Sales.ConnClose();

            return List;
        }

        public List<double> GetSalesByDate(dbSale Sales)
        {
            List<double> List = new List<double>();

            Sales.Connect();
            if (Sales.ConnOpen() == true)
            {
                for (int i = 1; i <= 6; i++)
                {
                    DataTable table = Sales.SuperQuery($"SELECT SUM(Price) FROM `tbSale` WHERE year(Date) = 2019 AND month(Date) = {i}").Tables[0];
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
            Sales.ConnClose();

            return List;
        }

        public List<double> GetSalesByType(dbSale Sales)
        {
            List<double> List = new List<double>();

            List<string> Types = new List<string> { "Interactive Timetabling", "Automated Timetabling", "Attendance Monitoring", "Room Booking", "Pay Claim", "Integration", "Consultancy", "Training" };

            Sales.Connect();
            if (Sales.ConnOpen() == true)
            {
                foreach (var item in Types)
                {
                    DataTable table = Sales.SuperQuery($"SELECT SUM(Price) FROM `tbSale` WHERE `Product` = '{item}'").Tables[0];

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
            Sales.ConnClose();

            return List;
        }
    }
}
