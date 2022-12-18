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
        private List<Product> order_products;
        private string shopKeeperName;
        private string riderName;
        private string orderID;

        public string RiderName { get => riderName; set => riderName = value; }
        public string ShopKeeperName { get => shopKeeperName; set => shopKeeperName = value; }
        public List<Product> Order_products { get => order_products; set => order_products = value; }
        public string OrderID { get => orderID; set => orderID = value; }

        public Order() { }
        public static string generateOrderID(int _characterLength = 5)
        {
            StringBuilder _builder = new StringBuilder();
            Enumerable
                .Range(65, 26)
                .Select(e => ((char)e).ToString())
                .Concat(Enumerable.Range(97, 26).Select(e => ((char)e).ToString()))
                .Concat(Enumerable.Range(0, 10).Select(e => e.ToString()))
                .OrderBy(e => Guid.NewGuid())
                .Take(_characterLength)
                .ToList().ForEach(e => _builder.Append(e));
            return _builder.ToString();
        }
        public Order(string ShopKeeperName,string RiderName) 
        {
            this.ShopKeeperName = ShopKeeperName;
            this.RiderName = RiderName;
            this.OrderID = (generateOrderID());
            this.Order_products = new List<Product>();
        }
        public Order(string ShopKeeperName, string RiderName, List<Product>product)
        {
            this.ShopKeeperName = ShopKeeperName;
            this.RiderName = RiderName;
            this.OrderID = (generateOrderID()); ;
            this.Order_products = product;
        }
        public Order(string ShopKeeperName, string RiderName, string OrderID)
        {
            this.ShopKeeperName = ShopKeeperName;
            this.RiderName = RiderName;
            this.OrderID = OrderID;
            this.Order_products = new List<Product>();
        }

    }
}
