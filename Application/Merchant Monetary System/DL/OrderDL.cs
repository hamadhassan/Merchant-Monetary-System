using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Merchant_Monetary_System.BL;

namespace Merchant_Monetary_System.DL
{
    internal class OrderDL
    {
        public static DoublyLinkedList<Order> ordersList= new DoublyLinkedList<Order>();

        public static DoublyLinkedList<Order> OrdersList { get => ordersList; set => ordersList = value; }
        public static bool InsertProduct(Order order)
        {
            OrdersList.Add(order);
            return true;
        }

        public static bool updateRecord(Order updatedorder)
        {
            DoublyLinkedListNode<Order> Head = OrdersList.Head;
            while(Head != null)
            {
                if (Head.Data.ShopKeeperName == updatedorder.ShopKeeperName)
                {
                    Head.Data.ShopKeeperName = updatedorder.ShopKeeperName;
                    Head.Data.RiderName = updatedorder.RiderName;
                    Head.Data.Order_products = updatedorder.Order_products;
                    Head.Data.OrderID = updatedorder.OrderID;
                    return true;
                }
                Head = Head.Next;
            }
            return false;
        }
        public static Order FoundOrder(string ID)
        {// the product  data matched with the database result
            DoublyLinkedListNode<Order> Head = OrdersList.Head;
            while (Head != null)
            {
                if (ID == Head.Data.OrderID)
                {
                    return Head.Data;
                }
                Head = Head.Next;
            }
            return null;
        }


        public static bool deleteRecord(Order deleteOrder)
        {
            DoublyLinkedListNode<Order> Head = OrdersList.Head;
            while (Head != null)
            {
                if (deleteOrder.OrderID == Head.Data.OrderID)
                {
                    OrdersList.RemoveNode(Head);
                    return true;
                }
                Head = Head.Next;

            }
            return false;
        }
        public static void storeAllRecordIntoFile(string path)
        {
            if (File.Exists(path))
            {
                StreamWriter file = new StreamWriter(path,false);
                DoublyLinkedListNode<Order> OrderHead = OrdersList.Head;
                while (OrderHead != null)
                {
                    file.Write(OrderHead.Data.RiderName + "," + OrderHead.Data.ShopKeeperName + "," + OrderHead.Data.OrderID + "," + OrderHead.Data.Status + ","+ OrderHead.Data.ShopName + "," + OrderHead.Data.AsssignedRiderName + "," );
                    int i = 0;
                    DoublyLinkedListNode<Product> productHead = OrderHead.Data.Order_products.Head;
                    while(productHead != null)
                    {
                        if (i != 0) file.Write("|");
                        file.Write(productHead.Data.Name + ";" + productHead.Data.Category + ";" + productHead.Data.SKU_Number + ";" + productHead.Data.Volume + ";" + productHead.Data.Weight + ";" + productHead.Data.Manufacturer + ";" + productHead.Data.SensitivityType);
                        i++;
                        productHead = productHead.Next;
                    }
                    file.WriteLine();
                    OrderHead = OrderHead.Next;
                }
                file.Close();
            }
        }
        public static void storeRecordIntoFile(Order order, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.Write(order.RiderName + "," + order.ShopKeeperName + "," + order.OrderID + "," + order.Status + "," + order.ShopName + ","+ order.AsssignedRiderName + ",");
            int i = 0;
            DoublyLinkedListNode<Product> productHead = order.Order_products.Head;
            while (productHead != null)
            {
                if (i != 0) file.Write("|");
                file.Write(productHead.Data.Name + ";" + productHead.Data.Category + ";" + productHead.Data.SKU_Number + ";" + productHead.Data.Volume + ";" + productHead.Data.Weight + ";" + productHead.Data.Manufacturer + ";" + productHead.Data.SensitivityType);
                i++;
                productHead = productHead.Next;
            }
            file.WriteLine();
            file.Flush();
            file.Close();
        }

        public static void loadRecordFromFile(string path)
        {
            StreamReader file = new StreamReader(path);
            string record;
            while ((record = file.ReadLine()) != null)
            {
                string[] SplittedRecord = record.Split(',');
                string RiderName = SplittedRecord[0];
                string shopkeeperName = (SplittedRecord[1]);
                string OrderID = (SplittedRecord[2]);
                string Orderstatus = (SplittedRecord[3]);
                string ShopName = (SplittedRecord[4]);
                string AssignedRider = (SplittedRecord[5]);
                Order order = new Order(shopkeeperName, RiderName, OrderID, Orderstatus,ShopName,AssignedRider);

                string[] products = SplittedRecord[6].Split('|');
                foreach (string S in products)
                {
                    string[] eachProduct = S.Split(';');
                    string Name = eachProduct[0];
                    string Category = eachProduct[1];
                    int SKU_Number = Convert.ToInt16(eachProduct[2]);
                    double Volume = Convert.ToInt64(eachProduct[3]);
                    double Weight = Convert.ToInt64(eachProduct[4]);
                    string Manufacturer = eachProduct[5];
                    string SensitivityType = eachProduct[6];
                    Product product = new Product(Name,SKU_Number,Weight, Volume, Manufacturer,Category,SensitivityType);
                    order.Order_products.Add(product);
                    InsertProduct(order);
                }
                
            }
            file.Close();
        }
        public static DoublyLinkedList<Order> getOrders_withrespectiveRider(string RiderName)
        {

            DoublyLinkedListNode<Order> Head = OrdersList.Head;
            DoublyLinkedList<Order> RiderOrder = new DoublyLinkedList<Order>();

            while (Head != null)
            {
                    if (Head.Data.RiderName == RiderName)
                    {
                          RiderOrder.Add(Head.Data) ;
                            if (RiderOrder.Head.Next!=null) 
                            { 
                                RiderOrder.Head = Head.Next;
                            }
                    }
                    Head = Head.Next;   
            }
            return RiderOrder;
            
        }

    }



}
