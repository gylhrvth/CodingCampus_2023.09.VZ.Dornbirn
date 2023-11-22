using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.Museum
{
    public class Room
    {
        private List<Room> _RoomList;
        private string _Name;

        public Room(string name)
        {
            _RoomList = new List<Room>();
            _Name = name;
        }

        public void AddRoom(ExhibitionRoom room)
        {
            if (!_RoomList.Contains(room))
            {
                _RoomList.Add(room);
                
            }
        }

        public void AddRoom(Hallway hallway)
        {
            if (!_RoomList.Contains(hallway))
            {
                _RoomList.Add(hallway);
            }
        }

    }
}
