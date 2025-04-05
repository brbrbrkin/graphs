using System;
using System.Collections.Generic;
using GraphProcessor.GraphStructures;
using QuikGraph;

namespace GraphProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            var testAdjacencyList = new AdjacencyList();

            var vertex1 = new Vertex("Vertex1");
            var vertex2 = new Vertex("Vertex2");
            var vertex3 = new Vertex("Vertex3");
            var vertex4 = new Vertex("Vertex4");


            testAdjacencyList.AddVertex(vertex1, new Vertex[] { vertex2, vertex3, vertex4 });
            testAdjacencyList.AddVertex(vertex2, new Vertex[] { vertex3, vertex4 });
            testAdjacencyList.AddVertex(vertex3, new Vertex[] { vertex2 });
            testAdjacencyList.AddVertex(vertex4, new Vertex[] { vertex2 });

            var secondAdjacencyList = new AdjacencyList();

            secondAdjacencyList.PopulateAdjacencyListFromJSON();
        }
    }
}
