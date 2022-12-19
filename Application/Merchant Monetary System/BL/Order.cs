using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Merchant_Monetary_System.DL;
using System.Collections;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Migrations.Model;

namespace Merchant_Monetary_System.BL
{
    public class Order
    {
        private DoublyLinkedList<Product> order_products;
        private string shopKeeperName;
        private string riderName;
        private string orderID;
        private string status;

        public string RiderName { get => riderName; set => riderName = value; }
        public string ShopKeeperName { get => shopKeeperName; set => shopKeeperName = value; }
        public DoublyLinkedList<Product> Order_products { get => order_products; set => order_products = value; }
        public string OrderID { get => orderID; set => orderID = value; }
        public string Status { get => status; set => status = value; }

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
            this.Status = "In Progress";
            this.Order_products = new DoublyLinkedList<Product>();

        }

        public Order(string ShopKeeperName, string RiderName, DoublyLinkedList<Product>product)
        {
            this.ShopKeeperName = ShopKeeperName;
            this.RiderName = RiderName;
            this.OrderID = (generateOrderID()); ;
            this.Order_products = product;
            this.Status = "In Progress";
        }
        public Order(string ShopKeeperName, string RiderName, string OrderID)
        {
            this.ShopKeeperName = ShopKeeperName;
            this.RiderName = RiderName;
            this.OrderID = OrderID;
            this.Order_products = new DoublyLinkedList<Product>();
            this.Status = "In Progress";
        }
        public void  UpdateOrderStatus(string status) 
        {
            this.Status = status;
            OrderDL.storeAllRecordIntoFile(FilePath.Orders);
        }
        public Order(string ShopKeeperName, string RiderName, string OrderID, string OrderStatus, DoublyLinkedList<Product> product)
        {
            this.ShopKeeperName = ShopKeeperName;
            this.RiderName = RiderName;
            this.OrderID = OrderID ;
            this.Order_products = product;
            this.Status = OrderStatus;
        }
        public Order(string ShopKeeperName, string RiderName, string OrderID, string OrderStatus)
        {
            this.ShopKeeperName = ShopKeeperName;
            this.RiderName = RiderName;
            this.OrderID = OrderID;
            this.Order_products = new DoublyLinkedList<Product>();
            this.Status = OrderStatus;
        }
    }
}
