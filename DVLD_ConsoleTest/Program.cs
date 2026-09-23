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
            User user = User.FindByUsernameAndPassword(username, password);
            if(user!=null)
            {
                Console.WriteLine("User logged in successfullly!");
            }
            else
                Console.WriteLine("User was not logged in , either password or name not correct");
        }
        //static void TestFindApplicationType()
        //{
        //    ApplicationType applicationType = ApplicationType.Find(1);

        //    if (applicationType != null)
        //    {
        //        Console.WriteLine("Application Type Found!");
        //        Console.WriteLine("ID: " + applicationType.ApplicationID);
        //        Console.WriteLine("Title: " + applicationType.ApplicationTypeTitle);
        //        Console.WriteLine("Fees: " + applicationType.ApplicationFees);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Application Type Not Found.");
        //    }
        //}
        //static void TestGetApplicationTypes()
        //{
        //    DataTable dt = ApplicationType.GetApplicationTypes();

        //    foreach (DataRow row in dt.Rows)
        //    {
        //        Console.WriteLine("ID: " + row["ApplicationTypeID"]);
        //        Console.WriteLine("Title: " + row["ApplicationTypeTitle"]);
        //        Console.WriteLine("Fees: " + row["ApplicationFees"]);
        //        Console.WriteLine("----------------------");
        //    }
        //}
        //static void TestEditApplicationType()
        //{
        //    ApplicationType applicationType = ApplicationType.Find(1);

        //    if (applicationType != null)
        //    {
        //        applicationType.ApplicationTypeTitle = "New Local Driving License Service";
        //        //New Local Driving License Service
        //        applicationType.ApplicationFees = 15.00m;

        //        if (applicationType.EditApplicationType())
        //            Console.WriteLine("Updated Successfully!");
        //        else
        //            Console.WriteLine("Update Failed!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Application Type Not Found.");
        //    }
        //}
        //static void TestFindApplication(int ID)
        //{
        //    Application application = new Application().Find(ID);

        //    if (application != null)
        //    {
        //        Console.WriteLine("Application Found!");
        //        Console.WriteLine("ID: " + application.ID);
        //        Console.WriteLine("Applicant Person ID: " + application.ApplicantPersonID);
        //        Console.WriteLine("Application Date: " + application.ApplicationDate);
        //        Console.WriteLine("Application Type ID: " + application.ApplicationTypeID);
        //        Console.WriteLine("Status: " + application.Status);
        //        Console.WriteLine("Last Status Date: " + application.LastStatusDate);
        //        Console.WriteLine("Paid Fees: " + application.PaidFees);
        //        Console.WriteLine("Created By User ID: " + application.CreatedByUserID);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Application Not Found.");
        //    }
        //}
        static void TestFindLocalDrivingLicenseApplication(int id)
        {
            var app = LocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByLocalAppID(id);

            if (app == null)
            {
                Console.WriteLine("Application not found.");
                return;
            }

            Console.WriteLine($"Local Driving License ID: {app.LocalDirivingLicenseID}");
            Console.WriteLine($"Application ID: {app.ApplicationID}");
            Console.WriteLine($"Person ID: {app.ApplicantPersonID}");
            Console.WriteLine($"License Class ID: {app.LicenseClassID}");
            Console.WriteLine($"Application Date: {app.ApplicationDate}");
            Console.WriteLine($"Application Type ID: {app.ApplicationTypeID}");
            Console.WriteLine($"Status: {app.Status}");
            Console.WriteLine($"Last Status Date: {app.LastStatusDate}");
            Console.WriteLine($"Paid Fees: {app.PaidFees}");
            Console.WriteLine($"Created By User ID: {app.CreatedByUserID}");
        }
        static void TestReplaceDamagedLicense(
    int oldLicenseID,
    int createdByUserID,
    ApplicationType.enApplicationType applicationType)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("   Replace Damaged/Lost License Test");
            Console.WriteLine("========================================");

            Console.WriteLine($"Old License ID: {oldLicenseID}");
            Console.WriteLine($"Application Type: {applicationType}");
            Console.WriteLine($"Created By User ID: {createdByUserID}");
            Console.WriteLine();

            // Find the old license
            License oldLicense = License.FindByLicenseID(oldLicenseID);

            if (oldLicense == null)
            {
                Console.WriteLine("ERROR: License was not found.");
                return;
            }

            Console.WriteLine("Old License found successfully.");
            Console.WriteLine($"License ID: {oldLicense.LicenseID}");
            Console.WriteLine($"Driver ID: {oldLicense.DriverID}");
            Console.WriteLine($"Issue Date: {oldLicense.IssueDate}");
            Console.WriteLine($"Expiration Date: {oldLicense.ExpirationDate}");
            Console.WriteLine($"Is Active: {oldLicense.IsActive}");
            Console.WriteLine($"Is Expired: {oldLicense.IsExpired()}");
            Console.WriteLine();

            // Create the new license object
            License newLicense = new License();

            Console.WriteLine("Attempting replacement...");
            Console.WriteLine();

            // Call your business method
            License.enReplaceDamgedLostValidationResult result =
                oldLicense.ReplaceDamgedLostLicense(
                    newLicense,
                    applicationType,
                    createdByUserID);

            Console.WriteLine($"Result: {result}");
            Console.WriteLine();

            // Display result
            switch (result)
            {
                case License.enReplaceDamgedLostValidationResult.Success:
                    Console.WriteLine("SUCCESS!");
                    Console.WriteLine($"New License ID: {newLicense.LicenseID}");
                    Console.WriteLine($"New Application ID: {newLicense.ApplicationID}");
                    Console.WriteLine($"New License Issue Date: {newLicense.IssueDate}");
                    Console.WriteLine($"New License Expiration Date: {newLicense.ExpirationDate}");
                    Console.WriteLine($"New License Is Active: {newLicense.IsActive}");
                    break;

                case License.enReplaceDamgedLostValidationResult.LicenseExpired:
                    Console.WriteLine("FAILED: The license has expired.");
                    Console.WriteLine("The user should renew the license instead.");
                    break;

                case License.enReplaceDamgedLostValidationResult.LicenseInactive:
                    Console.WriteLine("FAILED: The license is inactive.");
                    break;

                case License.enReplaceDamgedLostValidationResult.LicenseDetained:
                    Console.WriteLine("FAILED: The license is detained.");
                    break;

                case License.enReplaceDamgedLostValidationResult.AppFaildToSave:
                    Console.WriteLine("FAILED: The replacement application could not be saved.");
                    break;

                case License.enReplaceDamgedLostValidationResult.SaveFaild:
                    Console.WriteLine("FAILED: The new license could not be saved.");
                    break;

                default:
                    Console.WriteLine("FAILED: Unknown result.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("========================================");
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
            // Login("useR4","1234");
            ////Util.SaveLoginDataToSessionFile("Ahmed","55");
            //string[] arr = Util.LoadLoginDataFromSessionFile();
            //Console.WriteLine(arr[0]+" , " + arr[1]);

            // TestFindApplicationType();
            // TestGetApplicationTypes();
            // TestEditApplicationType();
            ///  TestGetApplicationTypes();
            //TestFindApplication(110);
            //TestFindLocalDrivingLicenseApplication(37);
            // TestReplaceDamagedLicense(25,1,ApplicationType.enApplicationType.ReplaceDamagedDrivingLicense);
           // DVLD_DataAccess.LicenseDataAccess.SetLicenseActiveState(23, true);
           
        }
    }
}
