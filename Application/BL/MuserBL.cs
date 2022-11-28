using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussniess.BL
{
   public  class MuserBL
    {
        protected string name;
        protected string password;
        protected string role;
        protected string cNIC;
        protected string gender;
        protected string contact;
        protected string email;
        protected string address;



        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public string CNIC { get => cNIC; set => cNIC = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }

        public MuserBL(string name, string password, string role, string cNIC, string gender,string contact, string email, string address) 
        {
            this.name = name;
            this.password = password;
            this.role = role;
            this.cNIC = cNIC;
            this.gender = gender;
            this.contact = contact;
            this.email = email;
            this.address = address;
        }
        public MuserBL(string name, string password, string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }
        public MuserBL(string name, string password)
        {
            this.name = name;
            this.password = password;

        }
        public MuserBL()
        {

        }
        public bool isCEO() 
        {
            if (role == "CEO" || role == "ceo")
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        public bool isEmployee()
        {
            if (role == "Employee" || role == "employee")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isRider()
        {
            if (role == "Rider" || role == "rider")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isWareHouseManager()
        {
            if (role == "WareHouse Manager" || role == "warehouse manager")
            {
                return true;
            }
            else
            {
                return false;
            }                                              
        }



    }
}
