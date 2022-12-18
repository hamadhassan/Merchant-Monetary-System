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
        public static List<Order>ordersList= new List<Order>();

        public static List<Order> OrdersList { get => ordersList; set => ordersList = value; }
        public static bool InsertProduct(Order order)
        {
            OrdersList.Add(order);
            return true;
        }

        public static bool updateRecord(Order updatedorder)
        {
            foreach (Order order in OrdersList)
            {
                if (order.ShopKeeperName == order.ShopKeeperName)
                {
                    order.ShopKeeperName = updatedorder.ShopKeeperName;
                    order.RiderName = updatedorder.RiderName;
                    order.Order_products = updatedorder.Order_products;
                    order.OrderID = updatedorder.OrderID;
                    
                    return true;
                }
            }
            return false;
        }
        public static Order FoundOrder(int ID)
        {// the product  data matched with the database result
            foreach (Order order  in OrdersList)
            {
                if (ID == order.OrderID )
                {
                    return order;
                }
            }
            return null;
        }


        public static bool deleteRecord(Order deleteOrder)
        {
            foreach (Order order in OrdersList)
            {
                if (deleteOrder.OrderID == order.OrderID)
                {
                    ordersList.Remove(order);
                    return true;
                }
            }
            return false;
        }


        public static void storeAllRecordIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Order order in OrdersList)
            {
                file.Write(order.RiderName + "," + order.ShopKeeperName + "," + order.OrderID + "," );
                int i = 0;
                foreach (Product product in ProductDL.ProductList1)
                {
                    if (i != 0) file.Write("|");
                    file.Write(product.Name + ";" + product.Category + ";" + product.SKU_Number + ";" + product.Volume + ";" + product.Weight + ";" + product.Manufacturer+";"+product.SensitivityType);
                    i++;
                }
                file.WriteLine();
            }
            file.Close();
        }

        public static void clearList()
        {
            ordersList.Clear();
        }
        public static void loadRecordFromFile(string path)
        {
            StreamReader file = new StreamReader(path);
            string record;
            while ((record = file.ReadLine()) != null && (record = file.ReadLine()) != null)
            {
                string[] SplittedRecord = record.Split(',');
                string  RiderName = SplittedRecord[0];
                string shopkeeperName = (SplittedRecord[1]);
                int OrderID = Convert.ToInt16(SplittedRecord[2]);
                Order order = new Order(RiderName, shopkeeperName, OrderID);
                string[] products = SplittedRecord[4].Split('|');
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
                    ProductDL.InsertProduct(product);
                    order.Order_products.Add(product);
                    OrderDL.InsertProduct(order);
                }
            }
            file.Close();
        }

    }



}
