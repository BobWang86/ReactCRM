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
    class dbTicket: dbSQL
    {   
        public void addTicket(string ClientID, string Detail, string Type, string Status, string ReportedAt)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tbTicket` (`TicketID`, `ClientID`, `Detail`, `Type`, `Status`, `ReportedAt`, `ResolvedAt`)" +
                "VALUES (NULL,@ClientID, @Detail, @Type, @Status, @ReportedAt, NULL);";
            comm.Parameters.AddWithValue("@ClientID", ClientID);
            comm.Parameters.AddWithValue("@Detail", Detail);
            comm.Parameters.AddWithValue("@Type", Type);
            comm.Parameters.AddWithValue("@Status", Status);
            comm.Parameters.AddWithValue("@ReportedAt", ReportedAt);
            comm.ExecuteNonQuery();
            connClose();
        }

        public void updateTicket(string TicketID, string ClientID, string Detail, string Type, string Status, string ReportedAt, string ResolvedAt)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tbClient` SET `ClientID`=@ClientID, `Detail`=@Detail, `Type`=@Type, `Status`=@Status, `ReportedAt`=@ReportedAt, `ResolvedAt`=@ResolvedAt WHERE TicketID = @TicketID";
            comm.Parameters.AddWithValue("@TicketID", TicketID);
            comm.Parameters.AddWithValue("@ClientID", ClientID);
            comm.Parameters.AddWithValue("@Detail", Detail);
            comm.Parameters.AddWithValue("@Type", Type);
            comm.Parameters.AddWithValue("@Status", Status);
            comm.Parameters.AddWithValue("@ReportedAt", ReportedAt);
            comm.Parameters.AddWithValue("@ResolvedAt", ResolvedAt);
            comm.ExecuteNonQuery();
            connClose();
        }

        public void deleteTicket(string TicketID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tbClient` WHERE TicketID = @TicketID";
            comm.Parameters.AddWithValue("@TicketID", TicketID);
            comm.ExecuteNonQuery();
            connClose();
        }
    }
}
