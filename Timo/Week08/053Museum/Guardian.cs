using static Timo.ColorOfConsole;
namespace Timo.Week08._053Museum
{
    public class Guardian : Visitor
    {
        private string _Name;
        private int _Speed;
        private int _TimeLeft;

        public Guardian(string name, int speed) : base(name)
        {
            _Name = name;
            _Speed = speed;
            _TimeLeft = 0;
        }

        public override void MoveTo(Room room)
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
            _TimeLeft = 1;
        }

        public override void Tick(List<Visitor> list)
        {
            if (_TimeLeft > 0)
            {
                --_TimeLeft;
            }
            else
            {
                Room nextRoom = _CurrentLocation.GetRandomNeighbour();
                if (nextRoom == null)
                {
                    Console.WriteLine($"{_Name} is blocked in {_CurrentLocation.Name}");
                }
                //else if (nextRoom.Name == "exit")
                //{
                //    SetConsoleColor(ConsoleColor.Red, $"{_Name} left the museum");
                //    _CurrentLocation.ExitVisitor(this);
                //    list.Add(this);
                //    Console.WriteLine();
                //}
                else
                {
                    MoveTo(nextRoom);
                    //_CurrentLocation.PrintAction(this);
                    Console.WriteLine();
                }
            }
        }
    }
}