using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS_Algorithm
{
    class bfsModel
    {
        int queryId;
        int nodes;
        int edges;
        int sourceNode;
        List<verticeModel> vertices;

        public bfsModel()
        {
            vertices = new List<verticeModel>();
        }

        public bfsModel(int queryId, int nodes, int edges, int sourceNode, List<verticeModel> vertices)
        {
            this.queryId = queryId;
            this.nodes = nodes;
            this.edges = edges;
            this.vertices = vertices;
            this.SourceNode = sourceNode;
        }

        public int QueryId { get => queryId; set => queryId = value; }
        public int Nodes { get => nodes; set => nodes = value; }
        public int Edges { get => edges; set => edges = value; }
        public int SourceNode { get => sourceNode; set => sourceNode = value; }
        internal List<verticeModel> Vertices { get => vertices; set => vertices = value; }
    }
}
