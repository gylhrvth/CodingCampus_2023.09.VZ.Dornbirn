using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.MuseumNew
{
    public class Room
    {
        private string _Name;
        private List<Room> _NeighbourRoomList;

        public Room(string name)
        {
            _Name = name;
            _NeighbourRoomList = new List<Room>(); 
        }   

        public void AddNeighbour(Room room)
        {
            if (!_NeighbourRoomList.Contains(room))                
            {
                _NeighbourRoomList.Add(room);
                room.AddNeighbour(this);
            }
        }

        public void PrintRoomList()
        {

            Console.Write("\t Raum: {0,-20}" + " hat die Nachbarn: ", _Name);
            bool first = true;
            foreach (Room room in _NeighbourRoomList)
            {
                if (!first)
                {
                    Console.Write(", ");
                }
                first = false;
                Console.Write(room._Name);
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            return _Name;
        }

    }
}
