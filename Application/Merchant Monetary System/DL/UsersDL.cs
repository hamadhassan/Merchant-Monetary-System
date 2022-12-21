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
    public class UsersDL
    {
        private static List<Users> usersList=new List<Users>();
        private static DoublyLinkedList<Users> usersLinkedList = new DoublyLinkedList<Users>();

        public static List<Users> UsersList { get => usersList; set => usersList = value; }
        public static DoublyLinkedList<Users> UsersLinkedList { get => usersLinkedList; set => usersLinkedList = value; }

        public static DoublyLinkedList<Users> getUsersListExceptCEO()
        {
            DoublyLinkedList<Users> usersLinkedListExceptCEO = new DoublyLinkedList<Users>();
            //List<Users> usersListExceptCEO = new List<Users>();
            DoublyLinkedListNode<Users> Head = usersLinkedList.Head;
            while (Head != null)
            {
                if (!(Head.Data.Designation == "CEO"))
                {
                    usersLinkedListExceptCEO.Add(Head.Data);
                }
            }
            return usersLinkedListExceptCEO;
        }
        public static void clearList()
        {
            usersList.Clear();
        }
        public static bool isUserCrediationalMatch(string designation, string username, string password)
        {// the user enter data matched with the database result
            DoublyLinkedListNode<Users> Head = UsersLinkedList.Head;
            while (Head != null)
            {
                if (designation == Head.Data.Designation && username == Head.Data.Username && password == Head.Data.Password)
                {
                    return true;
                }
                Head = Head.Next;
            }
            return false;
        }
        public static bool isUsernameExit(string designation,string username)
        {

            DoublyLinkedListNode<Users> Head = UsersLinkedList.Head;
            while (Head != null)
            {
                if (designation == Head.Data.Designation && username == Head.Data.Username)
                {
                    return true;
                }
                Head=Head.Next;
            }
            return false;
        }
        public static bool setPassword(string designation, string username,string newPassword)
        {
            DoublyLinkedListNode<Users> Head = UsersLinkedList.Head;
            while (Head != null)
            {
                if (designation == Head.Data.Designation && username == Head.Data.Username)
                {
                    Head.Data.Password = newPassword;
                    return true;
                }

                Head = Head.Next;
            }
            return false;
        }
        public static bool updateRecord(Users updatedUser)
        {
            DoublyLinkedListNode<Users> Head = UsersLinkedList.Head;
            while(Head != null)
            {
                if(Head.Data.Username == updatedUser.Username)
                {
                    Head.Data.Designation = updatedUser.Designation;
                    Head.Data.Name = updatedUser.Name;
                    Head.Data.Password = updatedUser.Password;
                    Head.Data.Cnic = updatedUser.Cnic;
                    Head.Data.Gender = updatedUser.Gender;
                    Head.Data.ContactNumber = updatedUser.ContactNumber;
                    Head.Data.EmailAddress = updatedUser.EmailAddress;
                    Head.Data.HomeAddress = updatedUser.HomeAddress;
                    return true;
                }
            }
            return false;
        }
        public static bool deleteRecord(Users deleteUser)
        {
            DoublyLinkedListNode<Users> Head = usersLinkedList.Head;
            while(Head != null)
            {
                if(Head.Data.Username == deleteUser.Username && Head.Data.Password == deleteUser.Password && Head.Data.EmailAddress == deleteUser.EmailAddress)
                {
                    usersLinkedList.RemoveNode(Head);
                    return true;
                }
                Head = Head.Next;
            }
            return false;
        }
        public static void storeRecordIntoFile(Users record, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(record.Designation + "," + record.Name + "," + record.Gender + "," + record.Cnic
                 + "," + record.EmailAddress + "," + record.ContactNumber + "," + record.HomeAddress + "," +
                 record.Username + "," + record.Password + "," + record.Assigned);
            file.Flush();
            file.Close();
        }
        public static void storeAllRecordIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            DoublyLinkedListNode<Users> Head = usersLinkedList.Head;
            while (Head != null)
            {
                file.WriteLine(Head.Data.Designation + "," + Head.Data.Name + "," + Head.Data.Gender + "," + Head.Data.Cnic
                 + "," + Head.Data.EmailAddress + "," + Head.Data.ContactNumber + "," + Head.Data.HomeAddress + "," +
                 Head.Data.Username + "," + Head.Data.Password + "," + Head.Data.Assigned);
                Head = Head.Next;
            }
            file.Flush();
            file.Close();
        }
        public static List<string> GetCEO_Names() 
        {
            List<string> names = new List<string>();    
            DoublyLinkedListNode<Users> Head = UsersLinkedList.Head;
            while (Head != null)
            {
                if (!(Head.Data.Designation == "CEO"))
                {
                   names.Add(Head.Data.Name);
                }
            }
            return names;
        }
        public static string GetEmail(string name)
        {
            string email="";
            DoublyLinkedListNode<Users> Head = UsersLinkedList.Head;
            while (Head != null)
            {
                if (!(Head.Data.Name == name))
                {
                    email= Head.Data.EmailAddress;
                }
            }
            return email;
        }
        public static List<string> GetEmployee_Names()
        {
            List<string> names = new List<string>();
            DoublyLinkedListNode<Users> Head = UsersLinkedList.Head;
            while (Head != null)
            {
                if (!(Head.Data.Designation == "Employee"))
                {
                    names.Add(Head.Data.Name);
                }
                Head = Head.Next;
            }
            return names;
        }
        public static List<string> GetRider_Names()
        {
            List<string> names = new List<string>();
            DoublyLinkedListNode<Users> Head = UsersLinkedList.Head;
            while (Head != null)
            {
                if (!(Head.Data.Designation == "Rider"))
                {
                    names.Add(Head.Data.Name);
                }
                Head = Head.Next;
            }
            return names;
        }
        public static bool loadRecordFromFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string[] spilitedRecord=record.Split(',');
                    string designation = spilitedRecord[0];
                    string name = spilitedRecord[1];
                    string gender = spilitedRecord[2];
                    double cnic = Convert.ToDouble(spilitedRecord[3]);
                    string emailAddress = spilitedRecord[4];
                    double contactNumber = Convert.ToDouble(spilitedRecord[5]);
                    string homeAddress = spilitedRecord[6];
                    string username= spilitedRecord[7];
                    string password= spilitedRecord[8];
                    string assigned = spilitedRecord[9];
                    Users users = new Users(designation, name, gender, cnic, emailAddress, contactNumber, homeAddress,username,password, assigned);
                    usersLinkedList.Add(users);
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
