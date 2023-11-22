using System;
namespace Mohammed.Week07.Zoo02
{
	public class ZooKeeper
	{
		private string _Name;
		private List<Enclosure> _EnclosuresList;
		private Animals _Favoriteanimal;

		public Animals FavoriteAnimal
		{
			get => _Favoriteanimal;
		}

		public ZooKeeper(string name)
		{
			_Name = name;
			_EnclosuresList = new List<Enclosure>();
            _Favoriteanimal = FavoriteAnimal;
        }

		public void PrintZooKeeper()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"    ├──Zookeeper: {_Name}");
			foreach (Enclosure enclosure in _EnclosuresList)
			{
				enclosure.PrintEnclosure();
			}
		}

		public void AddEnclosure(Enclosure enclosure)
		{
			if (!_EnclosuresList.Contains(enclosure))
			{
				_EnclosuresList.Add(enclosure);
			}
		}

		public void EnclosureToFeed()
		{
			foreach(Enclosure enclosure in _EnclosuresList)
			{
				if (!enclosure.IsFaid)
				{
					Console.WriteLine($"{_Name} is feeding the {enclosure.Name} enclosure");
					enclosure.IsFaid = true;
				}
				else
				{
					Console.WriteLine($"{_Name} tried to feed the {enclosure.Name} enclosure but is´s already fed");
				}
				Console.WriteLine($"{_Name} is spectating his favourite animal: {_Favoriteanimal}");
			}
		}
        
    }
}

