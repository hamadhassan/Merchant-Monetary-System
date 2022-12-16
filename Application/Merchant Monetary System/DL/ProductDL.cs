using Merchant_Monetary_System.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System.DL
{
    internal class ProductDL
    {
        private static List<Product> ProductList = new List<Product>();

        public static List<Product> ProductList1 { get => ProductList; set => ProductList = value; }

        public static bool InsertProduct(Product product)
        {
            ProductList.Add(product);
            return true;
        }

        public static bool updateRecord(Product updatedProduct)
        {
            foreach (Product product in ProductList)
            {
                if (updatedProduct.Name == product.Name)
                {
                    product.Name = updatedProduct.Name;
                    product.SKU_Number=updatedProduct.SKU_Number;
                    product.Weight =updatedProduct.Weight;
                    product.Volume = updatedProduct.Volume;
                    product.Category = updatedProduct.Category;
                    product.Manufacturer = updatedProduct.Manufacturer;
                    product.SensitivityType = updatedProduct.SensitivityType;
  
                    return true;
                }
            }
            return false;
        }
        public static bool isProductMatch(string Name, int SKU_Number)
        {// the product  data matched with the database result
            foreach (Product product in ProductList)
            {
                if (Name == product.Name && SKU_Number == product.SKU_Number)
                {
                    return true;
                }
            }
            return false;
        }
        public static Product FoundProduct(string Name)
        {// the product  data matched with the database result
            foreach (Product product in ProductList)
            {
                if (Name == product.Name )
                {
                    return product;
                }
            }
            return null;
        }

        public static bool deleteRecord(Product deleteProduct)
        {
            foreach (Product product in ProductList)
            {
                if (deleteProduct.Name == product.Name)
                {
                    ProductList.Remove(product);
                    return true;
                }
            }
            return false;
        }


        public static void storeAllRecordIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Product record in ProductList)
            {
                file.WriteLine(record.Name + "," + record.SKU_Number + "," + record.Weight + "," + record.Volume
                 + "," + record.SensitivityType + "," + record.Category + "," + record.Manufacturer);
            }
            file.Flush();
            file.Close();
        }

        public static void clearList()
        {
           ProductList.Clear();
        }
        public static bool loadRecordFromFile(string path)
        {
            clearList();
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
                    Product product = new Product( Name, SKU_Number, Weight , Volume, Manufacturer, Category,SensitivityType);
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

        public static Product returnProduct(string productName)
        {
            foreach(Product P in ProductList1)
            {
                if(P.Name == productName)
                {
                    return P;
                }
            }
            return null;
        }




    }
}
