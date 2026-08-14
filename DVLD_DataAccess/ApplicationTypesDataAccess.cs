using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class ApplicationTypesDataAccess
    {
        public static bool GetApplicationType(int applicationTypeID, ref string applicationTypeTitle,ref  decimal applicationFees)
        {

            bool isFound = false;
            string query = @"SELECT ApplicationTypeID,ApplicationTypeTitle,ApplicationFees FROM ApplicationTypes
                            WHERE ApplicationTypeID = @ApplicationTypeID;"; ;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            applicationTypeTitle = reader["ApplicationTypeTitle"] is DBNull ? string.Empty : (string)reader["ApplicationTypeTitle"];
                            applicationFees = reader["ApplicationFees"] is DBNull ? 0m : (decimal)reader["ApplicationFees"];
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

        public static int AddNewApplicationType(string applicationTypeTitle, decimal applicationFees)
        {
            int ApplicationTypeID = -1;

            string query = @"Insert Into ApplicationTypes (ApplicationTypeTitle,ApplicationFees)
                            Values (@ApplicationTypeTitle,@ApplicationFees)
                            
                            SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationTypeTitle", applicationTypeTitle);
                    command.Parameters.AddWithValue("@ApplicationFees", applicationFees);


                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        int.TryParse(result.ToString(), out ApplicationTypeID);
                    }


                }
            }
            catch (Exception)
            {
            }



            return ApplicationTypeID;

        }

        public static bool UpdateApplicationType(int applicationTypeID,string applicationTypeTitle, decimal applicationFees)
        {
            int rowsAffected = 0;
            string query = @"UPDATE ApplicationTypes SET 
                            ApplicationTypeTitle=@ApplicationTypeTitle,ApplicationFees =@ApplicationFees 
                            WHERE ApplicationTypeID =@ApplicationTypeID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationTypeTitle", applicationTypeTitle);
                    command.Parameters.AddWithValue("@ApplicationFees", applicationFees);
                    command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
         

                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();


                }
            }
            catch (Exception)
            {
            }
            return rowsAffected > 0;
        }

        public static DataTable GetApplictionTypes()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT ApplicationTypeID,ApplicationTypeTitle,ApplicationFees FROM ApplicationTypes;";
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
