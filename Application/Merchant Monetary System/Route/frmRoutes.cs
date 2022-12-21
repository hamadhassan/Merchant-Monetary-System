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
using System.IO;

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
            ////Offline Map
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.CacheLocation = @"cache";

            PointLatLng warehousePoint = new PointLatLng(31.480829085972807, 74.48008507482837);//it is warehouse
            GMapProviders.GoogleMap.ApiKey = ConfigAPI.ApiKey;
            map.MapProvider = GMapProviders.GoogleMap;
            map.DragButton = MouseButtons.Left;
            map.Position = warehousePoint;//starting point of the map
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 10;//current zoom level
            map.AutoScroll = true;
            run(warehousePoint, listofPoints());
            map.Refresh();
            addPolygon(listofPoints());
        }
        public void run(PointLatLng warehousePoint, List<PointLatLng> shopePoints)
        {
            Int64 verticesCount = shopePoints.Count+1;
            Int64 edgesCount =Convert.ToInt64(Math.Round(Math.Pow(shopePoints.Count, 2)))+shopePoints.Count;
            Graph graph = CreateGraph(verticesCount, edgesCount);
            // Weighted Graph from warehouse
            List<double> distancesAll = new List<double>();
            for (int i = 0; i < shopePoints.Count; i++)
            {
                graph.edge[i].Source = 0;
                graph.edge[i].Destination = i + 1;
                double distance = getRoutesDistance(warehousePoint, shopePoints[i]);
                graph.edge[i].Weight = Convert.ToInt64(distance);
                distancesAll.Add(distance);
            }
            // Weighted graph from each vertice 
            int count=shopePoints.Count-1;
            for (int i = 0; i < shopePoints.Count; i++)
            {
                for (int j = 0; j < shopePoints.Count; j++)
                {
                    graph.edge[count].Source = i + 1;
                    graph.edge[count].Destination = j+1;
                    double distance = getRoutesDistance(shopePoints[i], shopePoints[j]);
                    graph.edge[count].Weight = Convert.ToInt64(distance);
                    distancesAll.Add(distance);
                    count++;

                }
            }
            RoutesDL.storeAllRecordIntoFile(FilePath.Routes, distancesAll);
            Int64[] dis=Bellman_Ford(graph, 0);
            for(int i=0; i < dis.Length; i++)
            {
                MessageBox.Show(dis[i].ToString());
            }
            //List<int> indexList=getSortedArrayIndex(dis);
            //displayRoutes(warehousePoint, shopePoints[indexList[0]],1);
            //for (int i = 1; i < indexList.Count-2; i++)
            //{
            //    displayRoutes(shopePoints[indexList[i]], shopePoints[indexList[i+1]],i+1);
            //}
        }
        public List<PointLatLng> listofPoints()
        {//These point are list of shopes
            List<PointLatLng> points = new List<PointLatLng>();
            PointLatLng point1 = new PointLatLng(31.586938529376354, 74.33842789178762);
            PointLatLng point2 = new PointLatLng(31.589570616301724, 74.3628896364054);
            PointLatLng point3 = new PointLatLng(31.58869326225471, 74.38494812190282);
            PointLatLng point4 = new PointLatLng(31.573923229204773, 74.36331878981973);
            PointLatLng point5 = new PointLatLng(31.587889013787468, 74.32615410413729);
            points.Add(point1);
            points.Add(point2);
            points.Add(point3);
            points.Add(point4);
            points.Add(point5);
            return points;
        }
        public List<int> getSortedArrayIndex(Int64[] unsortedArray)
        {
            List<int> indexList = new List<int>();
            Int64[] temp = new Int64[unsortedArray.Length];
            for(int i = 0; i < unsortedArray.Length; i++)
            {
                temp[i] = unsortedArray[i];
            }
            Array.Sort(unsortedArray);
            for(int i = 0; i < unsortedArray.Length; i++)
            {
                for (int j = 0; j < unsortedArray.Length; j++)
                {
                    if (unsortedArray[i] == temp[j])
                    {
                        indexList.Add(j);
                    }
                }
                
            }
            return indexList;

        }
        public void addMarker(PointLatLng point,int priorityNo, GMarkerGoogleType markerType = GMarkerGoogleType.arrow)
        {
            var markers = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(point, markerType);
            marker.ToolTipText = $"Latitude: {Math.Round(map.Position.Lat)},\n Longitude: {Math.Round(map.Position.Lng)},\n Priority  No {priorityNo}";

            var tooltip = new GMapToolTip(marker)
            {
                Fill = new SolidBrush(Color.DarkBlue),
                Foreground = new SolidBrush(Color.White),
                Offset = new Point(10, -50),
                Stroke = new Pen(new SolidBrush(Color.Red),2)
            };
            marker.ToolTip = tooltip;
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
        }
        public double getRoutesDistance(PointLatLng start, PointLatLng end)
        {
            var route = GoogleMapProvider.Instance.GetRoute(start, end, false, false, 15);
            return route.Distance;

        }
        public void displayRoutes(PointLatLng start, PointLatLng end,int priorityNo)
        {
            addMarker(start, priorityNo, GMarkerGoogleType.blue);
            addMarker(end, priorityNo, GMarkerGoogleType.blue);
            var route = GoogleMapProvider.Instance.GetRoute(start, end, false, false, 15);
            //Add GMap Reference
            var r = new GMapRoute(route.Points, "MY Route");
            r.Stroke = new Pen(Color.Red, 1);
            //Add route into the map      
            var routes = new GMapOverlay("routes");
            routes.Routes.Add(r);
            map.Overlays.Add(routes);
            
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
        public void setPoitionbyKeyword(string loactionName)
        {
            map.SetPositionByKeywords(loactionName);
        }

        //private void map_MouseClick(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        var point = map.FromLocalToLatLng(e.X, e.Y);
        //        double lat = point.Lat;
        //        double lng = point.Lng;

        //        map.Position = point;

        //        var markers = new GMapOverlay("markers");
        //        var marker = new GMarkerGoogle(point, GMarkerGoogleType.blue);
        //        markers.Markers.Add(marker);
        //        map.Overlays.Add(markers);
        //        //Get Address
        //        List<string> addresses = getAddress(point);
        //        lblMessage.Text = addresses[0].ToString();
        //    }
       // }
        //private List<string> getAddress(PointLatLng point)
        //{
        //    List<Placemark> placemarks = null;
        //    GeoCoderStatusCode statusCode = GMapProviders.GoogleMap.GetPlacemarks(point, out placemarks);
        //    if (statusCode == GeoCoderStatusCode.OK && placemarks != null)
        //    {
        //        List<string> address = new List<string>();
        //        foreach (var placemark in placemarks)
        //        {
        //            address.Add(placemark.Address);
        //        }
        //        return address;
        //    }
        //    return null;
        //}
        //-----------------------------------Algorithum--------------------------------------------------
        public struct Edge
        {
            public Int64 Source;
            public Int64 Destination;
            public Int64 Weight;
        }

        public struct Graph
        {
            public Int64 VerticesCount;
            public Int64 EdgesCount;
            public Edge[] edge;
        }

        public static Graph CreateGraph(Int64 verticesCount, Int64 edgesCount)
        {
            Graph graph = new Graph();
            graph.VerticesCount = verticesCount;
            graph.EdgesCount = edgesCount;
            graph.edge = new Edge[graph.EdgesCount];

            return graph;
        }
        public static Int64[] Bellman_Ford(Graph graph, Int64 source)
        {
            Int64 verticesCount = graph.VerticesCount;
            Int64 edgesCount = graph.EdgesCount;
            Int64[] distance = new Int64[verticesCount];

            for (int i = 0; i < verticesCount; i++)
                distance[i] = int.MaxValue;

            distance[source] = 0;

            for (int i = 1; i <= verticesCount - 1; ++i)
            {
                for (int j = 0; j < edgesCount; ++j)
                {
                    Int64 u = graph.edge[j].Source;
                    Int64 v = graph.edge[j].Destination;
                    Int64 weight = graph.edge[j].Weight;
                    if (distance[u] != Int64.MaxValue && distance[u] + weight < distance[v])
                        distance[v] = distance[u] + weight;
                }
            }

            for (int i = 0; i < edgesCount; ++i)
            {
                Int64 u = graph.edge[i].Source;
                Int64 v = graph.edge[i].Destination;
                Int64 weight = graph.edge[i].Weight;

                //if (distance[u] != int.MaxValue && distance[u] + weight < distance[v])
                    //Console.WriteLine("Graph contains negative weight cycle.");
            }

           return distance;
        }

        private void map_Load(object sender, EventArgs e)
        {

        }
    }

}
