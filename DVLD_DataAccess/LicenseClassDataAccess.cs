using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class LicenseClassDataAccess
    {
        public static bool GetLicenseClass(int ID, ref string className, ref string classDescription, ref byte minimumAllowedAge, ref byte defaultValidityLength, ref decimal classFees)
        {
            bool isFound = false;

            string query = @"SELECT * FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseClassID", ID);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            className = reader["ClassName"] is DBNull ? string.Empty : (string)reader["ClassName"];
                            classDescription = reader["ClassDescription"] is DBNull ? string.Empty : (string)reader["ClassDescription"];
                            minimumAllowedAge = reader["MinimumAllowedAge"] is DBNull ? (byte)0 : (byte)reader["MinimumAllowedAge"];
                            defaultValidityLength = reader["DefaultValidityLength"] is DBNull ? (byte)0 : (byte)reader["DefaultValidityLength"];
                            classFees = reader["ClassFees"] is DBNull ? 0m : (decimal)reader["ClassFees"];

                            isFound = true;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return isFound;
        }
        public static int AddNewLicenseClass(string className, string classDescription, byte minimumAllowedAge, byte defaultValidityLength, decimal classFees)
        {
            int newLicenseClassID = -1;

            string query = @"INSERT INTO LicenseClasses (ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees)
                     VALUES (@ClassName, @ClassDescription, @MinimumAllowedAge, @DefaultValidityLength, @ClassFees);
                     SELECT SCOPE_IDENTITY();";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClassName", className);
                    command.Parameters.AddWithValue("@ClassDescription", classDescription);
                    command.Parameters.AddWithValue("@MinimumAllowedAge", minimumAllowedAge);
                    command.Parameters.AddWithValue("@DefaultValidityLength", defaultValidityLength);
                    command.Parameters.AddWithValue("@ClassFees", classFees);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        newLicenseClassID = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return newLicenseClassID;
        }
        public static bool UpdateLicenseClass(int licenseClassID, string className, string classDescription, byte minimumAllowedAge, byte defaultValidityLength, decimal classFees)
        {
            int rowsAffected = 0;

            string query = @"UPDATE LicenseClasses SET
                     ClassName = @ClassName,
                     ClassDescription = @ClassDescription,
                     MinimumAllowedAge = @MinimumAllowedAge,
                     DefaultValidityLength = @DefaultValidityLength,
                     ClassFees = @ClassFees
                     WHERE LicenseClassID = @LicenseClassID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);
                    command.Parameters.AddWithValue("@ClassName", className);
                    command.Parameters.AddWithValue("@ClassDescription", classDescription);
                    command.Parameters.AddWithValue("@MinimumAllowedAge", minimumAllowedAge);
                    command.Parameters.AddWithValue("@DefaultValidityLength", defaultValidityLength);
                    command.Parameters.AddWithValue("@ClassFees", classFees);

                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return (rowsAffected > 0);
        }
        
        public static DataTable GetLicenseClasses()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT * FROM LicenseClasses;";
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
