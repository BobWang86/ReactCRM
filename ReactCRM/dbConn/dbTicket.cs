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
    class dbTicket: dbConn
    {   
        //Add client function.
        public void addTicket(string ReportedBy, string HandledBy, string Detail, string Type, string Status, string ReportedAt, string ResolvedAt)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tbTicket` (`TicketID`, `ReportedBy`, `HandledBy`, `Detail`, `Type`, `Status`, `ReportedAt`, `ResolvedAt`)" +
                "VALUES (NULL,@ReportedBy, @HandledBy, @Detail, @Type, @Status, @ReportedAt, @ResolvedAt);";
            comm.Parameters.AddWithValue("@ReportedBy", ReportedBy);
            comm.Parameters.AddWithValue("@HandledBy", HandledBy);
            comm.Parameters.AddWithValue("@Detail", Detail);
            comm.Parameters.AddWithValue("@Type", Type);
            comm.Parameters.AddWithValue("@Status", Status);
            comm.Parameters.AddWithValue("@ReportedAt", ReportedAt);
            comm.Parameters.AddWithValue("@ResolvedAt", ResolvedAt);
            comm.ExecuteNonQuery();
            connClose();
        }

        //Updata passenger function.
        public void updateTicket(string TicketID, string ReportedBy, string HandledBy, string Detail, string Type, string Status, string ReportedAt, string ResolvedAt)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tbClient` SET `ReportedBy`=@ReportedBy,`HandledBy`=@HandledBy,`Detail`=@Detail, `Type`=@Type, `Status`=@Status, `ReportedAt`=@ReportedAt, `ResolvedAt`=@ResolvedAt WHERE TicketID = @TicketID";
            comm.Parameters.AddWithValue("@TicketID", TicketID);
            comm.Parameters.AddWithValue("@ReportedBy", ReportedBy);
            comm.Parameters.AddWithValue("@HandledBy", HandledBy);
            comm.Parameters.AddWithValue("@Detail", Detail);
            comm.Parameters.AddWithValue("@Type", Type);
            comm.Parameters.AddWithValue("@Status", Status);
            comm.Parameters.AddWithValue("@ReportedAt", ReportedAt);
            comm.Parameters.AddWithValue("@ResolvedAt", ResolvedAt);
            comm.ExecuteNonQuery();
            connClose();
        }

        //Function to delete passenger by passenger ID.
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
