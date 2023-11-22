using System;
namespace Gyula.Week08.MuseumSim
{
	public class ExhibitionRoom : Room
	{
		public ExhibitionRoom(string name) : base(name)
		{
		}

        protected override void PrintMyself(string prefix)
        {
            Console.Write($"{prefix} Exhibition: {_Name}");
        }
    }
}

