using System;
using System.Collections.Generic;

namespace GraphProcessor.GraphStructures
{
    public class AdjacencyList
    {
        public Dictionary<Vertex, List<Vertex>> Vertices { get; set; }

        public AdjacencyList()
        {
            this.Vertices = new Dictionary<Vertex, List<Vertex>>();
        }

        public void AddVertex(Vertex newVertex, Vertex[] AdjacentVertices)
        {
            if (Vertices.Count > 0)
            {
                foreach (var vertex in Vertices)
                {
                    if (newVertex.Name == vertex.Key.Name)
                    {
                        throw new Exception("Vertex already exists in graph");
                    }
                }
            }

            var adjacentVerticesAsList = new List<Vertex>();

            foreach (var vertex in AdjacentVertices)
            {
                adjacentVerticesAsList.Add(vertex);
            }

            Vertices.Add(newVertex, adjacentVerticesAsList);
        }

        public void PopulateAdjacencyListFromJSON(string path = @"E:/Downloads pesadowns/GraphProcessor/GraphProcessor/GraphProcessor/testJSON.json")
        {
            string text = System.IO.File.ReadAllText(path);
            var primitiveList = Helpers.DeserializeJSON<PrimitiveAdjacencyList>(text);

            foreach (var vertex in primitiveList.vertices)
            {

                var newVertex = new Vertex(vertex.Key);
                var verticesAdjacentToNewVertex = new List<Vertex>();

                foreach (var existingVertex in Vertices)
                {
                    if (newVertex.Name == existingVertex.Key.Name)
                    {
                        throw new Exception("Error while creating adjacency list from JSON: Vertex already exists in graph");
                    }
                }

                foreach (var adjacentVertex in vertex.Value)
                {
                    verticesAdjacentToNewVertex.Add(new Vertex(adjacentVertex));
                }

                Vertices.Add(newVertex, verticesAdjacentToNewVertex);
            }

            Console.WriteLine("Test");
        }

        private class PrimitiveAdjacencyList
        {
            public Dictionary<string, List<string>> vertices { get; set; }
        }
    }
}
