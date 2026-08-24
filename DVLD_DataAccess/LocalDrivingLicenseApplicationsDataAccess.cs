using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class LocalDrivingLicenseApplicationsDataAccess
    {
        public static bool GetLocalDrivingLicenseApplicationByID(int localDrivingLicenseApplicationID, ref int applicationID, ref int licenseClassID)
        {
            bool isFound = false;
            string query = @"SELECT * FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            applicationID = reader["ApplicationID"] is DBNull ? 0 : (int)reader["ApplicationID"];
                            licenseClassID = reader["LicenseClassID"] is DBNull ? 0 : (int)reader["LicenseClassID"];

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

        public static bool GetLocalDrivingLicenseApplicationByApplicationID(int applicationID, ref int localDrivingLicenseApplicationID, ref int licenseClassID)
        {
            bool isFound = false;
            string query = @"SELECT * FROM LocalDrivingLicenseApplications WHERE ApplicationID = @ApplicationID;";

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
                            localDrivingLicenseApplicationID = reader["LocalDrivingLicenseApplicationID"] is DBNull ? 0 : (int)reader["LocalDrivingLicenseApplicationID"];
                            licenseClassID = reader["LicenseClassID"] is DBNull ? 0 : (int)reader["LicenseClassID"];

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

        public static DataTable GetAllLocalDrivingLicensApplications()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT * FROM LocalDrivingLicenseApplications_View;";

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

        public static int AddNewLocalDrivingLicenseApplication(int applicationID, int licenseClassID)
        {
            int newLocalDrivingLicenseApplicationID = -1;

            string query = @"INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID) 
                     VALUES (@ApplicationID, @LicenseClassID); 
                     SELECT SCOPE_IDENTITY();";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", applicationID);
                    command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        newLocalDrivingLicenseApplicationID = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return newLocalDrivingLicenseApplicationID;
        }

        public static bool UpdateLocalDrivingLicenseApplication(int localDrivingLicenseApplicationID, int applicationID, int licenseClassID)
        {
            int rowsAffected = 0;

            string query = @"UPDATE LocalDrivingLicenseApplications SET 
                     ApplicationID = @ApplicationID, 
                     LicenseClassID = @LicenseClassID 
                     WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@ApplicationID", applicationID);
                    command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);

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
        // This method for checking if the current user got an acitve appliction for the same licenseclass 
        public static int GetActiveLocalDrivingLicenseApplicationID(int personID, int licenseClassID)
        {
            int currentActiveIDforLicenseClass = -1;

            string query = @"SELECT TOP 1 l.LocalDrivingLicenseApplicationID
                     FROM LocalDrivingLicenseApplications AS l
                     INNER JOIN Applications AS a ON l.ApplicationID = a.ApplicationID
                     WHERE a.ApplicantPersonID = @PersonID
                     AND l.LicenseClassID = @LicenseClassID
                     AND a.ApplicationStatus = 1
                     ORDER BY l.LocalDrivingLicenseApplicationID DESC;";

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
                        currentActiveIDforLicenseClass = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }

            return currentActiveIDforLicenseClass;
        }
        //this method counts the number of passed tests 
        public static byte TotalPassedTests(int LocalDrivingLicenseApplicationID)
        {
            byte TotalPassedTests = 0;

            string query = @"SELECT COUNT(*) AS PassedTests 
                     FROM LocalDrivingLicenseApplications AS a
                     INNER JOIN TestAppointments AS ta 
                         ON a.LocalDrivingLicenseApplicationID = ta.LocalDrivingLicenseApplicationID
                     INNER JOIN Tests AS t 
                         ON ta.TestAppointmentID = t.TestAppointmentID
                     WHERE a.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                     AND t.TestResult = 1;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && byte.TryParse(result.ToString(), out byte PassedTests))
                    {
                        TotalPassedTests = PassedTests;
                    }
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }

            return TotalPassedTests;
        }

        // Some stuff :
        public static bool DoesPassTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool Result = false;

            string query = @"SELECT top 1 TestResult 
                     FROM LocalDrivingLicenseApplications INNER JOIN 
                          TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN 
                          Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID 
                     WHERE 
                     (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)  
                     AND(TestAppointments.TestTypeID = @TestTypeID) 
                     ORDER BY TestAppointments.TestAppointmentID desc";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && bool.TryParse(result.ToString(), out bool returnedResult))
                    {
                        Result = returnedResult;
                    }
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }

            return Result;
        }

        public static bool DoesAttendTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool IsFound = false;

            string query = @"SELECT top 1 Found=1 
                     FROM LocalDrivingLicenseApplications INNER JOIN 
                          TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN 
                          Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID 
                     WHERE 
                     (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)  
                     AND(TestAppointments.TestTypeID = @TestTypeID) 
                     ORDER BY TestAppointments.TestAppointmentID desc";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        IsFound = true;
                    }
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }

            return IsFound;
        }

        public static byte TotalTrialsPerTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            byte TotalTrialsPerTest = 0;

            string query = @"SELECT TotalTrialsPerTest = count(TestID) 
                     FROM LocalDrivingLicenseApplications INNER JOIN 
                          TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN 
                          Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID 
                     WHERE 
                     (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)  
                     AND(TestAppointments.TestTypeID = @TestTypeID)";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && byte.TryParse(result.ToString(), out byte Trials))
                    {
                        TotalTrialsPerTest = Trials;
                    }
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }

            return TotalTrialsPerTest;
        }

        public static bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool Result = false;

            string query = @"SELECT top 1 Found=1 
                     FROM LocalDrivingLicenseApplications INNER JOIN 
                          TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID  
                     WHERE 
                     (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)   
                     AND(TestAppointments.TestTypeID = @TestTypeID) and isLocked=0 
                     ORDER BY TestAppointments.TestAppointmentID desc";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        Result = true;
                    }
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }

            return Result;
        }
    }
}
