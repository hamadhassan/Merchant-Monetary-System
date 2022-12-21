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
        private double assets;
        private static Compnay instance = null;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public int Phone { get => phone; set => phone = value; }
        public double Assets { get => assets; set => assets = value; }

        public static Compnay Instance(string name,string address,int phone, double revenue)
        {
            if (instance == null)
            {
                instance = new Compnay(name,address,phone,revenue);
            }
            return instance;
            
        }
        public static Compnay GetInstance()
        {
            return instance;
        }
        public Compnay(string name, string address, int phone,double revenue)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.assets = revenue; 
        }
        public Compnay(string name, string address, int phone)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.assets = 100000000000;
        }
        public Compnay()
        {

        }
        public void updateRecord(Compnay compnay)
        {
            this.name= compnay.name;
            this.address= compnay.address;
            this.phone = compnay.phone;
        }
        public void updateAmount(double revenue)
        {
            this.assets = revenue;
        }
        public void decreaseAssets(double amount)
        {
            this.assets -= amount;
        }
        public void increaseAssets(double amount)
        {
            this.assets += amount;
        }
    }
}
