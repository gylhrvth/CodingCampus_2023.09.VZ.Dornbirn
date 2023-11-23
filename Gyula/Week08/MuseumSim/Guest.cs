using System;
namespace Gyula.Week08.MuseumSim
{
	public class Guest
	{
		private static Random rand = new Random();

		private string _Name;
		private Room _CurrentLocation;
		private int _TimeLeft;

		public string Name { get => _Name; }

		public Guest(string name)
		{
			_Name = name;
			_CurrentLocation = null;
			_TimeLeft = 0;
		}

		public void MoveTo(Room room)
		{
			if (room == _CurrentLocation)
			{
				return;
			}

			if (_CurrentLocation != null)
			{
				_CurrentLocation.exitGuest(this);
			}

			_CurrentLocation = room;
			_CurrentLocation.enterGuest(this);
			_TimeLeft = rand.Next(3);
		}


		public void Tick()
		{
			if (_TimeLeft > 0)
			{
				--_TimeLeft;
				Console.WriteLine("Do nothing...");
			}
			else
			{
                Room nextRoom = _CurrentLocation.GetRandomNeighbouringRoom();
                if (nextRoom == null)
                {
                    Console.WriteLine($"{_Name} is blocked in {_CurrentLocation.Name}");
                }
                else
                {
                    MoveTo(nextRoom);
                }
            }
        }
	}
}

