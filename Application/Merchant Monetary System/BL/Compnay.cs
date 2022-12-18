using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System
{
    public class Compnay
    {
        private string name;
        private string address;
        private int phone;
        private double revenue;
        private static Compnay instance = null;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public int Phone { get => phone; set => phone = value; }
        public double Revenue { get => revenue; set => revenue = value; }

        public static Compnay Instance(string name,string address,int phone)
        {
            if (instance == null)
            {
                instance = new Compnay(name,address,phone);
            }
            return instance;
            
        }
        public static Compnay GetInstance()
        {
            return instance;
        }
        public Compnay(string name, string address, int phone)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
        }
        public void updateRecord(Compnay compnay)
        {
            this.name= compnay.name;
            this.address= compnay.address;
            this.phone = compnay.phone;
        }
        
    }
}
