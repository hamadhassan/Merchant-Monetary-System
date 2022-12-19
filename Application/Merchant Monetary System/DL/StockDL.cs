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
        private static DoublyLinkedList<Stock> stockList = new DoublyLinkedList<Stock>();

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
        public static DoublyLinkedList<Stock> StockList { get => stockList; set => stockList = value; }

        public static void addStockIntoList(DoublyLinkedList<Stock> stockList, Stock stock)
        {
            stockList.Add(stock);
        }

        public static void StoreDataIntoFile(string path)
        {
            if (File.Exists(path))
            {
                int i = 0;
                StreamWriter file = new StreamWriter(path);
                DoublyLinkedListNode<Stock> Head = StockList.Head;
                while (Head != null)
                {
                    file.Write(Head.Data.Product + "," + Head.Data.Quantity + "," + Head.Data.RetailPrice + "," + Head.Data.CostPrice
                        + "," + Head.Data.ManufacturingDate + "," + Head.Data.ExpiryDate + "," + Head.Data.RecievedDate + "," + Head.Data.Vendor);
                    if (i != stockList.Count) file.WriteLine();
                    i++;
                    file.Flush();
                }
                file.Close();
            }
        }

        public static void LoadDataFromFile(string path)
        {
            if (File.Exists(path))
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
                    string product = productName;
                    string vendor = vendorName;
                    Stock stock = new Stock(product, quantity, retailPrice, costPrice, manufacturingDate, expiryDate, recievedDate, vendor);
                    StockDL.addStockIntoList(StockDL.StockList, stock);
                }
                file.Close();
            }
        }

        public static Stock AlreadyStockAdded(List<Stock> stock, Stock S)
        {
            DoublyLinkedListNode<Stock> Head = StockList.Head;
            while(Head != null)
            {
                if (Head.Data.Product == S.Product && Head.Data.ManufacturingDate == S.ManufacturingDate && Head.Data.ExpiryDate == S.ExpiryDate
                    && Head.Data.RecievedDate == S.RecievedDate && Head.Data.Vendor == S.Vendor)
                {
                    return Head.Data;
                }
            }
            return null;
        }

        public static void MergeStock(DoublyLinkedList<Stock> TempStock, DoublyLinkedList<Stock> Stock)
        {
            DoublyLinkedListNode<Stock> outerHead = TempStock.Head;
            while(outerHead != null)
            {
                bool found = false;
                DoublyLinkedListNode<Stock> innerHead = Stock.Head;
                while(innerHead != null)
                {
                    if (outerHead.Data.Product == innerHead.Data.Product && outerHead.Data.ManufacturingDate == innerHead.Data.ManufacturingDate && outerHead.Data.ExpiryDate == innerHead.Data.ExpiryDate
                    && outerHead.Data.RecievedDate == innerHead.Data.RecievedDate && outerHead.Data.Vendor == innerHead.Data.Vendor)
                    {
                        innerHead.Data.addQuantity(outerHead.Data.Quantity);
                        found = true;
                    }
                    innerHead = innerHead.Next;
                }
                if (!found)
                {
                    Stock.Add(outerHead.Data);
                }
                outerHead = outerHead.Next;
            }
        }




        public static bool deleteStock(DoublyLinkedList<Stock> stock, Stock S)
        {
            DoublyLinkedListNode<Stock> Head = StockList.Head;
            while(Head != null)
            {
                if(Head.Data == S)
                {
                    DoublyLinkedListNode<Stock> stockNode = stock.Find(S);
                    stock.RemoveNode(stockNode);
                    return true;
                }
            }
            return false;
        }

        public static double calculateAmount(DoublyLinkedList<Stock> Stock)
        {
            double amount = 0;
            DoublyLinkedListNode<Stock> Head = Stock.Head;
            while(Head != null)
            {
                amount += Head.Data.RetailPrice * Head.Data.Quantity;
                Head = Head.Next;
            }
            return amount;
        }

        public static Stock returnStock(Stock S)
        {
            DoublyLinkedListNode<Stock> Head = StockList.Head;
            while (Head != null)
            {
                if(S.Product == Head.Data.Product && S.Quantity == Head.Data.Quantity && S.RetailPrice == Head.Data.RetailPrice && S.CostPrice == Head.Data.CostPrice
                    && S.ManufacturingDate == Head.Data.ManufacturingDate && S.ExpiryDate == Head.Data.ExpiryDate && S.RecievedDate == Head.Data.RecievedDate && S.Vendor == Head.Data.Vendor)
                {
                    return Head.Data;
                }
                Head = Head.Next;
            }
            return null;
        }
    }
}
