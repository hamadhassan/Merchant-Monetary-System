using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System
{
    public static class BellmanFord
    {
        private static List<int> distance;

        public static List<int> Distance { get => distance; set => distance = value; }

        public static bool Bellman_Ford(Graph graph, int source)
        {
            int verticesCount = graph.VerticesCount;
            int edgesCount = graph.EdgesCount;
            distance = new List<int>();
            for (int i = 0; i < verticesCount; i++)
                distance[i] = int.MaxValue;

            distance[source] = 0;

            for (int i = 1; i <= verticesCount - 1; ++i)
            {
                for (int j = 0; j < edgesCount; ++j)
                {
                    int u = graph.Edge[j].Source;
                    int v = graph.Edge[j].Destination;
                    int weight = graph.Edge[j].Weight;

                    if (distance[u] != int.MaxValue && distance[u] + weight < distance[v])
                        distance[v] = distance[u] + weight;
                }
            }

            for (int i = 0; i < edgesCount; ++i)
            {
                int u = graph.Edge[i].Source;
                int v = graph.Edge[i].Destination;
                int weight = graph.Edge[i].Weight;

                if (distance[u] != int.MaxValue && distance[u] + weight < distance[v])
                    return false;
            }
            return true;
        }
    }
}
