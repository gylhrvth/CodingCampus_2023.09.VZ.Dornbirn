using static Timo.ColorOfConsole;
namespace Timo.Week08._053Museum
{
    public class Visitor
    {
        private Random rnd = new();
        protected string _Name;
        private int _TimeLeft;

        public Room _CurrentLocation { get; set; }
        public string Name { get => _Name; set => _Name = value; }
        public Visitor(string name)
        {
            _Name = name;
            _CurrentLocation = null;
            _TimeLeft = 0;
        }

        public virtual void MoveTo(Room room)
        {
            if (room == _CurrentLocation)
            {
                return;
            }
            if (_CurrentLocation != null)
            {
                _CurrentLocation.ExitVisitor(this);
            }
            _CurrentLocation = room;
            _CurrentLocation.EnterVisitor(this);
            _TimeLeft = rnd.Next(2);
        }

        public virtual void Tick(List<Visitor> list)
        {
            if (_TimeLeft > 0)
            {
                --_TimeLeft;
            }
            else
            {
                Steal();
                Room nextRoom = _CurrentLocation.GetRandomNeighbour();
                if (nextRoom == null)
                    Console.WriteLine($"{_Name} is blocked in {_CurrentLocation.Name}");
                else if (nextRoom.Name == "exit")
                {
                    SetConsoleColor(ConsoleColor.Red, $"{_Name} left the museum");
                    _CurrentLocation.ExitVisitor(this);
                    list.Add(this);
                    Console.WriteLine();
                }
                else
                {
                    MoveTo(nextRoom);
                    _CurrentLocation.PrintAction(this);
                    Console.WriteLine();
                }
            }
        }

        public virtual void Steal()
        {
        }
        public void LeaveMuseum(List<Visitor> list)
        {
            Room nextRoom = _CurrentLocation.GetFastestExit();
            if (nextRoom == null)
            {
                Console.WriteLine($"{_Name} is blocked in {_CurrentLocation.Name}");
            }
            else if (nextRoom.Name == "exit")
            {
                SetConsoleColor(ConsoleColor.Red, $"{_Name} left the museum");
                _CurrentLocation.ExitVisitor(this);
                list.Add(this);
                Console.WriteLine();
            }
            else
            {
                MoveTo(nextRoom);
                Console.WriteLine();
            }
        }
    }
}