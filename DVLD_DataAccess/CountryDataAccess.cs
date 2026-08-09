using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public static class CountryDataAccess
    {
        public static bool Find (int CountryID,ref string CountryName)
        {
            bool isFound = false;
            string query = @"SELECT * FROM Countries WHERE CountryID = @CountryID";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CountryID", CountryID);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            CountryName = reader["CountryName"] is DBNull ? string.Empty : reader["CountryName"].ToString();
                            isFound = true;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
            }
            return isFound;
        }
        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT * FROM Countries;";

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
        public static DataTable GetAllCountriesNames()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT CountryName FROM Countries;";

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
