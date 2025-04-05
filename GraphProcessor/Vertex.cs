using System;
namespace GraphProcessor
{
    public class Vertex
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Vertex(string Name = null)
        {
            this.Id = Guid.NewGuid().ToString();
            if (Name != null)
            {
                this.Name = Name;
            }
        }
    }
}
