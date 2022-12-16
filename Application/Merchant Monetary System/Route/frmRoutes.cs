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
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(10, 10);
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 10;//current zoom level
            map.AutoScroll = true;
        }
    }
}
