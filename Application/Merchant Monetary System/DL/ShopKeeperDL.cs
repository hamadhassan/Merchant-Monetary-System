using Merchant_Monetary_System.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Merchant_Monetary_System.Data_Structure.BST;
using System.Windows.Forms;

namespace Merchant_Monetary_System.DL
{
    public sealed class ShopKeeperDL
    {
        public static List<string> names = new List<string>();
        private static List<string> shopNames = new List<string>();
        private static BST shopkeeperList = new BST();

        public static BST ShopkeeperList { get => shopkeeperList; set => shopkeeperList = value; }
        public static List<string> ShopNames { get => shopNames; set => shopNames = value; }

        public static void addShopkeeperIntoList(Shopkeeper shopkeeper)
        {
            shopkeeperList.Add(shopkeeper);
        }
        //public static void StoreDataIntoFiles(string path,BST Shopkeeper)
        //{
        //    if(Shopkeeper.Head!=null)
        //    {
        //        StoreSingleDataIntoFiles(path, Shopkeeper.Head);
        //    }
        //    else
        //    {
        //        StreamWriter file = new StreamWriter(path);
        //        file.Write("");
        //        file.Close();
        //    }
            
        //}
        //public static void StoreSingleDataIntoFiles(string path, BSTNode shopkeeper)
        //{
        //    if (shopkeeper != null)
        //    {
        //        StreamWriter file = new StreamWriter(path);
        //        DoublyLinkedListNode<Shop> Head = shopkeeper.Data.ShopList.Head;
        //        file.Write(shopkeeper.Data.ShopkeeperName + "," + shopkeeper.Data.Cnic + "," + shopkeeper.Data.Email + "," + shopkeeper.Data.ContactNumber + ",");
        //        int i = 0;
        //        while (Head != null)
        //        {
        //            if (i != 0) file.Write("|");
        //            file.Write(Head.Data.Id + ";" + Head.Data.ShopName + ";" + Head.Data.City + ";" + Head.Data.Area + ";" + Head.Data.State);
        //            i++;
        //            Head = Head.Next;
        //        }
        //        file.WriteLine();
        //        file.Flush();
                
        //        StoreSingleDataIntoFiles(path, shopkeeper.Left);
        //        StoreSingleDataIntoFiles(path, shopkeeper.Right);
        //        file.Close();
        //    }
        //}

        public static void LoadDataFromFiles(string path)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    string[] SplittedRecord = record.Split(',');
                    string shopkeeperName = SplittedRecord[0];
                    double cnic = double.Parse(SplittedRecord[1]);
                    string email = SplittedRecord[2];
                    double contactNumber = double.Parse(SplittedRecord[3]);
                    Shopkeeper shopkeeper = new Shopkeeper(shopkeeperName, cnic, email, contactNumber);
                    string[] shops = SplittedRecord[4].Split('|');
                    foreach (string S in shops)
                    {
                        string[] eachShop = S.Split(';');
                        string id = eachShop[0];
                        string shopName = eachShop[1];
                        string shopCity = eachShop[2];
                        string shopArea = eachShop[3];
                        string shopState = eachShop[4];
                        Shop shop = new Shop(id, shopName, shopCity, shopArea, shopState);
                        shopDL.addDataIntoList(shop);
                        shopkeeper.ShopList.Add(shop);
                        ShopKeeperDL.addShopkeeperIntoList(shopkeeper);
                    }
                }
                file.Close();
            }
        }

        public static BSTNode returnShopkeeper(double cnic)
        {
            BSTNode shopkeeper = ShopkeeperList.findNode(cnic);
            return shopkeeper;
        }
        public static Shopkeeper returnShopkeeperDetails(double cnic)
        {
            BSTNode shopkeeper = ShopkeeperList.findNode(cnic);
            if (shopkeeper != null) return shopkeeper.Data;
            else return null;
        }

        public static bool MatchShopkeeper(double cnic, string name)
        {
            BSTNode Head = ShopkeeperList.Head;
            while(Head != null)
            {
                if(Head.Data.Cnic == cnic && Head.Data.ShopkeeperName == name)
                {
                    return true;
                }
                if(Head.Data.Cnic < cnic)
                {
                    Head = Head.Left;
                }
                else
                {
                    Head = Head.Right;
                }
            }
            return false;
        }

        public static bool deleteShopkeeper(Shopkeeper shopkeeper)
        {
            BSTNode Head = ShopkeeperList.Head;
            while (Head != null)
            {
                if(Head.Data.Cnic == shopkeeper.Cnic)
                {
                    ShopkeeperList.remove(Head.Data);
                    return true;
                }
            }
            return false;
        }
        public static void Shopkeepers_names(BSTNode Head) 
        {
            if (Head != null)
            {
                Shopkeepers_names(Head.Left);
                names.Add(Head.Data.ShopkeeperName);
                Shopkeepers_names(Head.Right);
            }
        }
    //    public static List<string> Shop_names(string shopkeeper)
    //    {
    //        List<string> Shopnames = new List<string>();
    //        foreach (Shopkeeper name in shopkeeperList)
    //        {
    //            if (name.ShopkeeperName == shopkeeper) 
    //            {
    //                foreach (Shop names in name.ShopList) 
    //                {
    //                    Shopnames.Add(names.ShopName);
    //                }
    //            }
    //        }
    //        return Shopnames;
    //    }
        public static void AddIntoqueue(Queue<Shopkeeper> Q, BSTNode Shopkeeper)
        {
            if(Shopkeeper!=null)
            {
                Q.Enqueue(Shopkeeper.Data);
                AddIntoqueue(Q, Shopkeeper.Left);
                AddIntoqueue(Q, Shopkeeper.Right);
            }
        }

        public static void StoreDataIntoFiles(string path, BST Shopkeeper)
        {
            Queue<Shopkeeper> Q = new Queue<Shopkeeper>();
            AddIntoqueue(Q, Shopkeeper.Head);
            StreamWriter file = new StreamWriter(path);
            while (Q.Count != 0)
            {
                Shopkeeper shopkeeper = Q.Dequeue();
                DoublyLinkedListNode<Shop> Head = shopkeeper.ShopList.Head;
                file.Write(shopkeeper.ShopkeeperName + "," + shopkeeper.Cnic + "," + shopkeeper.Email + "," + shopkeeper.ContactNumber + ",");
                int i = 0;
                while (Head != null)
                {
                    if (i != 0) file.Write("|");
                    file.Write(Head.Data.Id + ";" + Head.Data.ShopName + ";" + Head.Data.City + ";" + Head.Data.Area + ";" + Head.Data.State);
                    i++;
                    Head = Head.Next;
                }
                file.WriteLine();
                file.Flush();
            }
            file.Close();
        }
        public static List<string> Shop_names(string shopkeeper)
        {
            List<string> Shopnames = new List<string>();
            Shopkeeper shp = returnShopkeeper(shopkeeper);
            DoublyLinkedListNode<Shop> Head = shp.ShopList.Head;
            while(Head != null)
            {
                Shopnames.Add(Head.Data.ShopName);
                Head = Head.Next;
            }
            return Shopnames;
        }

        public static Shopkeeper returnShopkeeper(string shopkeeper)
        {
            Queue<Shopkeeper> R = new Queue<Shopkeeper>();
            AddIntoqueue(R, ShopkeeperList.Head);
            while(R.Count != 0)
            {
                Shopkeeper shp = R.Dequeue();
                if(shp.ShopkeeperName == shopkeeper)
                {
                    return shp;
                }
            }
            return null;
        }


    }
}
