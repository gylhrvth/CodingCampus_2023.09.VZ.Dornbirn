
namespace Fabian.Week08._05_Museum
{
    public abstract class Room
    {
        protected string _Name;
        private List<Room> _Neighbours;
        private List<Visitor> _Visitors;

        protected Room(string name)
        {
            _Name = name;
            _Neighbours = new List<Room>();
            _Visitors = new List<Visitor>();
        }

        protected abstract void PrintMyself(string prefix);

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