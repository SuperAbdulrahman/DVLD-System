using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_DataAccess
{
    public static class ApplicationDataAccess
    {
        public static bool GetApplication(int ID, ref int applicantPersonID, ref DateTime applicationDate, ref int applicationTypeID,
            ref byte applicationStatus, ref DateTime lastStatusDate, ref decimal paidFees, ref int createdByUserID)
        {
            bool isFound = false;
            string query = @"SELECT * FROM Applications WHERE ApplicationID = @ApplicationID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", ID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            applicantPersonID = reader["ApplicantPersonID"] is DBNull ? 0 : (int)reader["ApplicantPersonID"];
                            applicationDate = reader["ApplicationDate"] is DBNull ? DateTime.MinValue : (DateTime)reader["ApplicationDate"];
                            applicationTypeID = reader["ApplicationTypeID"] is DBNull ? 0 : (int)reader["ApplicationTypeID"];
                            applicationStatus = reader["ApplicationStatus"] is DBNull ? (byte)0 : (byte)reader["ApplicationStatus"];
                            lastStatusDate = reader["LastStatusDate"] is DBNull ? DateTime.MinValue : (DateTime)reader["LastStatusDate"];
                            paidFees = reader["PaidFees"] is DBNull ? 0m : (decimal)reader["PaidFees"];
                            createdByUserID = reader["CreatedByUserID"] is DBNull ? 0 : (int)reader["CreatedByUserID"];

                            isFound = true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                // log an error
            }

            return isFound;
        }
        public static int AddNewApplication(int applicantPersonID, DateTime applicationDate, int applicationTypeID, short applicationStatus, DateTime lastStatusDate, decimal paidFees, int createdByUserID)
        {
            int newApplicationID = -1;

            string query = @"INSERT INTO Applications (ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
                     VALUES (@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID);
                     SELECT SCOPE_IDENTITY();";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicantPersonID", applicantPersonID);
                    command.Parameters.AddWithValue("@ApplicationDate", applicationDate);
                    command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
                    command.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
                    command.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
                    command.Parameters.AddWithValue("@PaidFees", paidFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        newApplicationID = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return newApplicationID;
        }
        public static bool UpdateApplicationInfo(int applicationID, int applicantPersonID, DateTime applicationDate, int applicationTypeID, short applicationStatus, DateTime lastStatusDate, decimal paidFees, int createdByUserID)
        {
            int rowsAffected = 0;

            string query = @"UPDATE Applications SET
                     ApplicantPersonID = @ApplicantPersonID,
                     ApplicationDate = @ApplicationDate,
                     ApplicationTypeID = @ApplicationTypeID,
                     ApplicationStatus = @ApplicationStatus,
                     LastStatusDate = @LastStatusDate,
                     PaidFees = @PaidFees,
                     CreatedByUserID = @CreatedByUserID
                     WHERE ApplicationID = @ApplicationID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", applicationID);
                    command.Parameters.AddWithValue("@ApplicantPersonID", applicantPersonID);
                    command.Parameters.AddWithValue("@ApplicationDate", applicationDate);
                    command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
                    command.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
                    command.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
                    command.Parameters.AddWithValue("@PaidFees", paidFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                return false;
            }

            return (rowsAffected > 0);
        }
        public static bool UpdateStatus(int applicationID, short applicationStatus)
        {
            int rowsAffected = 0;

            string query = @"UPDATE Applications SET
                     ApplicationStatus = @NewStatus,
                     LastStatusDate =@LastStatusDate
                     WHERE ApplicationID = @ApplicationID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", applicationID);
                    command.Parameters.AddWithValue("@NewStatus", applicationStatus);
                    command.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);


                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                return false;
            }

            return (rowsAffected > 0);
        }
        public static bool Delete(int applicationID)
        {
            int rowsAffected = 0;
            string query = @"DELETE FROM Applications WHERE ApplicationID = @ApplicationID";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", applicationID);
                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();

                }
            }
            catch (Exception)
            {

            }

            return (rowsAffected > 0);
        }
        public static bool IsApplicationExist(int applicationID)
        {
            bool IsFound = false;
            string query = @"SELECT 1 FROM Applications WHERE ApplicationID = @ApplicationID;";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", applicationID);
                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != null)
                        IsFound = true;


                }
            }
            catch (Exception)
            {
            }
            return IsFound;

        }
        public static bool DoesPersonHaveActiveApplication(int PersonID, int ApplicationTypeID)
        {

            //incase the ActiveApplication ID !=-1 return true.
            return (GetActiveApplicationID(PersonID, ApplicationTypeID) != -1);
        }
        public static int GetActiveApplicationID(int personID, int applicationTypeID)
        {
            int activeApplicationID = -1;
            string query = @"SELECT ApplicationID FROM Applications 
                     WHERE ApplicantPersonID = @ApplicantPersonID 
                       AND ApplicationTypeID = @ApplicationTypeID 
                       AND ApplicationStatus = 1;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicantPersonID", personID);
                    command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int appID))
                    {
                        activeApplicationID = appID;
                    }
                }
            }
            catch (Exception)
            {
                return -1;
            }

            return activeApplicationID;
        }

        public static int GetActiveApplicationIDForLicenseClass(int personID, int applicationTypeID, int licenseClassID)
        {
            int activeApplicationID = -1;
            string query = @"SELECT A.ApplicationID 
                     FROM Applications A
                     INNER JOIN LocalDrivingLicenseApplications L 
                         ON A.ApplicationID = L.ApplicationID
                     WHERE A.ApplicantPersonID = @ApplicantPersonID 
                       AND A.ApplicationTypeID = @ApplicationTypeID 
                       AND L.LicenseClassID = @LicenseClassID
                       AND A.ApplicationStatus = 1;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicantPersonID", personID);
                    command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
                    command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int appID))
                    {
                        activeApplicationID = appID;
                    }
                }
            }
            catch (Exception)
            {
            }

            return activeApplicationID;
        }
     
        public static DataTable GetApplications()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT * FROM Applications;";
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

    }
}
