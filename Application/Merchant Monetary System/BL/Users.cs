using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System
{
    public class Users
    {
        private string designation;
        private string name;
        private string gender;
        private double cnic;
        private string emailAddress;
        private int contactNumber;
        private string homeAddress;
        private string username;
        private string password;

        public string Designation { get => designation; set => designation = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public double Cnic { get => cnic; set => cnic = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public int ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string HomeAddress { get => homeAddress; set => homeAddress = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public Users(string designation, string name, string gender, double cnic, string emailAddress, int contactNumber, string homeAddress,string username,string password)
        {
            this.designation = designation;
            this.name = name;
            this.gender = gender;
            this.cnic = cnic;
            this.emailAddress = emailAddress;
            this.contactNumber = contactNumber;
            this.homeAddress = homeAddress;
            this.username = username;
            this.password = password;
        }
        
    }
}

