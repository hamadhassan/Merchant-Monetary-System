using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System
{
    public class Users
    {
        protected string designation;
        protected string name;
        protected string gender;
        protected double cnic;
        protected string emailAddress;
        protected int contactNumber;
        protected string homeAddress;
        private Crediationals crediational;

        public string Designation { get => designation; set => designation = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public double Cnic { get => cnic; set => cnic = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public int ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string HomeAddress { get => homeAddress; set => homeAddress = value; }
        public Crediationals Crediational { get => crediational; set => crediational = value; }

        public Users(string designation, string name, string gender, double cnic, string emailAddress, int contactNumber, string homeAddress,Crediationals crediational)
        {
            this.designation = designation;
            this.name = name;
            this.gender = gender;
            this.cnic = cnic;
            this.emailAddress = emailAddress;
            this.contactNumber = contactNumber;
            this.homeAddress = homeAddress;
            this.crediational = crediational;
        }
       
    }
}

