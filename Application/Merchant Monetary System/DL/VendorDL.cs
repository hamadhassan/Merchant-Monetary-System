using Merchant_Monetary_System.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System.DL
{
    public sealed class VendorDL
    {
        private static readonly VendorDL instance = new VendorDL();
        private static List<Vendor> vendorList = new List<Vendor>();
        private static DoublyLinkedList<Vendor> vendorLinkedList = new DoublyLinkedList<Vendor>();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static VendorDL()
        {
        }

        private VendorDL()
        {
        }

        public static VendorDL Instance
        {
            get
            {
                return instance;
            }
        }

        public static List<Vendor> VendorList { get => vendorList; set => vendorList = value; }
        public static DoublyLinkedList<Vendor> VendorLinkedList { get => vendorLinkedList; set => vendorLinkedList = value; }

        public static void addVendorIntoList(Vendor vendor)
        {
            VendorLinkedList.Add(vendor);
        }
        public static Vendor FoundVendor(string vendorName)
        {
            DoublyLinkedListNode<Vendor> Head = VendorLinkedList.Head;
            while(Head!=null)
            {
                if (Head.Data.VendorName == vendorName)
                {
                    return Head.Data;
                }
            }
            return null;
        }
        //public static bool updateVendorMatch(Vendor updatedvendor)
        //{// the product  data matched with the database result
        //    foreach (Vendor vendor in VendorList)
        //    {
        //        if (vendor==updatedvendor )
        //        {
        //            return true;
        //        }
        //    }
        //    return false; 
        //}
        public static Vendor returnVendor(string vendor, double landline, string person, double contact, double amount)
        {// the product  data matched with the database result
            DoublyLinkedListNode<Vendor> Head = VendorLinkedList.Head;
            while(Head!=null)
            {
                if (Head.Data.VendorName == vendor && Head.Data.LandlineNumber == landline && Head.Data.ConcernedPerson == person && Head.Data.ContactNumber == contact
                    && Head.Data.Amount == amount)
                {
                    return Head.Data;
                }
            }
            return null;
        }
        public static bool deleteVendor(Vendor deletevendor)
        {
            DoublyLinkedListNode<Vendor> Head = VendorLinkedList.Head;
            while (Head != null)
            {
                if (Head.Data.VendorName == deletevendor.VendorName && Head.Data.LandlineNumber == deletevendor.LandlineNumber && Head.Data.ContactNumber == deletevendor.ContactNumber
                    && Head.Data.Amount == deletevendor.Amount)
                {
                    VendorLinkedList.RemoveNode(Head);
                    return true;
                }
                Head = Head.Next;
            }
            return false;
        }


        public static void storeAllRecordIntoFile(string path)
        {
            DoublyLinkedListNode<Vendor> Head = VendorLinkedList.Head;
            StreamWriter file = new StreamWriter(path);
            while (Head != null)
            {
                file.WriteLine(Head.Data.VendorName + "," + Head.Data.ConcernedPerson + "," + Head.Data.LandlineNumber + "," + Head.Data.ContactNumber+","+ Head.Data.Amount);
                Head = Head.Next;
                file.Flush();
            }
            file.Close();
        }
        public static bool loadRecordFromFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string[] spilitedRecord = record.Split(',');
                    String Name  = spilitedRecord[0];
                    string ConcernedPerson = spilitedRecord[1];
                    double LandLine = Convert.ToDouble(spilitedRecord[2]);
                    double Contact = Convert.ToDouble(spilitedRecord[3]);
                    double Amount = Convert.ToDouble(spilitedRecord[4]);

                    Vendor vendor = new Vendor(Name,LandLine, ConcernedPerson, Contact,Amount);
                    addVendorIntoList(vendor);
                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }






    }
}
