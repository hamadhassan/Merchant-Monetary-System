using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Merchant_Monetary_System.DL;
using System.Collections;

namespace Merchant_Monetary_System.BL
{
    internal class Order
    {
        private LinkedList<Product> order_products=new LinkedList<Product>();
        private string shopName;
        private string riderName;
        private int orderID;

        public string RiderName { get => riderName; set => riderName = value; }
        public string ShopKeeperName { get => shopName; set => shopName = value; }
        public LinkedList<Product> Order_products { get => order_products; set => order_products = value; }
        public int OrderID { get => orderID; set => orderID = value; }

        public Order() { }
    }
}
