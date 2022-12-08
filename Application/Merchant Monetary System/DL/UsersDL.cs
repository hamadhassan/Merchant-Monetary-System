using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Merchant_Monetary_System;

namespace Merchant_Monetary_System
{
    internal class UsersDL
    {
        private static List<Users> usersList=new List<Users>();

        public static List<Users> UsersList { get => usersList; set => usersList = value; }
       
        public static void storeRecordIntoFile(Users record, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(record.Designation + "," + record.Name + "," + record.Cnic+","+record.Gender
                +","+record.ContactNumber+","+record.EmailAddress+","+record.HomeAddress);
            file.Flush();
            file.Close();

        }
        //public static bool loadRecordFromFile(string path)
        //{
            //clearList();
            //if (File.Exists(path))
            //{
            //    StreamReader fileVariable = new StreamReader(path);
            //    string record;
            //    while ((record = fileVariable.ReadLine()) != null)
            //    {
            //        string designation =parseData(record,1);
            //        string name=parseData(record,2);
            //        string gender = parseData(record, 3);
            //        double cnic =Convert.ToInt64(parseData(record, 4));
            //        string emailAddress = parseData(record, 5);
            //        int contactNumber =Convert.ToInt32( parseData(record, 6));
            //        string homeAddress = parseData(record, 7);
            //        Users users = new Users(designation, name, gender, cnic, emailAddress, contactNumber, homeAddress);
            //        usersList.Add(users);
            //    }
            //    fileVariable.Close();
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        //}
        public static void clearList()
        {
            usersList.Clear();
        }
        public static bool isUserCrediationalMatch(string designation, string username, string password)
        {// the user enter data matched with the database result
            foreach (Users user in usersList)
            {
                if (designation == user.Designation && username == user.Crediational.Username && password == user.Crediational.Password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
