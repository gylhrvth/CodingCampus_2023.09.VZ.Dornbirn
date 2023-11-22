using static Fabian.Selftest_SP.TowersOfHanoi;
namespace Fabian.Week08._05_Museum
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

        public void Simulation(int ticksPerSwitch)
        {
            List<Visitor> visitorsToRemove = new();
            int currentTick = 0;
            while (true)
            {
                _Visitors = RandomizeList(_Visitors);
                foreach (var v in _Visitors)
                {
                    if (v._CurrentLocation.Name == "exit")
                    {
                        SetConsoleColor(ConsoleColor.Red, $"{v.Name} left the museum");
                        v._CurrentLocation.ExitVisitor(v);
                        visitorsToRemove.Add(v);
                        Console.WriteLine();

                    }
                    currentTick++;
                    if (currentTick % ticksPerSwitch == 0)
                    {
                        int random = rnd.Next(v._CurrentLocation.Neighbours.Count);
                        v.MoveTo(v._CurrentLocation.Neighbours[random]);
                        v._CurrentLocation.PrintAction(v);
                        Console.WriteLine();
                    }
                }
                foreach (var v in visitorsToRemove)
                {
                    _Visitors.Remove(v);
                }
                
            }
        }
    }
}

