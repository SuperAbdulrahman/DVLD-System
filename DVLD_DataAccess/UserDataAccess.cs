using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public static class UserDataAccess
    {
        public static bool GetUser(int userID, ref int personID, ref string userName, ref string password, ref bool isActive)
        {
            bool isFound = false;
            string query = @"SELECT * FROM Users WHERE UserID = @UserID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            personID = reader["PersonID"] is DBNull ? 0 : (int)reader["PersonID"];
                            userName = reader["UserName"] is DBNull ? string.Empty : (string)reader["UserName"];
                            password = reader["Password"] is DBNull ? string.Empty : (string)reader["Password"];
                            isActive = reader["IsActive"] is DBNull ? false : (bool)reader["IsActive"];
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
        public static bool GetUser(ref int userID, ref int personID, string userName, ref string password, ref bool isActive)

        {
            bool isFound = false;
            string query = @"SELECT * FROM Users WHERE UserName COLLATE Latin1_General_CS_AS = @UserName;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", userName);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userID = reader["UserID"] is DBNull ? 0 : (int)reader["UserID"];
                            personID = reader["PersonID"] is DBNull ? 0 : (int)reader["PersonID"];
                            password = reader["Password"] is DBNull ? string.Empty : (string)reader["Password"];
                            isActive = reader["IsActive"] is DBNull ? false : (bool)reader["IsActive"];
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
        public static bool Delete(int userID)
        {
            int rowsAffected = 0;
            string query = @"DELETE FROM Users WHERE UserID = @UserID";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();

                }
            }
            catch (Exception)
            {

            }

            return (rowsAffected > 0);
        }
        public static int AddNewUser(int personID, string userName, string password, bool isActive)
        {
            int newID = -1;
            string query = @"INSERT INTO Users(PersonID,UserName,Password,IsActive)
                           Values(@PersonID,@UserName,@Password,@IsActive);
                           SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", personID);
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@IsActive", isActive);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        int.TryParse(result.ToString(), out newID);
                    }

                }
            }
            catch (Exception)
            {
            }
            return newID;
        }
        public static bool UpdateUserInfo(int userID, int personID, string userName, string password, bool isActive)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Users SET 
                            PersonID=@PersonID, UserName = @UserName, Password = @Password,IsActive = @IsActive
                            WHERE UserID = @UserID";
                            
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@PersonID", personID);
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@IsActive", isActive);

                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                    

                }
            }
            catch (Exception)
            {
            }
            return rowsAffected > 0;
        }
        public static bool IsUserExist(int userID)
        {
            bool IsFound = false;
            string query = @"SELECT 1 FROM Users WHERE UserID = @UserID;";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
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
        public static bool IsUserExist(string userName)
        {
            bool IsFound = false;
            string query = @"SELECT 1 FROM Users WHERE UserName = @UserName;";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("UserName",userName);
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
        public static DataTable GetUsers()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT * FROM Users_View;";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read())
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
