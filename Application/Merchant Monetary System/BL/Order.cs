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
        private string shopName;
        private string asssignedRiderName;

        public string RiderName { get => riderName; set => riderName = value; }
        public string ShopKeeperName { get => shopKeeperName; set => shopKeeperName = value; }
        public DoublyLinkedList<Product> Order_products { get => order_products; set => order_products = value; }
        public string OrderID { get => orderID; set => orderID = value; }
        public string Status { get => status; set => status = value; }
        public string ShopName { get => shopName; set => shopName = value; }
        public string AsssignedRiderName { get => asssignedRiderName; set => asssignedRiderName = value; }

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


        public void  UpdateOrderStatus(string status) 
        {
            this.Status = status;
            OrderDL.storeAllRecordIntoFile(FilePath.Orders);
        }
        public Order(string ShopKeeperName, string RiderName, string OrderID, string OrderStatus, string ShopName, string AssignedRider,DoublyLinkedList<Product> product)
        {
            this.ShopKeeperName = ShopKeeperName;
            this.RiderName = RiderName;
            this.OrderID = OrderID ;
            this.Order_products = product;
            this.Status = OrderStatus;
            this.ShopName = ShopName;
            this.AsssignedRiderName = AssignedRider;


        }
        public Order(string ShopKeeperName, string RiderName,   string ShopName, DoublyLinkedList<Product> product) { 
 
            this.ShopKeeperName = ShopKeeperName;
            this.RiderName = RiderName;
            this.OrderID = generateOrderID();
            this.Order_products = product;
            this.Status = "In Progress";
            this.ShopName = ShopName;
            this.AsssignedRiderName = "No One";


        }
        public Order(string ShopKeeperName, string RiderName, string OrderID, string OrderStatus, string ShopName, string AssignedRider)
        {
            this.ShopKeeperName = ShopKeeperName;
            this.RiderName = RiderName;
            this.OrderID = OrderID;
            this.Order_products = new DoublyLinkedList<Product>();
            this.Status = OrderStatus;
            this.ShopName = ShopName;
            this.AsssignedRiderName = AssignedRider;
        }
    }
}
