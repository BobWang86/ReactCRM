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
    class dbClient : DbSQL
    {
        public void AddClient(string Name, string Email, string Phone, string Institute, string Source, string Pipeline, string AddDate, string ContactDate)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tbClient` (`ClientID`, `Name`, `Email`, `Phone`, `Institute`, `Source`, `Pipeline`, `AddDate`, `ContactDate`)" +
                "VALUES (NULL,@Name, @Email, @Phone, @Institute, @Source, @Pipeline, @AddDate, @ContactDate);";
            comm.Parameters.AddWithValue("@Name", Name);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@Institute", Institute);
            comm.Parameters.AddWithValue("@Source", Source);
            comm.Parameters.AddWithValue("@Pipeline", Pipeline);
            comm.Parameters.AddWithValue("@AddDate", AddDate);
            comm.Parameters.AddWithValue("@ContactDate", ContactDate);
            comm.ExecuteNonQuery();
            ConnClose();
        }

        public void UpdateClient(string ClientID, string Name, string Email, string Phone, string Institute, string Source, string Pipeline, string AddDate, string ContactDate)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tbClient` SET `Name`=@Name,`Email`=@Email,`Phone`=@Phone, `Institute`=@Institute, `Source`=@Source, `Pipeline`=@Pipeline, `AddDate`=@AddDate, `ContactDate`=@ContactDate WHERE `ClientID` = @ClientID";
            comm.Parameters.AddWithValue("@ClientID", ClientID);
            comm.Parameters.AddWithValue("@Name", Name);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@Institute", Institute);
            comm.Parameters.AddWithValue("@Source", Source);
            comm.Parameters.AddWithValue("@Pipeline", Pipeline);
            comm.Parameters.AddWithValue("@AddDate", AddDate);
            comm.Parameters.AddWithValue("@ContactDate", ContactDate);
            comm.ExecuteNonQuery();
            ConnClose();
        }

        public void DeleteClient(string ClientID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tbClient` WHERE ClientID = @ClientID";
            comm.Parameters.AddWithValue("@ClientID", ClientID);
            comm.ExecuteNonQuery();
            ConnClose();
        }

        public void UpdateClientPipeline(string ClientID, string Pipeline)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tbClient` SET `Pipeline`=@Pipeline WHERE `ClientID` = @ClientID";
            comm.Parameters.AddWithValue("@ClientID", ClientID);
            comm.Parameters.AddWithValue("@Pipeline", Pipeline);
            comm.ExecuteNonQuery();
            ConnClose();
        }

        public List<int> GetClientByMonth(dbClient Clients)
        {
            List<int> Count = new List<int>();

            Clients.Connect();
            if (Clients.ConnOpen() == true)
            {
                for (int i = 1; i <= 6; i++)
                {
                    int count = Clients.SuperQuery($"SELECT * FROM `tbClient` WHERE `AddDate` Like '%2019-0{i}%'").Tables[0].Rows.Count;

                    Count.Add(count);
                }
            }
            Clients.ConnClose();

            return Count;
        }

        public List<int> GetClientBySource(dbClient Clients)
        {
            List<int> Count = new List<int>();

            List<string> Sources = new List<string> { "Call", "Email", "Referal", "Partner", "Campaign", "WebForm", "SocialMedia" };

            Clients.Connect();
            if (Clients.ConnOpen() == true)
            {
                foreach (var item in Sources)
                {
                    Count.Add(Clients.SuperQuery($"SELECT * FROM `tbClient` WHERE `Source` = '{item}'").Tables[0].Rows.Count);
                }
            }
            Clients.ConnClose();

            return Count;
        }

        public List<double> GetClientByPipeline(dbClient Clients)
        {
            List<double> Count = new List<double>();

            List<string> Pipeline = new List<string> { "Awareness", "Interest", "Decision", "Action" };

            Clients.Connect();
            if (Clients.ConnOpen() == true)
            {
                foreach (var item in Pipeline)
                {
                    Count.Add(Clients.SuperQuery($"SELECT * FROM `tbClient` WHERE `Pipeline` = '{item}'").Tables[0].Rows.Count);
                }
            }
            Clients.ConnClose();

            return Count;
        }

        public int GetClientCount(dbClient Clients)
        {
            int count = 0;

            Clients.Connect();
            if (Clients.ConnOpen() == true)
            {
                count = Clients.SuperQuery($"SELECT `ClientID` FROM `tbClient`").Tables[0].Rows.Count;
            }
            Clients.ConnClose();

            return count;
        }
    }
}
