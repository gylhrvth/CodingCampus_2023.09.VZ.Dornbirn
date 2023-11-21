
namespace Fabian.Week07.RoomExample
{
    internal abstract class Room
    {
        protected string _Name;
        protected double _Size;

        public Room(string name, double size)
        {
            _Name = name;
            _Size = size;
        }

        public abstract void PrintRoomInfo();
    }
}
