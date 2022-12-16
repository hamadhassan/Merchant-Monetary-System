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
        private static Compnay instance = null;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public int Phone { get => phone; set => phone = value; }
        public static Compnay Instance
        {
            get
            {
                if (instance == null)
                {
                    //instance = new Compnay();
                }
                return instance;

            }
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
