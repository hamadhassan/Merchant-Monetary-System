using Merchant_Monetary_System.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System.DL
{
    public sealed class VendorDL
    {
        private static readonly VendorDL instance = new VendorDL();
        private static List<Vendor> vendorList = new List<Vendor>();

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

        public static void addVendorIntoList(Vendor vendor)
        {
            vendorList.Add(vendor);
        }
        public static Vendor FoundVendor(string vendorName)
        {
            foreach (Vendor vendor in VendorList)
            {
                if (vendor.VendorName == vendorName)
                {
                    return vendor;
                }
            }
            return null;
        }
        public static bool updateVendorMatch(Vendor updatedvendor)
        {// the product  data matched with the database result
            foreach (Vendor vendor in VendorList)
            {
                if (vendor==updatedvendor )
                {
                    return true;
                }
            }
            return false; 
        }
        public static Vendor returnVendor(string updatedvendor)
        {// the product  data matched with the database result
            foreach (Vendor vendor in VendorList)
            {
                if (vendor.VendorName == updatedvendor)
                {
                    return vendor;
                }
            }
            return null;
        }


        public static bool deleteVendor(Vendor deletevendor)
        {
            foreach (Vendor vendor in VendorList)
            {
                if (deletevendor.VendorName == vendor.VendorName)
                {
                    VendorList.Remove(vendor);
                    return true;
                }
            }
            return false;
        }


        public static void storeAllRecordIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);

            foreach (Vendor vendor in VendorList)
            {
                file.WriteLine(vendor.VendorName + "," + vendor.ConcernedPerson + "," + vendor.LandlineNumber + "," + vendor.ContactNumber+","+vendor.Amount);

            }
            file.Flush();
            file.Close();
        }

        public static void clearList()
        {
            VendorList.Clear();
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
