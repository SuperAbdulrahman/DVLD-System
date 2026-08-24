using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class DriverDataAccess
    {
        public static bool GetDriver(int driverID, ref int personID, ref int createdByUserID, ref DateTime createdDate)
        {
            bool isFound = false;
            string query = @"SELECT * FROM Drivers WHERE DriverID = @DriverID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DriverID", driverID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            personID = reader["PersonID"] is DBNull ? 0 : (int)reader["PersonID"];
                            createdByUserID = reader["CreatedByUserID"] is DBNull ? 0 : (int)reader["CreatedByUserID"];
                            createdDate = reader["CreatedDate"] is DBNull ? DateTime.MinValue : (DateTime)reader["CreatedDate"];

                            isFound = true;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }

            return isFound;
        }

        public static DataTable GetDrivers()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT * FROM Drivers_View;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception)
            {
            }

            return dt;
        }

        public static int AddNewDriver(int personID, int createdByUserID)
        {
            int newDriverID = -1;

            string query = @"INSERT INTO Drivers (PersonID, CreatedByUserID, CreatedDate)
                             VALUES (@PersonID, @CreatedByUserID, GETDATE());

                             SELECT SCOPE_IDENTITY();";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", personID);
                    command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null)
                        newDriverID = Convert.ToInt32(result);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return newDriverID;
        }

        public static bool UpdateDriver(int driverID, int personID, int createdByUserID)
        {
            int rowsAffected = 0;

            string query = @"UPDATE Drivers SET
                             PersonID = @PersonID,
                             CreatedByUserID = @CreatedByUserID
                             WHERE DriverID = @DriverID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DriverID", driverID);
                    command.Parameters.AddWithValue("@PersonID", personID);
                    command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                return false;
            }

            return (rowsAffected > 0);
        }

        public static bool Delete(int driverID)
        {
            int rowsAffected = 0;
            string query = @"DELETE FROM Drivers WHERE DriverID = @DriverID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DriverID", driverID);
                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
            }

            return (rowsAffected > 0);
        }

        public static bool IsDriverExist(int driverID)
        {
            bool isFound = false;
            string query = @"SELECT 1 FROM Drivers WHERE DriverID = @DriverID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DriverID", driverID);
                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null)
                        isFound = true;
                }
            }
            catch (Exception)
            {
            }

            return isFound;
        }
        public static int GetDriverIDForPerson(int personID)
        {
            int DriverID = -1;

            string query = @"SELECT DriverID FROM Drivers WHERE PersonID =@PersonID;";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", personID);
   
                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        DriverID = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }

            return DriverID;
        }
    }
}
