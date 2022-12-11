using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Merchant_Monetary_System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Merchant_Monetary_System
{
    internal class UsersDL
    {
        private static List<Users> usersList=new List<Users>();

        public static List<Users> UsersList { get => usersList; set => usersList = value; }

        public static List<Users> getUsersListExceptCEO()
        {
            List<Users> usersListExceptCEO = new List<Users>();
            foreach (Users user in usersList)
            {
                if (!(user.Designation== "CEO"))
                {
                    usersListExceptCEO.Add(user);
                }
            }
            clearList();
            return usersListExceptCEO;
        }
        public static void clearList()
        {
            usersList.Clear();
        }
        public static bool isUserCrediationalMatch(string designation, string username, string password)
        {// the user enter data matched with the database result
            foreach (Users user in usersList)
            {
                if (designation == user.Designation && username == user.Username && password == user.Password)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool isUsernameExit(string username)
        {
            foreach (Users user in usersList)
            {
                if (username == user.Username)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool setPassword(string designation, string username,string newPassword)
        {
            foreach (Users user in usersList)
            {
                if (designation == user.Designation && username == user.Username)
                {
                    user.Password=newPassword;
                    return true;
                }
            }
            return false;
        }
        public static bool updateRecord(Users updatedUser)
        {
            foreach (Users user in usersList)
            {
                if (updatedUser.Username == user.Username)
                {
                    user.Designation = updatedUser.Designation;
                    user.Name=updatedUser.Name;
                    user.Password =updatedUser.Password;
                    user.Cnic = updatedUser.Cnic;
                    user.Gender = updatedUser.Gender;
                    user.ContactNumber = updatedUser.ContactNumber;
                    user.EmailAddress = updatedUser.EmailAddress;
                    user.HomeAddress = updatedUser.HomeAddress;
                    return true;
                }
            }
            return false;
        }
        public static bool deleteRecord(Users deleteUser)
        {
            foreach (Users user in usersList)
            {
                if (deleteUser.Username == user.Username)
                {
                    usersList.Remove(user);
                    return true;
                }
            }
            return false;
        }
        public static void storeRecordIntoFile(Users record, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(record.Designation + "," + record.Name + "," + record.Gender + "," + record.Cnic
                + "," + record.EmailAddress + "," + record.ContactNumber + "," + record.HomeAddress + "," + 
                record.Username + "," + record.Password);
            file.Flush();
            file.Close();
        }
        public static void storeAllRecordIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Users record in usersList)
            {
                file.WriteLine(record.Designation + "," + record.Name + "," + record.Gender + "," + record.Cnic
                + "," + record.EmailAddress + "," + record.ContactNumber + "," + record.HomeAddress + "," +
                record.Username + "," + record.Password);
            }
            file.Flush();
            file.Close();
        }
        public static bool loadRecordFromFile(string path)
        {
            clearList();
            StreamReader fileVariable = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string[] spilitedRecord=record.Split(',');
                    string designation = spilitedRecord[0];
                    string name = spilitedRecord[1];
                    string gender = spilitedRecord[2];
                    double cnic = Convert.ToDouble(spilitedRecord[3]);
                    string emailAddress = spilitedRecord[4];
                    int contactNumber = Convert.ToInt32(spilitedRecord[5]);
                    string homeAddress = spilitedRecord[6];
                    string username= spilitedRecord[7];
                    string password= spilitedRecord[8];
                    Users users = new Users(designation, name, gender, cnic, emailAddress, contactNumber, homeAddress,username,password);
                    usersList.Add(users);
                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
