using System;
namespace Gyula.Week06.Zoo
{
	public class Enclosure
	{
		private string _Name; 

		public Enclosure(string name)
		{
			_Name = name;
		}

		public void PrintStructure(string prefix)
		{
			Console.WriteLine("{0}Enclosure: {1}",
				prefix,
				_Name);
		}
	}
}

