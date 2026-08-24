using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class TestAppointmentDataAccess
    {
        public static bool GetTestAppointment(int testAppointmentID, ref int testTypeID, ref int localDrivingLicenseApplicationID, ref DateTime appointmentDate, ref decimal paidFees, ref int createdByUserID, ref bool isLocked, ref int retakeTestApplicationID)
        {
            bool isFound = false;
            string query = @"SELECT * FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            testTypeID = reader["TestTypeID"] is DBNull ? 0 : (int)reader["TestTypeID"];
                            localDrivingLicenseApplicationID = reader["LocalDrivingLicenseApplicationID"] is DBNull ? 0 : (int)reader["LocalDrivingLicenseApplicationID"];
                            appointmentDate = reader["AppointmentDate"] is DBNull ? DateTime.MinValue : (DateTime)reader["AppointmentDate"];
                            paidFees = reader["PaidFees"] is DBNull ? 0m : (decimal)reader["PaidFees"];
                            createdByUserID = reader["CreatedByUserID"] is DBNull ? 0 : (int)reader["CreatedByUserID"];
                            isLocked = reader["IsLocked"] is DBNull ? false : (bool)reader["IsLocked"];
                            retakeTestApplicationID = reader["RetakeTestApplicationID"] is DBNull ? -1 : (int)reader["RetakeTestApplicationID"];

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
     

        public static int AddNewTestAppointment(int testTypeID, int localDrivingLicenseApplicationID, DateTime appointmentDate, decimal paidFees, int createdByUserID, bool isLocked, int retakeTestApplicationID)
        {
            int newTestAppointmentID = -1;

            string query = @"INSERT INTO TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID)
                             VALUES (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked, @RetakeTestApplicationID);
                             SELECT SCOPE_IDENTITY();";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestTypeID", testTypeID);
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
                    command.Parameters.AddWithValue("@PaidFees", paidFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
                    command.Parameters.AddWithValue("@IsLocked", isLocked);

                    if (retakeTestApplicationID == -1)
                        command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@RetakeTestApplicationID", retakeTestApplicationID);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null)
                        newTestAppointmentID = Convert.ToInt32(result);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return newTestAppointmentID;
        }

        public static bool UpdateTestAppointment(int testAppointmentID, int testTypeID, int localDrivingLicenseApplicationID, DateTime appointmentDate, decimal paidFees, int createdByUserID, bool isLocked, int retakeTestApplicationID)
        {
            int rowsAffected = 0;

            string query = @"UPDATE TestAppointments SET
                             TestTypeID = @TestTypeID,
                             LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID,
                             AppointmentDate = @AppointmentDate,
                             PaidFees = @PaidFees,
                             CreatedByUserID = @CreatedByUserID,
                             IsLocked = @IsLocked,
                             RetakeTestApplicationID = @RetakeTestApplicationID
                             WHERE TestAppointmentID = @TestAppointmentID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
                    command.Parameters.AddWithValue("@TestTypeID", testTypeID);
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
                    command.Parameters.AddWithValue("@PaidFees", paidFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
                    command.Parameters.AddWithValue("@IsLocked", isLocked);

                    if (retakeTestApplicationID == -1)
                        command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@RetakeTestApplicationID", retakeTestApplicationID);

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

        public static bool Delete(int testAppointmentID)
        {
            int rowsAffected = 0;
            string query = @"DELETE FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
            }

            return (rowsAffected > 0);
        }

        public static bool IsTestAppointmentExist(int testAppointmentID)
        {
            bool isFound = false;
            string query = @"SELECT 1 FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
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

        public static bool IsTestAppointmentLocked(int testAppointmentID)
        {
            bool isLocked = false;
            string query = @"SELECT IsLocked FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                        isLocked = Convert.ToBoolean(result);
                }
            }
            catch (Exception)
            {
            }

            return isLocked;
        }

        public static int GetActiveTestAppointmentID(int localDrivingLicenseApplicationID, int testTypeID)
        {
            int activeTestAppointmentID = -1;
            string query = @"SELECT TestAppointmentID FROM TestAppointments WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestTypeID = @TestTypeID AND IsLocked = 0;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@TestTypeID", testTypeID);
                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int appointmentID))
                        activeTestAppointmentID = appointmentID;
                }
            }
            catch (Exception)
            {
                return -1;
            }

            return activeTestAppointmentID;
        }
        public static DataTable GetTestAppointments()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT * FROM TestAppointments_View;";

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
        public static DataTable GetTestAppointmentsByLDLAppIDAndTestType(int localDrivingLicenseApplicationID, int testTypeID)
        {
            DataTable dt = new DataTable();

            string query = @"SELECT TestAppointmentID, AppointmentDate, PaidFees, IsLocked
                     FROM TestAppointments
                     WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                       AND TestTypeID = @TestTypeID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@TestTypeID", testTypeID);

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
