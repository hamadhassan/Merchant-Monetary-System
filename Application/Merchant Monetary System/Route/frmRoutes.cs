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
        List<PointLatLng> points = new List<PointLatLng>();
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
            double lat = 31.580344855210168;
            double lng = 74.36079410267418;
            PointLatLng start = new PointLatLng(lat, lng);
            PointLatLng end = new PointLatLng(30.30098588609462, 73.05889660211788);
            GMapProviders.GoogleMap.ApiKey = ConfigAPI.ApiKey;
            map.MapProvider = GMapProviders.GoogleMap;
            map.DragButton=MouseButtons.Left;
            map.Position = start;
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 10;//current zoom level
            
            //Create custom maker
           // Bitmap bitmapMaker=(Bitmap)Image.FromFile("../placeholder.png");
            GMapMarker marker1= new GMarkerGoogle(start, GMarkerGoogleType.blue);
            GMapMarker marker2 = new GMarkerGoogle(end, GMarkerGoogleType.blue);

            //1. Create a Overlay
            GMapOverlay markers= new GMapOverlay("markers");
            //2. Add all available marksers to that overlay
            markers.Markers.Add(marker1);
            markers.Markers.Add(marker2);
            //3. Cover mao with overlay
            map.Overlays.Add(markers);
            //------------------Get Route----------------------
            //Start: Arifwala End:UET Lahore
            
            GetRoutes(start, end);
            map.AutoScroll = true;

        }
        public void GetRoutes(PointLatLng start, PointLatLng end)
        {
            var route = GoogleMapProvider.Instance.GetRoute(start, end, false, false, 15);
            //Add GMap Reference
            var r = new GMapRoute(route.Points, "MY Route");
            //{//add custom width
            //    Stroke = new Pen(color.Red, 5);
            //};
            //Add route into the map 
            var routes = new GMapOverlay("routes");
            routes.Routes.Add(r);
            map.Overlays.Add(routes);

            lblMessage.Text=Convert.ToString(route.Distance)+" KM";
        }

        private void map_Load(object sender, EventArgs e)
        {

        }
    }
}
