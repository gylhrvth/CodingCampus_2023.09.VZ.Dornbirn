using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.MuseumNew
{
    public class Room
    {
        private static Random rand = new Random();

        private string _Name;
        protected List<Room> _NeighbourRoomList;
        private List<Person> _PersonInRoomList;
        private List<Artwork> _ArtworkList;

        public Room(string name)
        {
            _Name = name;
            _NeighbourRoomList = new List<Room>(); 
            _PersonInRoomList = new List<Person>();
            _ArtworkList = new List<Artwork>();
        }   


        public void AddNeighbourList(Room room)
        {
            if (!_NeighbourRoomList.Contains(room))                
            {
                _NeighbourRoomList.Add(room);
                room.AddNeighbourList(this);
            }
        }

        public void PrintRoomList()
        {
            Console.Write("\t Der Raum: {0,-20}" + " befindet sich neben den Räumen: ", _Name);
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

        public void PersonEntry(Person person)
        {
            if (!_PersonInRoomList.Contains(person))
            {
                _PersonInRoomList.Add(person);
                Console.WriteLine($"{person.Name} betritt {_Name}");
            }         
        }

        public void PersonExit(Person person)
        {
            if (_PersonInRoomList.Contains(person))
            {
                _PersonInRoomList.Remove(person);
                //Console.WriteLine($"{person.Name} verlässt {_Name}");
            }
        }
        

        public Room GetRandomNeighbouringRoom()
        {
            Room result = null;

            if (_NeighbourRoomList.Count > 0)
            {
                result = _NeighbourRoomList[rand.Next(_NeighbourRoomList.Count)];
            }

            return result;
        }

        public override string ToString()
        {
            return _Name;
        }

    }
}
