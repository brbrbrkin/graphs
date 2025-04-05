using System;
using QuikGraph;
using static GraphProcessor.Helpers;

namespace GraphProcessor.GraphStructures
{
    public class EdgeListGraphAdapter
    {

        public static EdgeListGraph<Vertex, Edge> CreateGraphFromEdgeList()
        {
            var keepGoing = true;
            var graph = new EdgeListGraph<Vertex, Edge>();

            while (keepGoing)
            {
                Console.WriteLine("Digite o nome do vertice");
                var firstVertex = new Vertex(Console.ReadLine());

                Console.WriteLine("Digite o nome do segundo vertice");
                var secondVertex = new Vertex(Console.ReadLine());

                foreach (var vertex in graph.Vertices)
                {
                    if (vertex.Name == firstVertex.Name)
                    {
                        firstVertex = vertex;
                    }
                    else if (vertex.Name == secondVertex.Name)
                    {
                        secondVertex = vertex;

                    }
                }

                var newEdge = new Edge(firstVertex, secondVertex);

                if (!graph.ContainsEdge(newEdge))
                {
                    graph.AddEdge(newEdge);
                }

                Console.WriteLine("Deseja parar? s/n");
                var answer = Console.ReadLine();

                while (true)
                {
                    if (CheckValidAnswer(new string[] { "s", "S", "n", "N" }, answer))
                    {
                        break;
                    }
                    Console.WriteLine("Deseja parar? s/n");
                    answer = Console.ReadLine();
                }


                if (Helpers.CheckValidAnswer(new string[] { "s", "S" }, answer))
                {
                    keepGoing = false;
                }
            }
            return graph;
        }

        public static void ShowEdgeListGraphStats(EdgeListGraph<Vertex, Edge> graph)
        {

            Console.WriteLine("Vertices: " + graph.VertexCount);
            Console.WriteLine("Arestas: " + graph.EdgeCount);
            Console.WriteLine("É direcionado? " + graph.IsDirected);
        }
    }
}
