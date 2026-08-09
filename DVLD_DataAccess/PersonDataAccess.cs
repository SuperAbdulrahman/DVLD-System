using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security.Policy;

namespace DVLD_DataAccess
{
    public class PersonDataAccess
    {
        public static bool GetPerson(int personID, ref string nationalNo, ref string firstName, ref string secondName, ref string thirdName, ref string lastName,
ref DateTime DOB, ref bool gender, ref string address, ref string phone, ref string email, ref int nationalityCountryID, ref string imagePath)
        {
            bool isFound = false;
            string query = @"SELECT * FROM People WHERE PersonID = @PersonID;";

            try
            {
                // Note: Make sure to pass your connection string to the SqlConnection constructor
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", personID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            nationalNo = reader["NationalNo"] is DBNull ? string.Empty : (string)reader["NationalNo"];
                            firstName = reader["FirstName"] is DBNull ? string.Empty : (string)reader["FirstName"];
                            secondName = reader["SecondName"] is DBNull ? string.Empty : (string)reader["SecondName"];
                            thirdName = reader["ThirdName"] is DBNull ? string.Empty : (string)reader["ThirdName"];
                            lastName = reader["LastName"] is DBNull ? string.Empty : (string)reader["LastName"];
                            DOB = reader["DateOfBirth"] is DBNull ? DateTime.MinValue : (DateTime)reader["DateOfBirth"];
                            gender = reader["Gendor"] is DBNull ? false : (byte)reader["Gendor"] == 1;
                            nationalityCountryID = reader["NationalityCountryID"] is DBNull ? 0 : (int)reader["NationalityCountryID"];
                            address = reader["Address"] is DBNull ? string.Empty : (string)reader["Address"];
                            phone = reader["Phone"] is DBNull ? string.Empty : (string)reader["Phone"];
                            email = reader["Email"] is DBNull ? string.Empty : (string)reader["Email"];
                            imagePath = reader["ImagePath"] is DBNull ? string.Empty : (string)reader["ImagePath"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return isFound;
            }

            return isFound;
        }
        public static bool GetPerson(ref int personID, string nationalNo, ref string firstName, ref string secondName, ref string thirdName, ref string lastName,
ref DateTime DOB, ref bool gender, ref string address, ref string phone, ref string email, ref int nationalityCountryID, ref string imagePath)
        {
            bool isFound = false;
            string query = @"SELECT * FROM People WHERE NationalNo = @NationalNo;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalNo", nationalNo);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            personID = reader["PersonID"] is DBNull ? 0 : (int)reader["PersonID"];
                            firstName = reader["FirstName"] is DBNull ? string.Empty : (string)reader["FirstName"];
                            secondName = reader["SecondName"] is DBNull ? string.Empty : (string)reader["SecondName"];
                            thirdName = reader["ThirdName"] is DBNull ? string.Empty : (string)reader["ThirdName"];
                            lastName = reader["LastName"] is DBNull ? string.Empty : (string)reader["LastName"];
                            DOB = reader["DateOfBirth"] is DBNull ? DateTime.MinValue : (DateTime)reader["DateOfBirth"];
                            gender = reader["Gendor"] is DBNull ? false : (byte)reader["Gendor"] == 1;
                            nationalityCountryID = reader["NationalityCountryID"] is DBNull ? 0 : (int)reader["NationalityCountryID"];
                            address = reader["Address"] is DBNull ? string.Empty : (string)reader["Address"];
                            phone = reader["Phone"] is DBNull ? string.Empty : (string)reader["Phone"];
                            email = reader["Email"] is DBNull ? string.Empty : (string)reader["Email"];
                            imagePath = reader["ImagePath"] is DBNull ? string.Empty : (string)reader["ImagePath"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }

            return isFound;
        }


        public static bool IsPersonExist(int personID)
        {
            bool isFound = false;
            string query = @"SELECT 1 FROM People WHERE PersonID = @PersonID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", personID);
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

        public static bool IsPersonExist(string nationalNo)
        {
            bool isFound = false;
            string query = @"SELECT 1 FROM People WHERE NationalNo = @NationalNo;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalNo", nationalNo);
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
        public static int AddNewPerson(string nationalNo, string firstName, string secondName, string thirdName, string lastName,
DateTime DOB, bool gender, string address, string phone, string email, int nationalityCountryID, string imagePath)
        {
            int newPersonID = -1;
            string query = @"INSERT INTO People (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath)
                 VALUES (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gendor, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath);
                 SELECT SCOPE_IDENTITY(); ";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@NationalNo", nationalNo);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@SecondName", secondName);
                    command.Parameters.AddWithValue("@ThirdName", ((object)thirdName ?? DBNull.Value)); 
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@DateOfBirth", DOB);
                    command.Parameters.AddWithValue("@Gendor", (byte)(gender ? 1 : 0)); 
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Email", ((object)email ?? DBNull.Value));
                    command.Parameters.AddWithValue("@NationalityCountryID", (nationalityCountryID <= 193 & nationalityCountryID>0?nationalityCountryID:191));
                    command.Parameters.AddWithValue("@ImagePath", ((object)imagePath ?? DBNull.Value));
                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        newPersonID =Convert.ToInt32(result);
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return newPersonID;

        }

        public static bool UpdatePersonInfo(int personID,string nationalNo, string firstName, string secondName, string thirdName, string lastName,
DateTime DOB, bool gender, string address, string phone, string email, int nationalityCountryID, string imagePath)
        {
            int rowsAffected = 0;
            string query = @"UPDATE People SET 
                            NationalNo = @NationalNo, FirstName = @FirstName, SecondName = @SecondName, ThirdName = @ThirdName, 
                            LastName = @LastName, DateOfBirth = @DateOfBirth, Gendor = @Gendor, Address = @Address, Phone = @Phone,
                            Email = @Email, NationalityCountryID = @NationalityCountryID, ImagePath = @ImagePath WHERE PersonID = @PersonID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", personID);
                    command.Parameters.AddWithValue("@NationalNo", nationalNo);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@SecondName", secondName);
                    command.Parameters.AddWithValue("@ThirdName", ((object)thirdName ?? DBNull.Value));
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@DateOfBirth", DOB);
                    command.Parameters.AddWithValue("@Gendor", (byte)(gender ? 1 : 0));
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Email", ((object)email ?? DBNull.Value));
                    command.Parameters.AddWithValue("@NationalityCountryID", (nationalityCountryID <= 193 & nationalityCountryID > 0 ? nationalityCountryID : 191));
                    command.Parameters.AddWithValue("@ImagePath", ((object)imagePath ?? DBNull.Value));

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
        
        public static DataTable GetAllPeople()
        {
            DataTable dataTable = new DataTable();
            string query = @"SELECT * FROM People;";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()) 
                    {
                        dataTable.Load(reader);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            return dataTable;
        }
        public static DataTable GetAllPeopleWithCountryName()
        {
            DataTable dataTable = new DataTable();
            string query = @"SELECT * FROM ManagePeople_View;";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            return dataTable;
        }
        public static bool DeletePerson(int personID)
        {
            int rowsAffected = 0;
            string query = @"DELETE FROM People WHERE PersonID = @PersonID;";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", personID);
                    connection.Open();
                    
                    rowsAffected = command.ExecuteNonQuery();

                }

            }
            catch (Exception e)
            {

            }
            return rowsAffected > 0;
        }


    }
    

}
