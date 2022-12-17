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
            foreach (Order record in OrdersList)
            {
                //file.WriteLine(record.Name + "," + record.SKU_Number + "," + record.Weight + "," + record.Volume
                // + "," + record.SensitivityType + "," + record.Category + "," + record.Manufacturer);
            }
            file.Flush();
            file.Close();
        }

        public static void clearList()
        {
            ordersList.Clear();
        }
        public static bool loadRecordFromFile(string path)
        {
            try
            {
                clearList();
                StreamReader fileVariable = new StreamReader(path);
                string record;
                if (File.Exists(path))
                {
                    while ((record = fileVariable.ReadLine()) != null)
                    {
                    //    string[] spilitedRecord = record.Split(',');
                    //    string Name = spilitedRecord[0];
                    //    int SKU_Number = Convert.ToInt16(spilitedRecord[1]);
                    //    double Weight = Convert.ToDouble(spilitedRecord[2]);
                    //    double Volume = Convert.ToDouble(spilitedRecord[3]); ;
                    //    string SensitivityType = spilitedRecord[4];

                        Order order = new Order();
                        OrdersList.Add(order);
                    }
                    fileVariable.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return false;
            }

        }

        private static void cath()
        {
            throw new NotImplementedException();
        }

        public static Order returnOrder(int OrderID)
        {
            foreach (Order order in OrdersList)
            {
                if (order.OrderID == OrderID)
                {
                    return order;
                }
            }
            return null;
        }


    }
}
