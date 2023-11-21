
namespace Fabian.Week07.RoomExample
{
    public class RoomMain
    {
        public static void Start()
        {
            List<ChildRoom> rooms = new List<ChildRoom>()
            {
                new ChildRoom("Ben's room", 20, 1),
                new ChildRoom("Anna's room", 30, 2)
            };
            foreach (var room in rooms)
            {
                room.PrintRoomInfo();
            }
        }
    }
}
