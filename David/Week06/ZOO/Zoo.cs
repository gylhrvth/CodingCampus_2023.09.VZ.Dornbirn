using System;
using System.Runtime.CompilerServices;

namespace David.Week06.ZOO
{
	public class Zoo
	{
		public object MyProperty { get; set; }
		private string _Name;
		private string _Locality;
		private int _FoundingYear;
		private int _Capacity;
		private List<Enclosure> _Enclosure;

		public Zoo(string name, string locality, int foundingYear, int capacity)
		{
			_Name = name;
			_Locality = locality;
			_FoundingYear = foundingYear;
			_Capacity = capacity;
			_Enclosure = new();
		}

		public void AddEnclosure(Enclosure enc)
		{
			_Enclosure.Add(enc);
		}

		public void PrintZoo()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine($"{_Name}, {_Locality}, {_FoundingYear}, {_Capacity}");

			foreach (Enclosure enc in _Enclosure)
			{
				enc.PrintEnclosure();
			}
		}
	}
}

