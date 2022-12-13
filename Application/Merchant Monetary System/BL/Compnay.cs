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

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public int Phone { get => phone; set => phone = value; }

        public Compnay(string name, string adress, int phone)
        {
            this.name = name;
            this.address = adress;
            this.phone = phone;
        }
    }
}
