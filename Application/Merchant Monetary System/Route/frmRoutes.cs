using GMap.NET.MapProviders;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using static GMap.NET.Entity.OpenStreetMapRouteEntity;

namespace Merchant_Monetary_System
{
    public partial class frmRoutes : Form
    {
        public frmRoutes()
        {
            InitializeComponent();
        }
        private void frmRoutes_Load(object sender, EventArgs e)
        {
            map.ShowCenter = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //Offline Map
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.CacheLocation = @"cache";

            PointLatLng start = new PointLatLng(31.580344855210168, 74.36079410267418);
            PointLatLng end = new PointLatLng(30.30098588609462, 73.05889660211788);
            GMapProviders.GoogleMap.ApiKey = ConfigAPI.ApiKey;
            map.MapProvider = GMapProviders.GoogleMap;
            map.DragButton = MouseButtons.Left;
            map.Position = start;
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 10;//current zoom level

            GMapMarker marker1 = new GMarkerGoogle(start, GMarkerGoogleType.blue);
            GMapMarker marker2 = new GMarkerGoogle(end, GMarkerGoogleType.blue);

            //1. Create a Overlay
            GMapOverlay markers = new GMapOverlay("markers");
            //2. Add all available marksers to that overlay
            markers.Markers.Add(marker1);
            markers.Markers.Add(marker2);
            //3. Cover mao with overlay
            map.Overlays.Add(markers);
            map.AutoScroll = true;
            map.refreshMap();
            //------------------Get Route----------------------
            //Start: Arifwala End:UET Lahore
            //GetRoutes(start, end);
            //-------------------Add Polygon----------------------
            //PointLatLng point3 = new PointLatLng(31.56253148472921, 74.43218994597594);
            //PointLatLng point4 = new PointLatLng(31.6157576196817, 74.30001069435704);
            //List<PointLatLng> points = new List<PointLatLng>();
            //points.Add(start);
            //points.Add(end);
            //points.Add(point3);
            //points.Add(point4);
            //addPolygon(points);
            //--------------------Remove Overlay-------------------------
            //RemoveOverlay(0);
            //-------------------Set Position by word--------------------------
            setPoitionbyKeyword("Arifwala");

            geoCoding("Arifwala");
        }
        public void addMarker(PointLatLng point, GMarkerGoogleType markerType = GMarkerGoogleType.arrow)
        {
            var markers = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(point, markerType);
            marker.ToolTipText = $"Latitude: {Math.Round(map.Position.Lat)},\n Longitude: {Math.Round(map.Position.Lng)}";
            var tooltip = new GMapToolTip(marker)
            {
                Fill = new SolidBrush(Color.DarkBlue),
                Foreground = new SolidBrush(Color.White),
                Offset = new Point(10, -50),
                Stroke = new Pen(new SolidBrush(Color.Red))
            };
            marker.ToolTip = tooltip;
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
        }
        public void GetRoutes(PointLatLng start, PointLatLng end)
        {
            var route = GoogleMapProvider.Instance.GetRoute(start, end, false, false, 15);
            //Add GMap Reference
            var r = new GMapRoute(route.Points, "MY Route");
            r.Stroke = new Pen(Color.Red, 1);
            //Add route into the map 
            var routes = new GMapOverlay("routes");
            routes.Routes.Add(r);
            map.Overlays.Add(routes);

            lblMessage.Text = Convert.ToString(route.Distance) + " KM";
        }
        public void addPolygon(List<PointLatLng> point)
        {

            var polygon = new GMapPolygon(point, "Polygon");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 1);
            var polygons = new GMapOverlay("polygons");
            polygons.Polygons.Add(polygon);
            map.Overlays.Add(polygons);

        }
        public void RemoveOverlay(int index)
        {
            if (map.Overlays.Count > 0 && map.Overlays.Count <= index)
            {
                map.Overlays.RemoveAt(index);
                map.Refresh();

            }
        }
        public void setPoitionbyKeyword(string loactionName)
        {
            map.SetPositionByKeywords(loactionName);
        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var point = map.FromLocalToLatLng(e.X, e.Y);
                double lat = point.Lat;
                double lng = point.Lng;

                map.Position = point;

                var markers = new GMapOverlay("markers");
                var marker = new GMarkerGoogle(point, GMarkerGoogleType.blue);
                markers.Markers.Add(marker);
                map.Overlays.Add(markers);
                //Get Address
                //List<string> addresses = getAddress(point);
                //lblMessage.Text = addresses[0].ToString();
            }
        }
        private List<string> getAddress(PointLatLng point)
        {
            List<Placemark> placemarks = null;
            GeoCoderStatusCode statusCode = GMapProviders.GoogleMap.GetPlacemarks(point, out placemarks);
            if (statusCode == GeoCoderStatusCode.OK && placemarks != null)
            {
                List<string> address = new List<string>();
                foreach (var placemark in placemarks)
                {
                    address.Add(placemark.Address);
                }
                return address;
            }
            return null;
        }
        private void geoCoding(string address)
        {
            GeoCoderStatusCode statusCode;
            var pointLanLong = GoogleMapProvider.Instance.GetPoint(address.Trim(), out statusCode);
            if (statusCode == GeoCoderStatusCode.OK)
            {
                double lat = pointLanLong.Value.Lat;
                double lng = pointLanLong.Value.Lng;
                lblMessage.Text = lat.ToString() + " " + lng.ToString();
            }
        }

    }
}
