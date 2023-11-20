
namespace Fabian.Week07.RoomExample
{
    internal class ChildRoom : Room
    {
        private int _Kids;
        public ChildRoom(string name, int size, int kids) : base(name, size)
        {
            _Kids = kids;
        }

        public override void PrintRoomInfo()
        {
            Console.WriteLine($"{_Name} has a size of: {_Size} m^2 and place for {_Kids} kids");
        }
    }
}
