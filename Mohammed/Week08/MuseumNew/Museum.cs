using System;
namespace Mohammed.Week08.MuseumNew
{
	public class Museum
	{
        private string _Name;
        private List<Room> _RoomList;
        private Room _MainEntry;
        private List<Person> _PersonInMuseumList;

        public Museum(string name, HallwayMain mainEntry)
        {
            _Name = name;
            _RoomList = new List<Room>();
            _PersonInMuseumList = new List<Person>();
            _MainEntry = mainEntry;
        }
        public void AddRoom(Room room)
        {
            if (!_RoomList.Contains(room))
            {
                _RoomList.Add(room);
            }
        }

        public void PrintStructure()
        {
            Console.WriteLine($"Museum: {_Name} ");
            foreach (Room room in _RoomList)
            {
                room.PrintRoomList();
            }
            Console.WriteLine();
        }

        public void EnterNewPerson(Person person)
        {
            if (!_PersonInMuseumList.Contains(person))
            {
                _PersonInMuseumList.Add(person);
            }
            person.MoveToRoom(_MainEntry);
        }

        public void Tick()
        {
            foreach (Person person in _PersonInMuseumList)
            {
                person.Tick();
            }
        }
    }
}

