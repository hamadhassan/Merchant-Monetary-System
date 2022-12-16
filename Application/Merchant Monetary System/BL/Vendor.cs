using System;
using System.Collections.Generic;
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

        public string VendorName { get => vendorName; set => vendorName = value; }
        public double LandlineNumber { get => landlineNumber; set => landlineNumber = value; }
        public string ConcernedPerson { get => concernedPerson; set => concernedPerson = value; }
        public double ContactNumber { get => contactNumber; set => contactNumber = value; }
    }
}
