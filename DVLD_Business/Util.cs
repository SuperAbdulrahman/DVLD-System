using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace DVLD_Business
{
    public static class Util
    {
        private static string  _txtFileName = "D:\\DVLD-Full-Project\\session-data.txt";
        private static string _DestinationFolder = @"C:\DVLD-People-Images\";

        //win registery names
        private static string  _KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
        private static string _VUsername= "Username";
        private static string _VPassword = "Password";


        public static string GenerateGUID()
        {
            Guid newGUID = Guid.NewGuid();
            return newGUID.ToString();
        }
        public static string ReplaceFileNameWithGUID(string sourceFile)
        {
            string fileName = sourceFile;
            FileInfo fi = new FileInfo(fileName);
            string extn = fi.Extension;
            return GenerateGUID() + extn;
        }
        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception ex)
                {
                    //  MessageBox.Show("Error creating folder: " + ex.Message); ???
                    return false;
                }
            }
            return true;
        }
        public static bool CopyImageToProjectImageFolder(ref string sourceFile)
        {
            // this funciton will copy the image to the
            // project images foldr after renaming it
            // with GUID with the same extention, then it will update the sourceFileName with the new name.
            
            if(!CreateFolderIfDoesNotExist(_DestinationFolder))
            {
                return false;
            }
            string destinationFile = _DestinationFolder +ReplaceFileNameWithGUID(sourceFile);
            try
            {
                File.Copy(sourceFile, destinationFile, true);
            }
            catch (IOException iox)
            {
               // MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ???
                return false;
            }
            sourceFile = destinationFile;
            return true;
        }
        // TxT session file
        public static void SaveLoginDataToSessionFile(string username,string password)
        {
            string sessionInfo = username + "," + password;
            File.WriteAllText(_txtFileName, sessionInfo);
        }
        public static string[] LoadLoginDataFromSessionFile()
        {
            string sessionInfo = File.ReadAllText(_txtFileName);

            string[] parts = sessionInfo.Split(',');

            string username = parts[0];
            string password = parts[1];

            return parts;
        }

        // Save session info to windows registery
        public static bool SaveLoginDataToWinRegistery(string username,string password)
        {
            bool isSaved = true;
            
    

            //we write the value
            try
            {
                Registry.SetValue(_KeyPath, _VUsername, username);
                Registry.SetValue(_KeyPath, _VPassword, password);

            }
            catch (Exception)
            {

                // we can log the error message here
                isSaved = false;
            }

            return isSaved;
        }

        public static  bool LoadLoginDataFromWinRegistery(string[] values)
        {
            bool isFound = true;
            
            try
            {
                string username = Registry.GetValue(_KeyPath, _VUsername, null) as string;
                string password = Registry.GetValue(_KeyPath, _VPassword, null) as string;
                if (username != null || password != null)
                    return false;
                values[0]=username;
                values[1]=password;
            }
            catch (Exception)
            {

               //Log error here
               isFound = false;
            }
            return isFound;
        }

    }
}
