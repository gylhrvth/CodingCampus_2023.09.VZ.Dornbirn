﻿using System;
namespace Gyula.Week08.MuseumSim
{
	public abstract class Room
	{
        protected string _Name;
		private List<Room> _Neighbours;
		private List<Guest> _Guests;
 
        protected Room(string name)
		{
			_Name = name;
			_Neighbours = new List<Room>();
			_Guests = new List<Guest>();
		}

		public void enterGuest(Guest g)
		{
            if (!_Guests.Contains(g))
            {
                _Guests.Add(g);
				Console.WriteLine($"{g.Name} enter {_Name}");
            }
        }

		public void exitGuest(Guest g)
		{
			if (_Guests.Contains(g))
			{
				_Guests.Remove(g);					
			}
		}

		public void addNeighour(Room anotherRoom)
		{
			if (!_Neighbours.Contains(anotherRoom))
			{
				_Neighbours.Add(anotherRoom);
				anotherRoom.addNeighour(this);
			}
		}

		protected abstract void PrintMyself(string prefix);

		public void PrintStructure(string prefix, List<Room> visited)
		{
			if (!visited.Contains(this)) {
                visited.Add(this);
				PrintMyself(prefix);
				Console.Write(" Nachbaren: ");
				bool first = true;
				foreach (Room r in _Neighbours)
				{
					if (!first)
					{
						Console.Write(", ");
					}
					first = false;
					Console.Write(r._Name);
				}
				Console.WriteLine();

				foreach (Room r in _Neighbours)
				{
					r.PrintStructure(prefix, visited);
				}
            }
        }
    }
}

