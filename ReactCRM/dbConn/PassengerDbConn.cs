using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ReactCRM
{
    class PassengerDbConn: dbConn
    {
        //Insert passenger function.
        public void insertPassenger(string CusFName, string CusLName, string CusTelNum, string CusNation, string CusGender, string CusBirthDate, string UserID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tblpassenger` (`CusID`, `CusFName`, `CusLName`, `CusTelNum`, `CusNation`, `CusGender`, `CusBirthDate`, `UserID`)" + 
                "VALUES (NULL,@CusFName, @CusLName, @CusTelNum, @CusNation, @CusGender, @CusBirthDate, @UserID);";
            comm.Parameters.AddWithValue("@CusFName", CusFName);
            comm.Parameters.AddWithValue("@CusLName", CusLName);
            comm.Parameters.AddWithValue("@CusTelNum", CusTelNum);
            comm.Parameters.AddWithValue("@CusNation", CusNation);
            comm.Parameters.AddWithValue("@CusGender", CusGender);
            comm.Parameters.AddWithValue("@CusBirthDate", CusBirthDate);
            comm.Parameters.AddWithValue("@UserID", UserID);
            comm.ExecuteNonQuery();
            connClose();
        }

        //Updata passenger function.
        public void updatePassenger(string CusID, string CusFName, string CusLName, string CusTelNum, string CusNation, string CusGender, string CusBirthDate, string UserID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tblpassenger` SET `CusFName`=@CusFName,`CusLName`=@CusLName,`CusTelNum`=@CusTelNum, `CusNation`=@CusNation, `CusGender`=@CusGender, `CusBirthDate`=@CusBirthDate, `UserID`=@UserID WHERE CusID = @CusID";
            comm.Parameters.AddWithValue("@CusID", CusID);
            comm.Parameters.AddWithValue("@CusFName", CusFName);
            comm.Parameters.AddWithValue("@CusLName", CusLName);
            comm.Parameters.AddWithValue("@CusTelNum", CusTelNum);
            comm.Parameters.AddWithValue("@CusNation", CusNation);
            comm.Parameters.AddWithValue("@CusGender", CusGender);
            comm.Parameters.AddWithValue("@CusBirthDate", CusBirthDate);
            comm.Parameters.AddWithValue("@UserID", UserID);
            comm.ExecuteNonQuery();
            connClose();
        }

        //Function to delete passenger by passenger ID.
        public void deletePassenger(string CusID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tblpassenger` WHERE CusID = @CusID";
            comm.Parameters.AddWithValue("@CusID", CusID);
            comm.ExecuteNonQuery();
            connClose();
        }

        //Function to delete passenger by user ID.
        public void deletePassengerByUser(string UserID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tblpassenger` WHERE UserID = @UserID";
            comm.Parameters.AddWithValue("@UserID", UserID);
            comm.ExecuteNonQuery();
            connClose();
        }

        //Get all passengers that belong to one user account.
        public DataTable getPassengerByUser(PassengerDbConn mysqlConn, string UserID)
        {
            DataTable output = mysqlConn.Query($"SELECT CusID FROM `tblpassenger` WHERE `UserID`={UserID}").Tables[0];

            return output;
        }
    }
}
