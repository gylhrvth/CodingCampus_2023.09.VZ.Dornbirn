using System;
namespace Gyula.Week08.MuseumSim
{
	public class Hallway : Room
	{
		public Hallway(string name) : base(name)
		{
		}

        protected override void PrintMyself(string prefix)
        {
            Console.Write($"{prefix} Hallway: {_Name}");
        }
    }
}

