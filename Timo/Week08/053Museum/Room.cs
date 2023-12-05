namespace Timo.Week08._053Museum
{
    public abstract class Room
    {
        private static Random rnd = new();
        protected string _Name;
        private List<Room> _Neighbours;
        private List<Visitor> _Visitors;
        protected int _DistanceToExit;
        public List<Artwork> Artworks = new();

        public int DistanceToExit { get => _DistanceToExit; }
        public List<Room> Neighbours { get => _Neighbours; }
        public List<Visitor> Visitors { get => _Visitors; }
        public string Name { get => _Name; }
        protected Room(string name, int distanceToExit)
        {
            _Name = name;
            _Neighbours = new List<Room>();
            _Visitors = new List<Visitor>();
            _DistanceToExit = distanceToExit;
        }

        protected abstract void PrintMyself(string prefix);

        public Room GetRandomNeighbour()
        {
            Room result = null;
            if (_Neighbours.Count > 0)
            {
                result = _Neighbours[rnd.Next(_Neighbours.Count)];
            }
            return result;
        }
        public Room GetFastestExit()
        {
            Room closest = _Neighbours[0];
            foreach (var n in _Neighbours)
            {
                if (closest.DistanceToExit > n.DistanceToExit)
                {
                    closest = n;
                }
            }
            return closest;
        }
        public abstract Artwork GetRandomArtwork();
        public abstract void PrintAction(Visitor v);
        public void EnterVisitor(Visitor v)
        {
            if (!_Visitors.Contains(v))
            {
                _Visitors.Add(v);
                Console.WriteLine($"{v.Name} enter {_Name}");
            }
        }

        public void ExitVisitor(Visitor v)
        {
            if (_Visitors.Contains(v))
            {
                _Visitors.Remove(v);
            }
        }

        public void AddNeighour(Room anotherRoom)
        {
            if (!_Neighbours.Contains(anotherRoom))
            {
                _Neighbours.Add(anotherRoom);
                anotherRoom.AddNeighour(this);
            }
        }

        public void PrintStructure(string prefix, List<Room> visited)
        {
            if (!visited.Contains(this))
            {
                visited.Add(this);
                PrintMyself(prefix);
                Console.Write(" Neighbours: ");
                bool first = true;
                foreach (Room r in _Neighbours)
                {
                    if (!first)
                    {
                        Console.Write(", ");
                    }
                    first = false;
                    Console.Write(r._Name);
                }
                Console.WriteLine();

                foreach (Room r in _Neighbours)
                {
                    r.PrintStructure(prefix, visited);
                }
            }
        }
    }
}