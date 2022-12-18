using Merchant_Monetary_System.DL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System.BL
{
    public class Vendor
    {
        private string vendorName;
        private double landlineNumber;
        private string concernedPerson;
        private double contactNumber;
        private double amount;

        public string VendorName { get => vendorName; set => vendorName = value; }
        public double LandlineNumber { get => landlineNumber; set => landlineNumber = value; }
        public string ConcernedPerson { get => concernedPerson; set => concernedPerson = value; }
        public double ContactNumber { get => contactNumber; set => contactNumber = value; }
        public double Amount { get => amount; set => amount = value; }

        public Vendor(string VendorName, double LandlineNumber, string ConcernedPerson, double ContactNumber, double amount )
        {
            this.VendorName = VendorName;
            this.landlineNumber = LandlineNumber;
            this.ConcernedPerson = ConcernedPerson;
            this.ContactNumber = ContactNumber;
            this.amount = amount;
        }
        public Vendor(string VendorName, double LandlineNumber, string ConcernedPerson, double ContactNumber)
        {
            this.VendorName = VendorName;
            this.landlineNumber = LandlineNumber;
            this.ConcernedPerson = ConcernedPerson;
            this.ContactNumber = ContactNumber;
            this.amount = 0;
        }
        public static void storeRecordIntoFile(Vendor vendor, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(vendor.VendorName + "," + vendor.ConcernedPerson + "," + vendor.LandlineNumber + "," + vendor.ContactNumber + "," + vendor.Amount);
            file.Flush();
            file.Close();
        }
        internal static void Clear()
        {
            throw new NotImplementedException();
        }
    }
}
