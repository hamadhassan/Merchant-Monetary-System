using Merchant_Monetary_System.BL;
using System;
using System.Collections.Generic;
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

        public void addVendorIntoList(Vendor vendor)
        {
            vendorList.Add(vendor);
        }
        public static Vendor returnVendor(string vendorName)
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
    }
}
