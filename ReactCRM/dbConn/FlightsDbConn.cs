using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactCRM.dbConn
{
    class FlightsDbConn : DbSQL
    {
        //Insert flight function.
        public void insertFlight(string F_Aircraft, string F_Depar_DateTime, string F_Arrival_DateTime, string F_Departure_City, string F_Arrival_City, string F_Duration, string F_AdultPrice, string F_ChildPrice, string F_InfantPrice)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tblflight`(`FlightID`, `F_Aircraft`, `F_Depar_DateTime`, `F_Arrival_DateTime`, `F_Departure_City`, `F_Arrival_City`, `F_Duration`, `F_AdultPrice`, `F_ChildPrice`, `F_InfantPrice`)" +
                "VALUES (NULL, @F_Aircraft, @F_Depar_DateTime, @F_Arrival_DateTime, @F_Departure_City, @F_Arrival_City, @F_Duration, @F_AdultPrice, @F_ChildPrice, @F_InfantPrice);";
            comm.Parameters.AddWithValue("@F_Aircraft", F_Aircraft);
            comm.Parameters.AddWithValue("@F_Depar_DateTime", F_Depar_DateTime);
            comm.Parameters.AddWithValue("@F_Arrival_DateTime", F_Arrival_DateTime);
            comm.Parameters.AddWithValue("@F_Departure_City", F_Departure_City);
            comm.Parameters.AddWithValue("@F_Arrival_City", F_Arrival_City);
            comm.Parameters.AddWithValue("@F_Duration", F_Duration);
            comm.Parameters.AddWithValue("@F_AdultPrice", F_AdultPrice);
            comm.Parameters.AddWithValue("@F_ChildPrice", F_ChildPrice);
            comm.Parameters.AddWithValue("@F_InfantPrice", F_InfantPrice);
            comm.ExecuteNonQuery();
            ConnClose();
        }

        //Another version of insert flight function with a complete flight entry as input.
        public void generateFlight(string FlightEntry)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = $"INSERT INTO `tblflight`(`FlightID`, `F_Aircraft`, `F_Depar_DateTime`, `F_Arrival_DateTime`, `F_Departure_City`, `F_Arrival_City`, `F_Duration`, `F_AdultPrice`, `F_ChildPrice`, `F_InfantPrice`) VALUES {FlightEntry};";
            comm.Parameters.AddWithValue("@FlightEntry", FlightEntry);
            comm.ExecuteNonQuery();
            ConnClose();
        }

        //Update flight function.
        public void updateFlight(string FlightID, string F_Aircraft, string F_Depar_DateTime, string F_Arrival_DateTime, string F_Departure_City, string F_Arrival_City, string F_Duration, string F_AdultPrice, string F_ChildPrice, string F_InfantPrice)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tblflight` SET `F_Aircraft`=@F_Aircraft, `F_Depar_DateTime`=@F_Depar_DateTime,`F_Arrival_DateTime`=@F_Arrival_DateTime,`F_Departure_City`=@F_Departure_City, `F_Arrival_City`=@F_Arrival_City," +
                "`F_AdultPrice`=@F_AdultPrice, `F_ChildPrice`=@F_ChildPrice, `F_InfantPrice`=@F_InfantPrice WHERE FlightID = @FlightID";
            comm.Parameters.AddWithValue("@F_Aircraft", F_Aircraft);
            comm.Parameters.AddWithValue("@F_Depar_DateTime", F_Depar_DateTime);
            comm.Parameters.AddWithValue("@F_Arrival_DateTime", F_Arrival_DateTime);
            comm.Parameters.AddWithValue("@F_Departure_City", F_Departure_City);
            comm.Parameters.AddWithValue("@F_Arrival_City", F_Arrival_City);
            comm.Parameters.AddWithValue("@F_Duration", F_Duration);
            comm.Parameters.AddWithValue("@F_AdultPrice", F_AdultPrice);
            comm.Parameters.AddWithValue("@F_ChildPrice", F_ChildPrice);
            comm.Parameters.AddWithValue("@F_InfantPrice", F_InfantPrice);
            comm.Parameters.AddWithValue("@FlightID", FlightID);
            comm.ExecuteNonQuery();
            ConnClose();
        }


        //Delete flight function.
        public void deleteFlight(string FlightID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tblflight` WHERE FlightID = @FlightID";
            comm.Parameters.AddWithValue("@FlightID", FlightID);
            comm.ExecuteNonQuery();
            ConnClose();
        }

        //Add a new aircraft model to the database.
        public void addNewModel(string AircraftID, string AircraftModel)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tblaircraft` (`AircraftID`, `AircraftModel`) VALUES (NULL, @AircraftModel);";
            comm.Parameters.AddWithValue("@AircraftID", AircraftID);
            comm.Parameters.AddWithValue("@AircraftModel", AircraftModel);
            comm.ExecuteNonQuery();
            ConnClose();
        }

        //Add a new flight city to the database.
        public void addNewCity(string AirportID, string AirportName)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tblairport` (`AirportID`, `AirportName`) VALUES (NULL, @AirportName);";
            comm.Parameters.AddWithValue("@AirportID", AirportID);
            comm.Parameters.AddWithValue("@AirportName", AirportName);
            comm.ExecuteNonQuery();
            ConnClose();
        }

        //Search for flight by specifying both city and date.
        public DataTable searchFlight(FlightsDbConn mysqlConn, string city, string date)
        {
            DataTable output = mysqlConn.Query($"SELECT * FROM `viewFlight` WHERE Departure_Time LIKE CONCAT('%', '{date}', '%') && (Departure_City LIKE CONCAT('%', '{city}', '%') || Arrival_City LIKE CONCAT('%', '{city}','%'))").Tables[0];

            return output;
        }

        //Search for flight by specifying only date.
        public DataTable searchFlightByDate(FlightsDbConn mysqlConn, string date)
        {
            DataTable output = mysqlConn.Query($"SELECT * FROM `viewFlight` WHERE Departure_Time LIKE CONCAT('%', '{date}', '%') || Arrival_Time LIKE CONCAT('%', '{date}','%')").Tables[0];

            return output;
        }

        //Get all aircraft models from database.
        public DataTable GetAircraftModel(FlightsDbConn mysqlConn)
        {
            DataTable output = mysqlConn.Query("SELECT * FROM `tblaircraft`").Tables[0];

            return output;
        }

        //Get all flight cities from database.
        public DataTable GetAirportName(FlightsDbConn mysqlConn)
        {
            DataTable output = mysqlConn.Query("SELECT * FROM `tblairport`").Tables[0];

            return output;
        }
    }
}
