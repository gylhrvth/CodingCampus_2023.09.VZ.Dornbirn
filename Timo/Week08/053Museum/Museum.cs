namespace Timo.Week08._053Museum
{
    public class Museum
    {
        private Random rnd = new Random();
        private string _Name;
        private Hallway _Entrance;
        private List<Visitor> _Visitors;

        public List<Visitor> Visitors { get => _Visitors; set => _Visitors = value; }
        public Museum(string name, Hallway entrance)
        {
            _Name = name;
            _Visitors = new List<Visitor>();
            _Entrance = entrance;
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

        public static List<T> RandomizeList<T>(List<T> list)
        {
            Random random = new();
            for (int i = 0; i < list.Count; i++)
            {
                int index = random.Next(i, list.Count);
                (list[i], list[index]) = (list[index], list[i]);
            }
            return list;
        }

        public void Tick()
        {
            List<Visitor> visitorsToRemove = new();
            _Visitors = RandomizeList(_Visitors);
            foreach (Visitor v in _Visitors)
            {
                v.Tick(visitorsToRemove);
                Thread.Sleep(50);
            }
            foreach (var v in visitorsToRemove)
            {
                _Visitors.Remove(v);
            }
        }

        public void LeaveMuseum()
        {
            List<Visitor> visitorsToRemove = new();
            _Visitors = RandomizeList(_Visitors);
            foreach (Visitor v in _Visitors)
            {
                v.LeaveMuseum(visitorsToRemove);
                Thread.Sleep(275);
            }
            foreach (var v in visitorsToRemove)
            {
                _Visitors.Remove(v);
            }
        }
    }
}



