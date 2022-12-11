using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merchant_Monetary_System
{
    public class Location
    {
        private float latitude;
        private float longitude;
        private string area;
        private string city;
        private string state;

        public float Latitude { get => latitude; set => latitude = value; }
        public float Longitude { get => longitude; set => longitude = value; }
        public string Area { get => area; set => area = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }

        public Location(string area,string city,string state)
        {
            this.area = area;
            this.city = city;
            this.state = state;
        }
        //Build later a function to convert area,city and state into latitude and longitude


    }
}
