using Merchant_Monetary_System.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merchant_Monetary_System.DL
{
    internal class ProductDL
    {
        private static DoublyLinkedList<Product> productList = new DoublyLinkedList<Product>();

        public static DoublyLinkedList<Product> ProductList { get => productList; set => productList = value; }

        public static void InsertProduct(Product product)
        {
            ProductList.Add(product);
        }

        public static bool isProductMatch(string Name, int SKU_Number)
        {// the product  data matched with the database result
            DoublyLinkedListNode<Product> Head = ProductList.Head;
            while (Head != null)
            {
                if (Name == Head.Data.Name && SKU_Number == Head.Data.SKU_Number)
                {
                    return true;
                }
                Head = Head.Next;

            }
            return false;
        }
        public static Product FoundProduct(string Name, int SKU_number)
        {// the product  data matched with the database result
            DoublyLinkedListNode<Product> Head = ProductList.Head;
            while (Head != null)
            {
                if (Name == Head.Data.Name && Head.Data.SKU_Number == SKU_number)
                {
                    return Head.Data;
                }
                Head = Head.Next;
            }
            return null;
        }

        public static bool deleteRecord(Product deleteProduct)
        {
            DoublyLinkedListNode<Product> Head = ProductList.Head;
            while (Head != null)
            {
                if (deleteProduct.Name == Head.Data.Name && deleteProduct.SKU_Number == Head.Data.SKU_Number)
                {
                    ProductList.RemoveNode(Head);
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
                StreamWriter file = new StreamWriter(path);
                DoublyLinkedListNode<Product> Head = ProductList.Head;
                while (Head != null)
                {
                    file.WriteLine(Head.Data.Name + "," + Head.Data.SKU_Number + "," + Head.Data.Weight + "," + Head.Data.Volume
                     + "," + Head.Data.SensitivityType + "," + Head.Data.Category + "," + Head.Data.Manufacturer);
                    Head = Head.Next;
                }
                file.Flush();
                file.Close();
            }
        }
        public static bool loadRecordFromFile(string path)
        {
            try
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                if (File.Exists(path))
                {
                    while ((record = fileVariable.ReadLine()) != null)
                    {
                        string[] spilitedRecord = record.Split(',');
                        string Name = spilitedRecord[0];
                        int SKU_Number = Convert.ToInt16(spilitedRecord[1]);
                        double Weight = Convert.ToDouble(spilitedRecord[2]);
                        double Volume = Convert.ToDouble(spilitedRecord[3]); ;
                        string SensitivityType = spilitedRecord[4];
                        string Category = spilitedRecord[5];
                        string Manufacturer = spilitedRecord[6];
                        Product product = new Product(Name, SKU_Number, Weight, Volume, Manufacturer, Category, SensitivityType);
                        ProductList.Add(product);
                    }
                    fileVariable.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exp) { MessageBox.Show(exp.Message);
                return false;
            }

        }

        private static void cath()
        {
            throw new NotImplementedException();
        }

        public static Product returnProduct(string productName)
        {
            DoublyLinkedListNode<Product> Head = ProductList.Head;
            while(Head != null)
            {
                if (Head.Data.Name == productName)
                {
                    return Head.Data;
                }
            }
            return null;
        }
    }
}
