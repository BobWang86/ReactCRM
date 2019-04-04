using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactCRM.dbConn
{
    class BookingsDbConn : dbConn
    {
        //Insert booking function.
        public void insertBooking(string BookingID, string PassengerID, string FlightID, string BookingPrice)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tblbooking` (`BookingID`, `PassengerID`, `FlightID`, `BookingPrice`) VALUES (NULL, @PassengerID, @FlightID, @BookingPrice);";
            comm.Parameters.AddWithValue("@BookingID", BookingID);
            comm.Parameters.AddWithValue("@PassengerID", PassengerID);
            comm.Parameters.AddWithValue("@FlightID", FlightID);
            comm.Parameters.AddWithValue("@BookingPrice", BookingPrice);

            comm.ExecuteNonQuery();
            connClose();
        }

        //Update booking function.
        public void updateBooking(string BookingID, string CusID, string FlightID, string Booking_DateTime, string Total_BookingCost)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tblbooking` SET `CusID`=@CusID,`FlightID`=@FlightID,`Booking_DateTime`=@Booking_DateTime,`Total_BookingCost`=@Total_BookingCost WHERE BookinID=@BookinID";
            comm.Parameters.AddWithValue("@CusID", CusID );
            comm.Parameters.AddWithValue("@FlightID", FlightID);
            comm.Parameters.AddWithValue("@Booking_DateTime", Booking_DateTime);
            comm.Parameters.AddWithValue("@Total_BookingCost", Total_BookingCost);
            comm.Parameters.AddWithValue("@BookinID", BookingID);
            comm.ExecuteNonQuery();
            connClose();
        }

        //Delete booking function.
        public void deleteBooking(string BookingID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tblbooking` WHERE `BookingID` = @BookingID";
            comm.Parameters.AddWithValue("@BookingID", BookingID);
            comm.ExecuteNonQuery();
            connClose();
        }

        //Delete booking by passenger ID.
        public void deleteBookingByPassenger(string PassengerID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tblbooking` WHERE `PassengerID` = @PassengerID";
            comm.Parameters.AddWithValue("@PassengerID", PassengerID);
            comm.ExecuteNonQuery();
            connClose();
        }

        //Get user's booking records from a MySQL View that joins three tables together. 
        public DataTable DisplayUserBookingHistory(BookingsDbConn mysqlConn, string userID)
        {
            DataTable output = mysqlConn.Query($"SELECT `BookingID`, `FlightID`, `FirstName`, `LastName`, `Aircraft`, `Departure_City`, `Arrival_City`, `Duration`, `Departure_DateTime`, `Arrival_DateTime`, `BookingPrice`, `Booking_DateTime` FROM `viewBookingHistory` WHERE `UserID`={userID}").Tables[0];

            return output;
        }

        //Get all booking records from a MySQL View that joins three tables together. 
        public DataTable DisplayAllBookingHistory(BookingsDbConn mysqlConn)
        {
            DataTable output = mysqlConn.Query("SELECT `BookingID`, `FlightID`, `FirstName`, `LastName`, `Aircraft`, `Departure_City`, `Arrival_City`, `Duration`, `Departure_DateTime`, `Arrival_DateTime`, `BookingPrice`, `Booking_DateTime` FROM `viewBookingHistory`").Tables[0];

            return output;
        }

        //Check if a booking record already exists in the databas. 
        public bool checkBookingExist(string PassengerID, string FlightID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = $"SELECT * FROM `tblbooking` WHERE `PassengerID`=@PassengerID AND `FlightID`=@FlightID";
            comm.Parameters.AddWithValue("@PassengerID", PassengerID);
            comm.Parameters.AddWithValue("@FlightID", FlightID);

            MySqlDataAdapter adapter = new MySqlDataAdapter(comm);
            DataTable table = new DataTable();

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
