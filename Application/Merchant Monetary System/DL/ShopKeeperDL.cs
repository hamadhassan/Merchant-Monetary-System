using Merchant_Monetary_System.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Merchant_Monetary_System.DL
{
    public sealed class ShopKeeperDL
    {
        public static List<Shopkeeper> shopkeeperList = new List<Shopkeeper>();

        public void addShopkeeperIntoList(Shopkeeper shopkeeper)
        {
            shopkeeperList.Add(shopkeeper);
        }
        public static void StoreDataIntoFiles(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach(Shopkeeper shopkeeper in shopkeeperList)
            {
                Console.Write(shopkeeper.ShopkeeperName + "," + shopkeeper.Cnic + "," + shopkeeper.Email + "," + shopkeeper.ContactNumber + ",");
                int i = 0;
                foreach(Shop shop in shopkeeper.ShopList)
                {
                    if (i != 0) Console.Write("|");
                    Console.Write(shop.Id + ";" + shop.ShopName + ";" + shop.City + ";" + shop.Area + ";" + shop.State);
                    i++;
                }
                Console.WriteLine();
            }
            file.Close();
        }

        public static void LoadDataFromFiles(string path)
        {
            StreamReader file = new StreamReader(path);
            string record;
            while((record = file.ReadLine()) != null)
            {
                string[] SplittedRecord = record.Split(',');
                string shopkeeperName = SplittedRecord[0];
                double cnic = double.Parse(SplittedRecord[1]);
                string email = SplittedRecord[2];
                double contactNumber = double.Parse(SplittedRecord[3]);
                Shopkeeper shopkeeper = new Shopkeeper(shopkeeperName, cnic, email, contactNumber);
                string[] shops = SplittedRecord[4].Split('|');
                foreach(string S in shops)
                {
                    string[] eachShop = S.Split(';');
                    string id = eachShop[0];
                    string shopName = eachShop[1];
                    string shopCity = eachShop[2];
                    string shopArea = eachShop[3];
                    string shopState = eachShop[4];
                    Shop shop = new Shop(id, shopName, shopCity, shopArea, shopState);
                    shopkeeper.ShopList.Add(shop);
                }
            }
            file.Close();
        }

    }
}
