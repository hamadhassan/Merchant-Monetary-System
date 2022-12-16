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
          
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            double lat = 10;
            double lng = 10;
            map.DragButton=MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(lat, lng);
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 10;//current zoom level
            map.AutoScroll = true;
            
            PointLatLng point = new PointLatLng(lat,lng);  
            GMapMarker marker= new GMarkerGoogle(point,GMarkerGoogleType.blue);
            //1. Create a Overlay
            GMapOverlay markers= new GMapOverlay("markers");
            //2. Add all available marksers to that overlay
            markers.Markers.Add(marker);
            //3. Cover mao with overlay
            map.Overlays.Add(markers);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
