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
		private List<Enclosure> _Enclosures;

		public Zoo(string name, string locality, int foundingYear, int capacity)
		{
			_Name = name;
			_Locality = locality;
			_FoundingYear = foundingYear;
			_Capacity = capacity;
			_Enclosures = new();
		}

		public void AddEnclosures(Enclosure enc)
		{
			_Enclosures.Add(enc);
		}

		public void PrintZoo()
		{
			Console.WriteLine($"{_Name}, {_Locality}, {_FoundingYear}, {_Capacity}");
			foreach (Enclosure enc in _Enclosures)
			{
				enc.PrintEnclosure();
			}
		}
	}
}

