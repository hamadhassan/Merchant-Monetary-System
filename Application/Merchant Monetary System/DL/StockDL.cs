using Merchant_Monetary_System.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System.DL
{
    public sealed class StockDL
    {
        private static readonly StockDL instance = new StockDL();
        private List<Stock> stockList = new List<Stock>();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static StockDL()
        {
        }

        private StockDL()
        {
        }

        public static StockDL Instance
        {
            get
            {
                return instance;
            }
        }

        public List<Stock> StockList { get => stockList; set => stockList = value; }

        public static void addStockIntoList(List<Stock> stockList, Stock stock)
        {
            stockList.Add(stock);
        }

        public void StoreDataIntoFile(string path)
        {
            int i = 0;
            StreamWriter file = new StreamWriter(path);
            foreach (Stock record in StockList)
            {
                file.Write(record.Product.Name + "," + record.Quantity + "," + record.RetailPrice + "," + record.CostPrice
                    + "," + record.ManufacturingDate + "," + record.ExpiryDate + "," + record.RecievedDate + "," + record.Vendor.VendorName);
                if (i != stockList.Count) file.WriteLine();
                i++;
                file.Flush();
            }
            file.Close();
        }

        public void LoadDataFromFile(string path)
        {
            StreamReader file = new StreamReader(path);
            string record;
            while ((record = file.ReadLine()) != null)
            {
                string[] SplittedRecord = record.Split(',');
                string productName = SplittedRecord[0];
                int quantity = int.Parse(SplittedRecord[1]);
                double retailPrice = double.Parse(SplittedRecord[2]);
                double costPrice = double.Parse(SplittedRecord[3]);
                DateTime manufacturingDate = DateTime.Parse(SplittedRecord[4]);
                DateTime expiryDate = DateTime.Parse(SplittedRecord[5]);
                DateTime recievedDate = DateTime.Parse(SplittedRecord[6]);
                string vendorName = SplittedRecord[7];
                //Product product = ProductDL.returnProduct(productName);
                //Vendor vendor = VendorDL.returnVendor(vendorName);
                //Stock stock = new Stock(product, quantity, retailPrice, costPrice, manufacturingDate, expiryDate, recievedDate, vendor);
                //addStockIntoList(stock);
            }
            file.Close();
        }


    }
}
