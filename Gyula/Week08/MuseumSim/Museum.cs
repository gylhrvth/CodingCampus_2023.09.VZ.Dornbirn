using System;
namespace Gyula.Week08.MuseumSim
{
	public class Museum
	{
		private string _Name;
		private Hallway _Entrace;
		private List<Guest> _Guests;

		public Museum(string name, Hallway entrance)
		{
			_Name = name;
			_Entrace = entrance;
			_Guests = new List<Guest>();
		}

		public void PrintStructure(string prefix)
		{
			Console.WriteLine($"{prefix}Museum: {_Name}");
			List<Room> roomsVisited = new List<Room>();
			_Entrace.PrintStructure(prefix + "    ", roomsVisited);
        }

		public void AddGuest(Guest g)
		{
			if (!_Guests.Contains(g))
			{
				_Guests.Add(g);
                g.MoveTo(_Entrace);
            }
		}
	}
}

