
namespace Fabian.Week07.RoomExample
{
    internal class ChildRoom : Room
    {
        public ChildRoom(string name, int size) : base(name, size)
        {
        
        }

        public override void PrintRoomInfo()
        {
            Console.WriteLine($"{_Name} has a size of: {_Size} m^2");
        }
    }
}
