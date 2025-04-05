using System;
using GraphProcessor.GraphStructures;

namespace GraphProcessor
{
    public class InputMenu
    {
        public static void MainMenu()
        {
            var keepGoing = true;

            while (keepGoing)
            {
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Criar grafo a partir de lista de arestas");
                Console.WriteLine("2. Criar grafo a partir de lista de adjacência");

                var decision = Console.ReadLine();

                switch (decision)
                {
                    case "1":
                        var edgeListGraph = EdgeListGraphAdapter.CreateGraphFromEdgeList();
                        EdgeListGraphAdapter.ShowEdgeListGraphStats(edgeListGraph);
                        break;
                    case "2":
                        var adjacencyListGraph = EdgeListGraphAdapter.CreateGraphFromEdgeList();
                        EdgeListGraphAdapter.ShowEdgeListGraphStats(adjacencyListGraph);
                        break;
                    case "0":
                        keepGoing = false;
                        break;
                    default:
                        continue;
                }
            }
        }

    }
}
