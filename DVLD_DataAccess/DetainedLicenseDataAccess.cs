using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class DetainedLicenseDataAccess
    {
        public static bool GetDetainedLicense(int detainID, ref int licenseID, ref DateTime detainDate,
              ref decimal fineFees, ref int createdByUserID, ref bool isReleased,
              ref DateTime releaseDate, ref int releasedByUserID, ref int releaseApplicationID)
        {
            bool isFound = false;

            string query = @"SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DetainID", detainID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            licenseID = reader["LicenseID"] is DBNull ? 0 : (int)reader["LicenseID"];
                            detainDate = reader["DetainDate"] is DBNull ? DateTime.MinValue : (DateTime)reader["DetainDate"];
                            fineFees = reader["FineFees"] is DBNull ? 0 : (decimal)reader["FineFees"];
                            createdByUserID = reader["CreatedByUserID"] is DBNull ? 0 : (int)reader["CreatedByUserID"];
                            isReleased = reader["IsReleased"] is DBNull ? false : (bool)reader["IsReleased"];
                            releaseDate = reader["ReleaseDate"] is DBNull ? DateTime.MinValue : (DateTime)reader["ReleaseDate"];
                            releasedByUserID = reader["ReleasedByUserID"] is DBNull ? 0 : (int)reader["ReleasedByUserID"];
                            releaseApplicationID = reader["ReleaseApplicationID"] is DBNull ? 0 : (int)reader["ReleaseApplicationID"];

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

        public static DataTable GetDetainedLicenses()
        {
            DataTable dt = new DataTable();

            string query = @"SELECT * FROM DetainedLicenses_View;";

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

        public static int AddNewDetainedLicense(int licenseID, DateTime detainDate,
            decimal fineFees, int createdByUserID, bool isReleased,
            DateTime releaseDate, int releasedByUserID, int releaseApplicationID)
        {
            int newDetainID = -1;

            string query = @"INSERT INTO DetainedLicenses
                             (LicenseID, DetainDate, FineFees, CreatedByUserID,
                              IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID)
                             VALUES
                             (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID,
                              @IsReleased, @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID);

                             SELECT SCOPE_IDENTITY();";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", licenseID);
                    command.Parameters.AddWithValue("@DetainDate", detainDate);
                    command.Parameters.AddWithValue("@FineFees", fineFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
                    command.Parameters.AddWithValue("@IsReleased", isReleased);

                    command.Parameters.AddWithValue("@ReleaseDate",
                        releaseDate == DateTime.MinValue ? (object)DBNull.Value : releaseDate);

                    command.Parameters.AddWithValue("@ReleasedByUserID",
                        releasedByUserID == -1 ? (object)DBNull.Value : releasedByUserID);

                    command.Parameters.AddWithValue("@ReleaseApplicationID",
                        releaseApplicationID == -1 ? (object)DBNull.Value : releaseApplicationID);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null)
                        newDetainID = Convert.ToInt32(result);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return newDetainID;
        }

        public static bool UpdateDetainedLicense(int detainID, int licenseID,
            DateTime detainDate, decimal fineFees, int createdByUserID,
            bool isReleased, DateTime releaseDate,
            int releasedByUserID, int releaseApplicationID)
        {
            int rowsAffected = 0;

            string query = @"UPDATE DetainedLicenses SET
                             LicenseID = @LicenseID,
                             DetainDate = @DetainDate,
                             FineFees = @FineFees,
                             CreatedByUserID = @CreatedByUserID,
                             IsReleased = @IsReleased,
                             ReleaseDate = @ReleaseDate,
                             ReleasedByUserID = @ReleasedByUserID,
                             ReleaseApplicationID = @ReleaseApplicationID
                             WHERE DetainID = @DetainID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DetainID", detainID);
                    command.Parameters.AddWithValue("@LicenseID", licenseID);
                    command.Parameters.AddWithValue("@DetainDate", detainDate);
                    command.Parameters.AddWithValue("@FineFees", fineFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
                    command.Parameters.AddWithValue("@IsReleased", isReleased);

                    command.Parameters.AddWithValue("@ReleaseDate",
                        releaseDate == DateTime.MinValue ? (object)DBNull.Value : releaseDate);

                    command.Parameters.AddWithValue("@ReleasedByUserID",
                        releasedByUserID == -1 ? (object)DBNull.Value : releasedByUserID);

                    command.Parameters.AddWithValue("@ReleaseApplicationID",
                        releaseApplicationID == -1 ? (object)DBNull.Value : releaseApplicationID);

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

        public static bool Delete(int detainID)
        {
            int rowsAffected = 0;

            string query = @"DELETE FROM DetainedLicenses WHERE DetainID = @DetainID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DetainID", detainID);
                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
            }

            return (rowsAffected > 0);
        }

        public static bool IsDetainedLicenseExist(int detainID)
        {
            bool isFound = false;

            string query = @"SELECT 1 FROM DetainedLicenses WHERE DetainID = @DetainID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DetainID", detainID);
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
        
    }
}
