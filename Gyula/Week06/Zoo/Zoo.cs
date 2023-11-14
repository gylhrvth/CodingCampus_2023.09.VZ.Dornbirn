using System;
namespace Gyula.Week06.Zoo
{
	public class Zoo
	{
		private string _Name;
		private int _Founded;
		private List<Enclosure> _Enclosures;


		public Zoo(string name, int founded)
		{
			_Name = name;
			_Founded = founded;
			_Enclosures = new List<Enclosure>();
		}

		public void addEnclosure(Enclosure enc)
		{
			_Enclosures.Add(enc);
		}

		public void PrintStructure(string prefix)
		{
			Console.WriteLine("{0}Zoo: {1} founded in {2}",
				prefix,
				_Name,
				_Founded);
			foreach (Enclosure enc in _Enclosures)
			{
				enc.PrintStructure("|   " + prefix);
			}
		}
	}
}

