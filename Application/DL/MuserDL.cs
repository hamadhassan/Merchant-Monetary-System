using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Threading.Tasks;
using bussniess.BL;
namespace bussniess.DL
{
    class MuserDL
    {
        private static List<MuserBL> users = new List<MuserBL>();
        public static List<MuserBL> get_list()
        {
            return users;
        }
        public static List<string> customer_name = new List<string>();
        public static List<string>get_c_list()
        {
            return customer_name;
        }
      
        public static void Add_user_into_list(MuserBL user) 
        {
            users.Add(user);
        
        }
        public static MuserBL sign_in(MuserBL user) 
        {
           foreach (MuserBL storeUser in users)
           {
                if (storeUser.Name == user.Name && storeUser.Password == user.Password) 
                {

                    return storeUser;
                }
                
           }
            return null;

        }
        public static string parseData(string record, int field) 
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++) 
            {

                if (record[x] == ',')
                {
                    comma++;

                }
                else if (comma == field) 
                {
                
                item=item + record[x];
                }
            }
            return item;
        }

        public static bool readDataFromFile(string path) 
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null) 
                {
                    string user_name = parseData(record, 1);
                    string user_pass = parseData(record, 2); 
                    string user_role = parseData(record, 3);
                    MuserBL u = new MuserBL(user_name, user_pass, user_role);
                    Add_user_into_list(u);

                }
                fileVariable.Close();
                return true;

            }
            else 
            {
                return false;
            }
        
        }
        public static void storeUserIntoFile(MuserBL user) 
        {
            string path = "users.txt";
            StreamWriter f = new StreamWriter(path,true);
            f.WriteLine(user.Name + "," + user.Password + "," + user.Role);
            f.Flush();
            f.Close();
        
        }
        public static void Delet_user_FROM_LIST(MuserBL u) 
        {
            for (int i = 0; i < users.Count; i++) 
            {
                if (users[i].Name == u.Name && users[i].Password == u.Password)
                {

                    users.RemoveAt(i);
                }
            
            }
        
        }
        public static void edit_user_from_list(MuserBL previous, MuserBL updated) 
        {

            foreach (MuserBL u in users) 
            {
                if (u.Name == previous.Name && u.Password == previous.Password) 
                {
                    u.Name = updated.Name;
                    u.Password = updated.Password;
                    u.Role = updated.Role;
                    u.CNIC = updated.CNIC;
                    u.Gender = updated.Gender;
                    u.Contact = updated.Contact;
                    u.Email = updated.Email;
                    u.Address = updated.Address;
                }
            
            }
        
        }
        public static void storeAllDataIntoFile(string path)
        {
            
            StreamWriter f = new StreamWriter(path);
            foreach (MuserBL user in users) 
            {
                f.WriteLine(user.Name + "," + user.Password + "," + user.Role,+","+user.CNIC +"," + user.Gender + "," + user.Contact + "," + user.Email + "," + user.Address);
            }
            
            f.Flush();
            f.Close();

        }
        public static void store_customer_name(string name)
        {
            string path = "customer_users.txt";
            StreamWriter f = new StreamWriter(path,false);
            
            f.WriteLine(name+",");
            
            f.Flush();
            f.Close();

        }
        public static bool read_customer_name()
        {
            string path = "customer_users.txt";
            
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string user_name = parseData(record, 1);

                    customer_name.Add(user_name);

                }
                fileVariable.Close();
                return true;

            }
            else
            {
                return false;
            }

        }
        public static bool check_user_in_list(string name, string pass) 
        {
            foreach (MuserBL user in users) 
            {
                if (name == user.Name && pass == user.Password) 
                {
                    return true;
                
                }
            }
            return false;
        }
        public static MuserBL search_user(string name, string pass) 
        {
            MuserBL p=new MuserBL(null,null) ;
            foreach (MuserBL user in users)
            {
                if (name == user.Name && pass == user.Password)
                {
                    return user;

                }
            }
            return p;
        }

    }
}
