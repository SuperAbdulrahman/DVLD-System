using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class TestTypeDataAccess
    {
        public static bool GetTestType(int testTypeID, ref string testTypeTitle, ref string testTypeDescription, ref decimal testTypeFees)
        {
            bool isFound = false;
            string query = @"SELECT TestTypeID,TestTypeTitle,TestTypeDescription,TestTypeFees FROM TestTypes
                    WHERE TestTypeID = @TestTypeID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestTypeID", testTypeID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            testTypeTitle = reader["TestTypeTitle"] is DBNull ? string.Empty : (string)reader["TestTypeTitle"];
                            testTypeDescription = reader["TestTypeDescription"] is DBNull ? string.Empty : (string)reader["TestTypeDescription"];
                            testTypeFees = reader["TestTypeFees"] is DBNull ? 0m : (decimal)reader["TestTypeFees"];
                            isFound = true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                //log an error
            }
            return isFound;
        }
        public static int AddNewTestType(string testTypeTitle, string testTypeDescription, decimal testTypeFees)
        {
            int TestTypeID = -1;

            string query = @"Insert Into TestTypes (TestTypeTitle,TestTypeDescription,TestTypeFees)
                    Values (@TestTypeTitle,@TestTypeDescription,@TestTypeFees)

                    SELECT SCOPE_IDENTITY();";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestTypeTitle", testTypeTitle);
                    command.Parameters.AddWithValue("@TestTypeDescription", testTypeDescription);
                    command.Parameters.AddWithValue("@TestTypeFees", testTypeFees);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        int.TryParse(result.ToString(), out TestTypeID);
                    }
                }
            }
            catch (Exception)
            {
            }

            return TestTypeID;
        }

        public static bool UpdateTestType(int testTypeID, string testTypeTitle, string testTypeDescription, decimal testTypeFees)
        {
            int rowsAffected = 0;

            string query = @"UPDATE TestTypes SET
                    TestTypeTitle=@TestTypeTitle,
                    TestTypeDescription=@TestTypeDescription,
                    TestTypeFees=@TestTypeFees
                    WHERE TestTypeID=@TestTypeID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestTypeTitle", testTypeTitle);
                    command.Parameters.AddWithValue("@TestTypeDescription", testTypeDescription);
                    command.Parameters.AddWithValue("@TestTypeFees", testTypeFees);
                    command.Parameters.AddWithValue("@TestTypeID", testTypeID);

                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
            }

            return rowsAffected > 0;
        }

        public static DataTable GetTestTypes()
        {
            DataTable dt = new DataTable();

            string query = @"SELECT TestTypeID,TestTypeTitle,TestTypeDescription,TestTypeFees FROM TestTypes;";

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
