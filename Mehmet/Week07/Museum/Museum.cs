using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week07.Museum
{
    public class Museum
    {
        private string _Name;
        private List<Room> _RoomList = new();



        public Museum(string name)
        {
            _Name = name;
        }

        public void AddRoom(Room room)
        {
            _RoomList.Add(room);
        }

        public void Simulation()
        {
            foreach (Room room in _RoomList)
            {
                room.CheckHuamList();

            }

        }


    }
}
