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
    class dbClient : dbSQL
    {   
        public void addClient(string Name, string Email, string Phone, string Institute, string Source, string Value, string Pipeline, string AddDate, string ContactDate)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tbClient` (`ClientID`, `Name`, `Email`, `Phone`, `Institute`, `Source`, `Value`, `Pipeline`, `AddDate`, `ContactDate`)" +
                "VALUES (NULL,@Name, @Email, @Phone, @Institute, @Source, @Value, @Pipeline, @AddDate, @ContactDate);";
            comm.Parameters.AddWithValue("@Name", Name);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@Institute", Institute);
            comm.Parameters.AddWithValue("@Source", Source);
            comm.Parameters.AddWithValue("@Value", Value);
            comm.Parameters.AddWithValue("@Pipeline", Pipeline);
            comm.Parameters.AddWithValue("@AddDate", AddDate);
            comm.Parameters.AddWithValue("@ContactDate", ContactDate);
            comm.ExecuteNonQuery();
            connClose();
        }

        public void updateClient(string ClientID, string Name, string Email, string Phone, string Institute, string Source, string Value, string Pipeline, string AddDate, string ContactDate)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tbClient` SET `Name`=@Name,`Email`=@Email,`Phone`=@Phone, `Institute`=@Institute, `Source`=@Source, `Value`=@Value, `Pipeline`=@Pipeline, `AddDate`=@AddDate, `ContactDate`=@ContactDate WHERE ClientID = @ClientID";
            comm.Parameters.AddWithValue("@ClientID", ClientID);
            comm.Parameters.AddWithValue("@Name", Name);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@Institute", Institute);
            comm.Parameters.AddWithValue("@Source", Source);
            comm.Parameters.AddWithValue("@Value", Value);
            comm.Parameters.AddWithValue("@Pipeline", Pipeline);
            comm.Parameters.AddWithValue("@AddDate", AddDate);
            comm.Parameters.AddWithValue("@ContactDate", ContactDate);
            comm.ExecuteNonQuery();
            connClose();
        }

        public void deleteClient(string ClientID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tbClient` WHERE ClientID = @ClientID";
            comm.Parameters.AddWithValue("@ClientID", ClientID);
            comm.ExecuteNonQuery();
            connClose();
        }
    }
}
