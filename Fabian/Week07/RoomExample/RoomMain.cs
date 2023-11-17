
namespace Fabian.Week07.RoomExample
{
    internal class RoomMain
    {
        public static void Start()
        {
            List<ChildRoom> rooms = new List<ChildRoom>()
            {
                new ChildRoom("Ben's room", 20),
                new ChildRoom("Anna's room", 30)
            };
            foreach (var room in rooms)
            {
                room.PrintRoomInfo();
            }
        }
    }
}
