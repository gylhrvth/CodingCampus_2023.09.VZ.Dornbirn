
namespace Fabian.Week07._05_Hospital
{
    public class Room
    {
        private int _RoomNumber;
        private int _Beds;
        private int _BedsTaken;

        public int BedsTaken
        {
            get => _BedsTaken;
            set => _BedsTaken = value;
        }
        public int Beds { get => _Beds; }
        public int RoomNumber {  get => _RoomNumber; }
        public Room(int roomNumber, int beds)
        {
            _RoomNumber = roomNumber;
            _Beds = beds;
        }


    }
}
