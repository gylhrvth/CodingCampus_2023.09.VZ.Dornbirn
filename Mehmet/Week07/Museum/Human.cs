using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week07.Museum
{
    public class Human
    {
        private static Random rand = new Random();
        private string _Name;
        private Room _currentRoom;

        public Human(string name, Room currentRoom)
        {
            _Name = name;
            _currentRoom = currentRoom;
        }

        public void RandomNextRoom()
        {
            Console.WriteLine($"{_Name} is in {_currentRoom.name}!");
            _currentRoom.RemoveHuman(this);
            List<Room> list = _currentRoom.GetRoomNeighbours();

            int i = rand.Next(0, list.Count);
            _currentRoom = list[i];

            _currentRoom.AddHuman(this);
            Console.WriteLine($"{_Name} is now going to the {_currentRoom.name} Room!");


        }
    }
}
