using System;
namespace Gyula.Week08.MuseumSim
{
	public class Guest
	{
		private string _Name;
		private Room _CurrentLocation;

		public string Name { get => _Name; }

		public Guest(string name)
		{
			_Name = name;
			_CurrentLocation = null;
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
		}
	}
}

