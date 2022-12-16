using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merchant_Monetary_System
{
    public class Location
    {
        //<<<<<<< Updated upstream
        private double latitude;
        private double longitude;
        private string area;
        private string city;
        private string state;
        private string address = "";
        public double Latitude { get => latitude; set => latitude = value; }
        public double Longitude { get => longitude; set => longitude = value; }
        public string Area { get => area; set => area = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }

        public Location(string area,string city,string state)
        {
            this.area = area;
            this.city = city;
            this.state = state;
        }
        public Location(double latitude, double longitude, string area, string city, string state)
        {
            this.latitude = latitude;
            this.longitude = longitude;
            this.area = area;
            this.city = city;
            this.state = state;
        }


        //Build later a function to convert area,city and state into latitude and longitude



    }
}
