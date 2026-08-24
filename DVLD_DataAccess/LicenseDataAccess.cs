using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class LicenseDataAccess
    {
        public static bool GetLicenseByLicenseID(int licenseID, ref int applicationID, ref int driverID,
            ref int licenseClass, ref DateTime issueDate, ref DateTime expirationDate,
            ref string notes, ref decimal paidFees, ref bool isActive,
            ref int issueReason, ref int createdByUserID)
        {
            bool isFound = false;

            string query = @"SELECT * FROM Licenses WHERE LicenseID = @LicenseID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", licenseID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            applicationID = reader["ApplicationID"] is DBNull ? 0 : (int)reader["ApplicationID"];
                            driverID = reader["DriverID"] is DBNull ? 0 : (int)reader["DriverID"];
                            licenseClass = reader["LicenseClass"] is DBNull ? 0 : (int)reader["LicenseClass"];
                            issueDate = reader["IssueDate"] is DBNull ? DateTime.MinValue : (DateTime)reader["IssueDate"];
                            expirationDate = reader["ExpirationDate"] is DBNull ? DateTime.MinValue : (DateTime)reader["ExpirationDate"];
                            notes = reader["Notes"] is DBNull ? "" : (string)reader["Notes"];
                            paidFees = reader["PaidFees"] is DBNull ? 0 : (decimal)reader["PaidFees"];
                            isActive = reader["IsActive"] is DBNull ? false : (bool)reader["IsActive"];
                            issueReason = reader["IssueReason"] is DBNull ? 0 : (int)reader["IssueReason"];
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
        public static bool GetLicenseByAppID(ref int licenseID, int applicationID, ref int driverID,
    ref int licenseClass, ref DateTime issueDate, ref DateTime expirationDate,
    ref string notes, ref decimal paidFees, ref bool isActive,
    ref int issueReason, ref int createdByUserID)
        {
            bool isFound = false;

            string query = @"SELECT * FROM Licenses WHERE ApplicationID = @ApplicationID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", applicationID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            licenseID = reader["LicenseID"] is DBNull ? 0 : (int)reader["LicenseID"];
                            driverID = reader["DriverID"] is DBNull ? 0 : (int)reader["DriverID"];
                            licenseClass = reader["LicenseClass"] is DBNull ? 0 : (int)reader["LicenseClass"];
                            issueDate = reader["IssueDate"] is DBNull ? DateTime.MinValue : (DateTime)reader["IssueDate"];
                            expirationDate = reader["ExpirationDate"] is DBNull ? DateTime.MinValue : (DateTime)reader["ExpirationDate"];
                            notes = reader["Notes"] is DBNull ? "" : (string)reader["Notes"];
                            paidFees = reader["PaidFees"] is DBNull ? 0 : (decimal)reader["PaidFees"];
                            isActive = reader["IsActive"] is DBNull ? false : (bool)reader["IsActive"];
                            issueReason = reader["IssueReason"] is DBNull ? 0 : (byte)reader["IssueReason"];
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




        public static int AddNewLicense(int applicationID, int driverID, int licenseClass,
            DateTime issueDate, DateTime expirationDate, string notes,
            decimal paidFees, bool isActive, int issueReason, int createdByUserID)
        {
            int newLicenseID = -1;

            string query = @"INSERT INTO Licenses
                             (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate,
                              Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)
                             VALUES
                             (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate,
                              @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID);

                             SELECT SCOPE_IDENTITY();";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", applicationID);
                    command.Parameters.AddWithValue("@DriverID", driverID);
                    command.Parameters.AddWithValue("@LicenseClass", licenseClass);
                    command.Parameters.AddWithValue("@IssueDate", issueDate);
                    command.Parameters.AddWithValue("@ExpirationDate", expirationDate);

                    if (string.IsNullOrEmpty(notes))
                        command.Parameters.AddWithValue("@Notes", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@Notes", notes);

                    command.Parameters.AddWithValue("@PaidFees", paidFees);
                    command.Parameters.AddWithValue("@IsActive", isActive);
                    command.Parameters.AddWithValue("@IssueReason", issueReason);
                    command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null)
                        newLicenseID = Convert.ToInt32(result);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return newLicenseID;
        }

        public static bool UpdateLicense(int licenseID, int applicationID, int driverID,
            int licenseClass, DateTime issueDate, DateTime expirationDate,
            string notes, decimal paidFees, bool isActive,
            int issueReason, int createdByUserID)
        {
            int rowsAffected = 0;

            string query = @"UPDATE Licenses SET
                             ApplicationID = @ApplicationID,
                             DriverID = @DriverID,
                             LicenseClass = @LicenseClass,
                             IssueDate = @IssueDate,
                             ExpirationDate = @ExpirationDate,
                             Notes = @Notes,
                             PaidFees = @PaidFees,
                             IsActive = @IsActive,
                             IssueReason = @IssueReason,
                             CreatedByUserID = @CreatedByUserID
                             WHERE LicenseID = @LicenseID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", licenseID);
                    command.Parameters.AddWithValue("@ApplicationID", applicationID);
                    command.Parameters.AddWithValue("@DriverID", driverID);
                    command.Parameters.AddWithValue("@LicenseClass", licenseClass);
                    command.Parameters.AddWithValue("@IssueDate", issueDate);
                    command.Parameters.AddWithValue("@ExpirationDate", expirationDate);

                    if (string.IsNullOrEmpty(notes))
                        command.Parameters.AddWithValue("@Notes", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@Notes", notes);

                    command.Parameters.AddWithValue("@PaidFees", paidFees);
                    command.Parameters.AddWithValue("@IsActive", isActive);
                    command.Parameters.AddWithValue("@IssueReason", issueReason);
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

        public static bool Delete(int licenseID)
        {
            int rowsAffected = 0;

            string query = @"DELETE FROM Licenses WHERE LicenseID = @LicenseID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", licenseID);
                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
            }

            return (rowsAffected > 0);
        }

        public static bool IsLicenseExist(int licenseID)
        {
            bool isFound = false;

            string query = @"SELECT 1 FROM Licenses WHERE LicenseID = @LicenseID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", licenseID);
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

        public static int GetActiveLicenseIDByPersonID(int personID, int licenseClassID)
        {
            int activeLicenseID = -1;

            string query = @"SELECT TOP 1 Licenses.LicenseID
                            FROM Licenses
                            INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID
                            WHERE Drivers.PersonID = @PersonID
                              AND Licenses.LicenseClass = @LicenseClassID
                              AND Licenses.IsActive = 1
                            ORDER BY Licenses.LicenseID DESC;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", personID);
                    command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        activeLicenseID = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }

            return activeLicenseID;
        }

        public static bool IsLicenseDetained(int licenseID)
        {
            bool isDetained = false;

            string query = @"SELECT 1 FROM DetainedLicenses WHERE LicenseID = @LicenseID
                            AND IsReleased = 0 ;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", licenseID);
                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null)
                        isDetained = true;
                }
            }
            catch (Exception)
            {
            }

            return isDetained;
        }
        public static DataTable GetLicenses()
        {
            DataTable dt = new DataTable();

            string query = @"SELECT * FROM Licenses;";

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
        public static DataTable GetLicensesHistoryForDriver(int driverID)
        {
            DataTable dt = new DataTable();

            string query = @"SELECT l.LicenseID, l.ApplicationID, lc.ClassName, l.IssueDate, l.ExpirationDate, l.IsActive
                 FROM Licenses AS l
                 JOIN LicenseClasses AS lc
                 ON l.LicenseClass = lc.LicenseClassID
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
    }
}
