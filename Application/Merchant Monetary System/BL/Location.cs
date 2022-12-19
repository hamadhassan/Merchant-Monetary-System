using GMap.NET.MapProviders;
using GMap.NET;
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
        private double latitude;
        private double longitude;
        private string area;
        private string city;
        private string state;
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
            PointLatLng point = geoCoding(area + " " + city + " " + state);
            this.latitude=point.Lat; 
            this.longitude=point.Lng;
        }
        public Location(double latitude, double longitude, string area, string city, string state)
        {
            this.latitude = latitude;
            this.longitude = longitude;
            this.area = area;
            this.city = city;
            this.state = state;
        }
        private PointLatLng geoCoding(string address)
        {
            GMapProviders.GoogleMap.ApiKey = ConfigAPI.ApiKey;
            GeoCoderStatusCode statusCode;
            var pointLanLong = GoogleMapProvider.Instance.GetPoint(address.Trim(), out statusCode);
            if (statusCode == GeoCoderStatusCode.OK)
            {
                double lat = pointLanLong.Value.Lat;
                double lng = pointLanLong.Value.Lng;
                PointLatLng latLng = new PointLatLng(lat, lng);
                return latLng;
            }
            return PointLatLng.Empty;

        }
    }
}
