using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week08.FileSystem
{
    public class Node
    {
        private int _xCoord;
        private int _yCoord;
        private List<Node> _Neighbors = new List<Node>();
        private bool _IsSolution = false;
        private int _CurrentDistance = int.MaxValue;

        public Node(int yCoord, int xCoord)
        {
            _xCoord = xCoord;
            _yCoord = yCoord;
        }

        public int xCoord { get => _xCoord; }
        public int yCoord { get => _yCoord; }
        public List<Node> Neighbors { get => _Neighbors; }
        public bool IsSolution { get => _IsSolution; }
        public int CurrentDistance { get => _CurrentDistance; }

        public void AddNeighbor(Node neighbor)
        {
            _Neighbors.Add(neighbor);
        }

        public void MakeSolution()
        {
            _IsSolution = true;
        }

        public void UnmakeSolution()
        {
            _IsSolution = false;
        }

        public void SetDistance(int distance)
        {
            _CurrentDistance = distance;
        }
    }




    public class Graph
    {
        List<Node> _Nodes = new List<Node>();

        public Graph()
        {

        }

        public List<Node> Nodes { get => _Nodes; }

        public void AddNode(Node node)
        {
            _Nodes.Add(node);
        }
    }
}
