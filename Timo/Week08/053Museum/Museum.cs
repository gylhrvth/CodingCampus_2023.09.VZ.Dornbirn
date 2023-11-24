
namespace Timo.Week08._053Museum
{
    public class Museum
    {
        private string _Name;
        private Hallway _Entrance;
        private List<Visitor> _Visitors;
        private int _Ticks;

        public int Ticks { get => _Ticks; set => _Ticks = value; }
        public Museum(string name, Hallway entrance)
        {
            _Name = name;
            _Visitors = new List<Visitor>();
            _Entrance = entrance;
            _Ticks = 0;
        }
        
        public void AddVisitor(Visitor v)
        {
            if (!_Visitors.Contains(v))
            {
                _Visitors.Add(v);
                v.MoveTo(_Entrance);
            }
                                    
        }

        public void PrintStructure(string prefix)
        {
            Console.WriteLine($"{prefix}Museum: {_Name}");
            List<Room> roomsVisited = new List<Room>();
            _Entrance.PrintStructure(prefix + "    ", roomsVisited);
        }     
    }
}
