using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class TestDataAccess
    {
        public static bool GetTest(int testID, ref int testAppointmentID, ref bool testResult, ref string notes, ref int createdByUserID)
        {
            bool isFound = false;
            string query = @"SELECT * FROM Tests WHERE TestID = @TestID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestID", testID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            testAppointmentID = reader["TestAppointmentID"] is DBNull ? 0 : (int)reader["TestAppointmentID"];
                            testResult = reader["TestResult"] is DBNull ? false : (bool)reader["TestResult"];
                            notes = reader["Notes"] is DBNull ? "" : (string)reader["Notes"];
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

        public static DataTable GetTests()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT * FROM Tests;";

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

        public static int AddNewTest(int testAppointmentID, bool testResult, string notes, int createdByUserID)
        {
            int newTestID = -1;

            string query = @"INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)
                             VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);
                             UPDATE TestAppointments SET IsLocked = 1 WHERE TestAppointmentID = @TestAppointmentID;

                             SELECT SCOPE_IDENTITY();";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
                    command.Parameters.AddWithValue("@TestResult", testResult);

                    if (string.IsNullOrEmpty(notes))
                        command.Parameters.AddWithValue("@Notes", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@Notes", notes);

                    command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null)
                        newTestID = Convert.ToInt32(result);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return newTestID;
        }

        public static bool UpdateTest(int testID, int testAppointmentID, bool testResult, string notes, int createdByUserID)
        {
            int rowsAffected = 0;

            string query = @"UPDATE Tests SET
                             TestAppointmentID = @TestAppointmentID,
                             TestResult = @TestResult,
                             Notes = @Notes,
                             CreatedByUserID = @CreatedByUserID
                             WHERE TestID = @TestID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestID", testID);
                    command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
                    command.Parameters.AddWithValue("@TestResult", testResult);

                    if (string.IsNullOrEmpty(notes))
                        command.Parameters.AddWithValue("@Notes", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@Notes", notes);

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

        public static bool Delete(int testID)
        {
            int rowsAffected = 0;
            string query = @"DELETE FROM Tests WHERE TestID = @TestID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestID", testID);
                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
            }

            return (rowsAffected > 0);
        }

        public static bool IsTestExist(int testID)
        {
            bool isFound = false;
            string query = @"SELECT 1 FROM Tests WHERE TestID = @TestID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestID", testID);
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
