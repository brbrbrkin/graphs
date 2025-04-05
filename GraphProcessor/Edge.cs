using System;
using QuikGraph;

namespace GraphProcessor
{
    public class Edge : IEdge<Vertex>
    {
        public string Id { get; set; }
        public Vertex Source { get; set; }
        public Vertex Target { get; set; }

        public Edge(Vertex SourceVertex, Vertex TargetVertex)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Source = SourceVertex;
            this.Target = TargetVertex;
        }
    }
}
