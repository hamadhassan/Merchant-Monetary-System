using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System
{
    public class Graph
    {
        private int verticesCount;
        private int edgesCount;
        private Edge[] edge;
        public  Graph (int verticesCount, int edgesCount)
        {
            this.verticesCount = verticesCount;
            this.edgesCount = edgesCount;
            edge = new Edge[edgesCount];
        }
        public int VerticesCount { get => verticesCount; set => verticesCount = value; }
        public int EdgesCount { get => edgesCount; set => edgesCount = value; }
        public Edge[] Edge { get => edge; set => edge = value; }
    }
}
