using System;
using QuikGraph;

namespace GraphProcessor.GraphStructures
{
    public class AdjacencyGraphAdapter
    {
        public static AdjacencyGraph<Vertex, Edge> CreateGraphFromAdjacencyList()
        {
            var keepGoing = true;
            var graph = new AdjacencyGraph<Vertex, Edge>();

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
                    if (Helpers.CheckValidAnswer(new string[] { "s", "S", "n", "N" }, answer))
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

    }
}
