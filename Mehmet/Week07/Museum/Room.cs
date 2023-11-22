using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week07.Museum
{
    public abstract class Room 
    {
        private string _Name;
        private List<Room> _RoomNeighbours = new();
        private List<Human> _HumansList = new();

        public string name { get => _Name; }

        public Room(string name)
        {
            _Name = name;
        }

        public void AddRoom(Room room)
        {
            _RoomNeighbours.Add(room);
        }
        
        public void AddHuman(Human human)
        {
            _HumansList.Add(human);
        }

        public void RemoveHuman(Human human)
        {
            _HumansList.Remove(human);
        }

        public List<Room> GetRoomNeighbours()
        {
            return _RoomNeighbours;
        }

        public void CheckHuamList()
        {
            for (int i = _HumansList.Count - 1; i >= 0; i--)
            {
                Human human = _HumansList[i];
                human.RandomNextRoom();
            }
            
        }


    }
}
