using DVLD_Business;
using DVLD_DataAccess;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace DVLD_ConsoleTest
{
    internal class Program
    {
        public static void FindPersonByID(int personID)
        {
            Person person = Person.Find(personID);
            if (person != null)
                PrintPersonCard(person);
            else
                Console.WriteLine("Person not found!");

        }
        public static void FindPersonByNationalID(string nationalId)
        {
            Person person = Person.Find(nationalId);
            if (person != null)
                PrintPersonCard(person);
            else
                Console.WriteLine("Person not found!");

        }
        public static void PrintPersonCard(Person person)
        {
            if (person == null)
            {

                Console.WriteLine("Devinsive check!");
                return;
            }
            // Default Male = 0 (Assuming your boolean treats 0/false as Male, and 1/true as Female)
            string genderText = person.Gender ? "Female" : "Male";

            // Combine names into one clean line
            string fullName = $"{person.FirstName} {person.SecondName} {person.ThirdName} {person.LastName}";

            Console.WriteLine("--- PERSON DETAILS ---");
            Console.WriteLine($"ID: {person.PersonID}");
            Console.WriteLine($"National No: {person.NationalNo}");
            Console.WriteLine($"Name: {fullName}");
            Console.WriteLine($"DOB: {person.DateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Gender: {genderText}");
            Console.WriteLine($"Nationality ID: {person.NationalityCountryID}");
            Console.WriteLine($"Phone: {person.Phone}");
            Console.WriteLine($"Email: {person.Email}");
            Console.WriteLine($"Address: {person.Address}");
            Console.WriteLine($"Image: {person.ImagePath}");
            Console.WriteLine("----------------------");
        }
        public static bool isPersonExist(int personID)
        {
            return Person.IsPersonExist(personID);
        }
        public static bool isPersonExist(string nationalID)
        {
            return Person.IsPersonExist(nationalID);
        }
        public static bool addNewPerson()
        {
            Person person = new Person();
            person.NationalNo = "N99";
            person.FirstName = "Ammar";
            person.SecondName = "sdf";
            person.ThirdName = "Hamed";
            person.LastName = "df";
            person.Address = "sdfsdf somewhere in this earth";
            person.Email = "sdfdsfsdfdsf@gmail.com";
            person.Gender = false; // male
            person.DateOfBirth = DateTime.Now;
            person.NationalityCountryID = 45;
            person.Phone = "sdfdsf";
            
            if(person.Save())
            {
                PrintPersonCard(person);
                return true;
            }
            Console.WriteLine("Well well well");
            return false;
        }
        public static bool UpdatePersonInfo(int personID)
        {
            Person person = Person.Find(personID);
            if (person != null)
            {
                person.NationalNo = "N77";
                person.FirstName = "Hacked";
                person.SecondName = "Hacked";
                person.ThirdName = "fsdf";
                person.LastName = "Hmada";
                person.Address = "dsfdsf";
                person.Email = "Ahmefdfada@gmail.com";
                person.Gender = false; // male
                person.DateOfBirth = DateTime.Now;
                person.NationalityCountryID = 78;
                person.Phone = "97633354";
                if (person.Save())
                {
                    PrintPersonCard(person);
                    return true;
                }
                Console.WriteLine("Well well well");
                return false;
            }
            return false;
               

            
        }
        public static void PrintPeople()
        {
            // Call the static method to get the data
            DataTable dt = Person.GetAllPeople();

            // Loop through each row and print the fields
            foreach (DataRow row in dt.Rows)
            {
                string thirdName = row["ThirdName"] == DBNull.Value ? "Null" : row["ThirdName"].ToString();
                string email = row["Email"] == DBNull.Value ? "Null" : row["Email"].ToString();
                string imagePath = row["ImagePath"] == DBNull.Value ? "Null" : row["ImagePath"].ToString();

                Console.WriteLine($"ID: {row["PersonID"]}, NationalNo: {row["NationalNo"]}, " +
                                  $"Name: {row["FirstName"]} {row["SecondName"]} {thirdName} {row["LastName"]}, " +
                                  $"DOB: {row["DateOfBirth"]}, Gender: {row["Gendor"]}, Address: {row["Address"]}, " +
                                  $"Phone: {row["Phone"]}, Email: {email}, CountryID: {row["NationalityCountryID"]}, " +
                                  $"Photo: {imagePath}");
            }
        }
        public static void DeletePerson(int personID)
        {
            if (Person.IsPersonExist(personID))
            {
                if (Person.DeletePerson(personID))
                    Console.WriteLine($"Person with Person ID = {personID} has been deleted successfully!");
                else
                    Console.WriteLine($"Person with Person ID = {personID} has NOT NOT NTO been deleted successfully!");
            }
            else
                Console.WriteLine($"Person with Person ID = {personID} was not found !!");
        }
       

        //###################    USER   ##################################
        public static void PrintUserCard(User user)
        {
            if (user == null)
            {

                Console.WriteLine("Devinsive check!");
                return;
            }
            // Default Male = 0 (Assuming your boolean treats 0/false as Male, and 1/true as Female)
            string genderText = user.Person.Gender ? "Female" : "Male";

            // Combine names into one clean line
            string fullName = $"{user.Person.FirstName} {user.Person.SecondName} {user.Person.ThirdName} {user.Person.LastName}";
            Console.WriteLine("--- user.User DETAILS ---");
            Console.WriteLine($"User ID: {user.UserID}");
            Console.WriteLine($"Username: {user.UserName}");
            Console.WriteLine($"Password: {user.Password}");
            Console.WriteLine($"is Active : {user.IsActive}");
            Console.WriteLine($"Person ID: {user.PersonID}");
            Console.WriteLine();

            Console.WriteLine("--- user.Person DETAILS ---");
            Console.WriteLine($"ID: {user.Person.PersonID}");
            Console.WriteLine($"National No: {user.Person.NationalNo}");
            Console.WriteLine($"Name: {fullName}");
            Console.WriteLine($"DOB: {user.Person.DateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Gender: {genderText}");
            Console.WriteLine($"Nationality ID: {user.Person.NationalityCountryID}");
            Console.WriteLine($"Phone: {user.Person.Phone}");
            Console.WriteLine($"Email: {user.Person.Email}");
            Console.WriteLine($"Address: {user.Person.Address}");
            Console.WriteLine($"Image: {user.Person.ImagePath}");
            Console.WriteLine("----------------------");

        }
        public static void FindUser(int userID)
        {
            User user = User.Find(userID);
            if (user == null)
            {
                Console.WriteLine("User was not found!!");
                return;
            }
            PrintUserCard(user);
        }
        public static void FindUser(string userName)
        {
            User user = User.Find(userName);
            if (user == null)
            {
                Console.WriteLine("User was not found!!");
                return;
            }
            PrintUserCard(user);
        }
        public static void AddNewUser(int perosnID)
        {
            User user = new User(perosnID);

            user.UserName = "john.doe";
            user.Password = "MyPassword123";
            user.IsActive = true;

            if (user.Save())
            {
                Console.WriteLine("User saved successfully!");

            }
            else
                Console.WriteLine("User was not saved  successfully!");
        }
        public static void UpdateUserInfo(int userID)
        {
            User user = User.Find(userID);
            if(user ==null)
            {
                Console.WriteLine("User is not found  !");
            }
    

            user.UserName = "Amged99";
            user.Password = "111";
            user.IsActive = true;

            if (user.Save())
            {
                Console.WriteLine("Updated successfully! :D");
            }
            else
                Console.WriteLine("User was not updated !");
        }
        public static void IsUserExists(int userID)
        {
            if(User.IsUserExist(userID))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
        public static void IsUserExists(string userName)
        {
            if (User.IsUserExist(userName))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
        public static void DeleteUser(int userID)
        {
            if (User.IsUserExist(userID))
            {
                if(User.Delete(userID))
                     Console.WriteLine("Deleted !!");
                else
                     Console.WriteLine("Not deleted!!");
            }
            else
            {
                Console.WriteLine("NO found");
            }
        }
        public static void GetAllUsers()
        {
            DataTable dt = User.GetAllUsers();
            foreach (DataRow row in dt.Rows)
            {


                Console.WriteLine($"ID: {row["UserID"]}, PersonID: {row["PersonID"]}," +
                                  $"Username: {row["UserName"]} ,Is Active : {row["IsActive"]}");
                Console.WriteLine("\n=============================================================\n");
            }
        }
        public static void Login(string username, string password)
        {
            User user = User.Login(username, password);
            if(user!=null)
            {
                Console.WriteLine("User logged in successfullly!");
            }
            else
                Console.WriteLine("User was not logged in , either password or name not correct");
        }
        static void Main(string[] args)
         {

            // FindPersonByID(1032);
            //  FindPersonByNationalID("N5");
            //if(isPersonExist("N565"))
            // Console.WriteLine("Yeaay");
            // int newId = PersonDataAccess.AddNewPerson("N12345678", "John", "Robert", "David", "Doe", new DateTime(1990, 5, 14), true, "123 Main St", "+15551234567", "john.doe@email.com", 1, @"C:\images\john.jpg");
            //int secondaryId = PersonDataAccess.AddNewPerson("N98765432", "Jane", "Marie", null, "Smith", new DateTime(1995, 10, 22), false, "456 Oak Ave", "+15559876543", null, 2, null);

            // FindPersonByID(secondaryId);
            //  addNewPerson();
            // UpdatePersonInfo(1036);
            // PrintPeople();
            //DeletePerson("N99");
            //  FindUser(15);
            //AddNewUser(1041);
            // UpdateUserInfo(18);
            // IsUserExists("Amged99");
            // DeleteUser(19);
            // GetAllUsers();
            Login("useR4","1234");


          }
    }
}
