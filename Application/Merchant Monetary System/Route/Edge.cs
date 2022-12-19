using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System
{
    public class Edge
    {
        private int source;
        private int destination;
        private int weight;

        public int Source { get => source; set => source = value; }
        public int Destination { get => destination; set => destination = value; }
        public int Weight { get => weight; set => weight = value; }
    }
}
