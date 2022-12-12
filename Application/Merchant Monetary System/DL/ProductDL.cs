using Merchant_Monetary_System.BL;
using System;
using System.Collections.Generic;
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
        public static bool itProducrlMatch(string Name, int SKU_Number)
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



    }
}
