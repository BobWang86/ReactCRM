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
    class dbTicket: DbSQL
    {   
        public void AddTicket(string ClientID, string Detail, string Type, string Status, string ReportDate, string ResponsdDate)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tbTicket` (`TicketID`, `ClientID`, `Detail`, `Type`, `Status`, `ReportDate`, `RespondDate`)" +
                "VALUES (NULL,@ClientID, @Detail, @Type, @Status, @ReportDate, @ResponsdDate);";
            comm.Parameters.AddWithValue("@ClientID", ClientID);
            comm.Parameters.AddWithValue("@Detail", Detail);
            comm.Parameters.AddWithValue("@Type", Type);
            comm.Parameters.AddWithValue("@Status", Status);
            comm.Parameters.AddWithValue("@ReportDate", ReportDate);
            comm.Parameters.AddWithValue("@ResponsdDate", ResponsdDate);
            comm.ExecuteNonQuery();
            ConnClose();
        }

        public void UpdateTicket(string TicketID, string ClientID, string Detail, string Type, string Status, string ReportDate, string RespondDate)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tbTicket` SET `ClientID`=@ClientID, `Detail`=@Detail, `Type`=@Type, `Status`=@Status, `ReportDate`=@ReportDate, `RespondDate`=@RespondDate WHERE `TicketID` = @TicketID";
            comm.Parameters.AddWithValue("@TicketID", TicketID);
            comm.Parameters.AddWithValue("@ClientID", ClientID);
            comm.Parameters.AddWithValue("@Detail", Detail);
            comm.Parameters.AddWithValue("@Type", Type);
            comm.Parameters.AddWithValue("@Status", Status);
            comm.Parameters.AddWithValue("@ReportDate", ReportDate);
            comm.Parameters.AddWithValue("@RespondDate", RespondDate);
            comm.ExecuteNonQuery();
            ConnClose();
        }

        public void DeleteTicket(string TicketID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tbTicket` WHERE TicketID = @TicketID";
            comm.Parameters.AddWithValue("@TicketID", TicketID);
            comm.ExecuteNonQuery();
            ConnClose();
        }
    }
}
