using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.MuseumNew
{
    public class Museum
    {
        private string _Name;
        private List<Room> _RoomList;

        public Museum(string name)
        {
            _Name = name;
            _RoomList = new List<Room>();
            
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
            foreach(Room room in _RoomList)
            {
                room.PrintRoomList();
            }
        }


    }
}
