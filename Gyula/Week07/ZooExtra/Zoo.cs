using System;
namespace Gyula.Week07.ZooExtra
{
	public class Zoo
	{
		private string _Name;
		private int _Established;
		private List<Enclosure> _EnclosureList;

		public Zoo(string name, int established)
		{
			_Name = name;
			_Established = established;
			_EnclosureList = new List<Enclosure>();
		}

		public void PrintStructure()
		{
			Console.WriteLine("├── Zoo: {0}, gegründet {1}",
				_Name,
				_Established);
			foreach (Enclosure enc in _EnclosureList)
			{
				enc.PrintStructure();
			}
		}

		public Enclosure SearchAndCreate(string name)
		{
			foreach (Enclosure enc in _EnclosureList)
			{
				if (enc.Name == name)
				{
					return enc;
				}
			}
			Enclosure newenc = new Enclosure(name);
			_EnclosureList.Add(newenc);
			return newenc;
		}
		
	}
}

