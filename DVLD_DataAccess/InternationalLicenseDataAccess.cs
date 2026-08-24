using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class InternationalLicenseDataAccess
    {
        public static bool GetInternationalLicenseByInternationalLicenseID(int internationalLicenseID,
          ref int applicationID, ref int driverID, ref int issuedUsingLocalLicenseID,
          ref DateTime issueDate, ref DateTime expirationDate,
          ref bool isActive, ref int createdByUserID)
        {
            bool isFound = false;

            string query = @"SELECT * FROM InternationalLicenses 
                             WHERE InternationalLicenseID = @InternationalLicenseID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@InternationalLicenseID", internationalLicenseID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            applicationID = reader["ApplicationID"] is DBNull ? 0 : (int)reader["ApplicationID"];
                            driverID = reader["DriverID"] is DBNull ? 0 : (int)reader["DriverID"];
                            issuedUsingLocalLicenseID = reader["IssuedUsingLocalLicenseID"] is DBNull ? 0 : (int)reader["IssuedUsingLocalLicenseID"];
                            issueDate = reader["IssueDate"] is DBNull ? DateTime.MinValue : (DateTime)reader["IssueDate"];
                            expirationDate = reader["ExpirationDate"] is DBNull ? DateTime.MinValue : (DateTime)reader["ExpirationDate"];
                            isActive = reader["IsActive"] is DBNull ? false : (bool)reader["IsActive"];
                            createdByUserID = reader["CreatedByUserID"] is DBNull ? 0 : (int)reader["CreatedByUserID"];

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
        public static DataTable GetInternationalLicensesByDriverID(int driverID)
        {
            DataTable dt = new DataTable();

            string query = @"SELECT i.InternationalLicenseID,i.ApplicationID,i.IssuedUsingLocalLicenseID,
                            i.IssueDate,i.ExpirationDate,i.IsActive FROM InternationalLicenses as i
                             WHERE DriverID = @DriverID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DriverID", driverID);
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

        public static DataTable GetInternationalLicenses()
        {
            DataTable dt = new DataTable();

            string query = @"SELECT * FROM InternationalLicenses;";

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


        public static int AddNewInternationalLicense(int applicationID, int driverID,
            int issuedUsingLocalLicenseID, DateTime issueDate, DateTime expirationDate,
            bool isActive, int createdByUserID)
        {
            int newInternationalLicenseID = -1;

            string query = @"INSERT INTO InternationalLicenses
                             (ApplicationID, DriverID, IssuedUsingLocalLicenseID,
                              IssueDate, ExpirationDate, IsActive, CreatedByUserID)
                             VALUES
                             (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID,
                              @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID);

                             SELECT SCOPE_IDENTITY();";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", applicationID);
                    command.Parameters.AddWithValue("@DriverID", driverID);
                    command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", issuedUsingLocalLicenseID);
                    command.Parameters.AddWithValue("@IssueDate", issueDate);
                    command.Parameters.AddWithValue("@ExpirationDate", expirationDate);
                    command.Parameters.AddWithValue("@IsActive", isActive);
                    command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null)
                        newInternationalLicenseID = Convert.ToInt32(result);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return newInternationalLicenseID;
        }

        public static bool UpdateInternationalLicense(int internationalLicenseID,
            int applicationID, int driverID, int issuedUsingLocalLicenseID,
            DateTime expirationDate, bool isActive, int createdByUserID)
        {
            int rowsAffected = 0;

            string query = @"UPDATE InternationalLicenses SET
                             ApplicationID = @ApplicationID,
                             DriverID = @DriverID,
                             IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID,
                             ExpirationDate = @ExpirationDate,
                             IsActive = @IsActive,
                             CreatedByUserID = @CreatedByUserID
                             WHERE InternationalLicenseID = @InternationalLicenseID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@InternationalLicenseID", internationalLicenseID);
                    command.Parameters.AddWithValue("@ApplicationID", applicationID);
                    command.Parameters.AddWithValue("@DriverID", driverID);
                    command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", issuedUsingLocalLicenseID);
                    command.Parameters.AddWithValue("@ExpirationDate", expirationDate);
                    command.Parameters.AddWithValue("@IsActive", isActive);
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

        public static bool Delete(int internationalLicenseID)
        {
            int rowsAffected = 0;

            string query = @"DELETE FROM InternationalLicenses 
                             WHERE InternationalLicenseID = @InternationalLicenseID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@InternationalLicenseID", internationalLicenseID);
                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
            }

            return (rowsAffected > 0);
        }

        public static bool IsInternationalLicenseExist(int internationalLicenseID)
        {
            bool isFound = false;

            string query = @"SELECT 1 FROM InternationalLicenses 
                             WHERE InternationalLicenseID = @InternationalLicenseID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@InternationalLicenseID", internationalLicenseID);
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

