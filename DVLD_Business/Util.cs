using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public static class Util
    {
        private static string  _txtFileName = "D:\\DVLD-Full-Project\\session-data.txt";
        private static string _DestinationFolder = @"C:\DVLD-People-Images\";
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

    }
}
