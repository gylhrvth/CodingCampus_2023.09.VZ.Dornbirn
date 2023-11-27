using System;
namespace Mohammed.Week08.MuseumNew
{
	public class Person
	{
        private static Random random = new Random();

        private string _Name;
        private Room _CurrentRoom;
        private int _TimeToLeave;

        public string Name
        {
            get => _Name;
        }

        public Person(string name)
        {
            _Name = name;
            _CurrentRoom = null;
            _TimeToLeave = 0;
        }

        public void MoveToRoom(Room r)
        {
            if (r != _CurrentRoom)
            {
                if (_CurrentRoom != null)
                {
                    _CurrentRoom.PersonExit(this);
                }
                _CurrentRoom = r;
                _CurrentRoom.PersonEntry(this);
                _TimeToLeave = random.Next(4);
            }
        }
        
        public void Tick()
        {
            if (_TimeToLeave > 0)
            {
                --_TimeToLeave;
                Console.WriteLine($"{_Name} ist thinking...");
            }
            else
            {
                Room nextRoom = _CurrentRoom.GetRandomNeighbouringRoom();
                if (nextRoom == null)
                {
                    Console.WriteLine("I'm trapped. PANIC!!!");
                }
                else
                {
                    MoveToRoom(nextRoom);
                }
            }

        }
    }
}

