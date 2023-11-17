using System;
using System.Runtime.CompilerServices;
using David.Week06.ZOO;

namespace David.Week06.ZOO
{
	internal class Zoo
	{
	
		private string _Name;
		private string _Locality;
		private int _FoundingYear;
		private List<Enclosure> _EnclosureList;
		private List<ZooKeeper> _ZooKeeperList;

		//Properties
		public List<Enclosure> EnclosureList
		{
			get => _EnclosureList;
			set => _EnclosureList = value;
		}

		public List<ZooKeeper> ZooKeeperList
		{
			get => _ZooKeeperList;
			set => _ZooKeeperList = value;
		}

		public string Name
		{
			get => _Name;
			set => _Name = value;
		}

		public int FoundingYear
        {
			get => _FoundingYear;
			set => _FoundingYear = value;
		}

		//Konstruktor
		public Zoo(string name, string locality, int foundingYear)
		{
			_Name = name;
			_Locality = locality;
			_FoundingYear = foundingYear;
			_EnclosureList = new List<Enclosure>();
			_ZooKeeperList = new List<ZooKeeper>();
		}

		public void PrintZooStatistic()
		{
			Dictionary<Food, float> dict = new();

			foreach (var enclosure in _EnclosureList)
			{
				enclosure.GetEnclosureStatistic(dict);
			}
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("Total food intake per day:");
			Console.ResetColor();
			float cost = 0;
			foreach (Food food in dict.Keys)
			{
				Console.WriteLine($"{food._FoodName, -11} : {dict[food], -4} {food._UnitName} pro kg; {food._UnitPrice} € ");
				float amount = dict[food];
				float price = food._UnitPrice * amount;
				cost += price;
			}
			Console.WriteLine("______________");
			Console.WriteLine("Total cost / day: {0:N2}$", cost);
		}

		public void AddEnclosure(Enclosure enc)
		{
			_EnclosureList.Add(enc);
		}


		public void PrintZoo()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine($"{_Name}, {_Locality}, {_FoundingYear}");
			Console.ResetColor();
		}

		public void PrintStructure()
		{
			PrintZoo();
			foreach (var keeper in ZooKeeperList)
			{
				keeper.PrintZooKeeper();
			}
		}


        public void PrintListZooKeeper()
        {
            foreach (ZooKeeper zookeeper in ZooKeeperList)
            {

                Console.ForegroundColor = ConsoleColor.DarkRed;
				zookeeper.PrintZooKeeper(false);
                Console.ResetColor();
            }

        }

		//public void PrintZooKeeperWithResponsabilities()
		//{
		//	foreach (ZooKeeper zooKeeper in ZooKeeperList)
		//	{
		//		zooKeeper.ZooKeeperWithResponsabilities();
		//	}
		//}

		public void SimulateDay(int dayNr)
		{
			foreach (Enclosure enclosure in _EnclosureList)
			{
				enclosure.SimulateDayStart();
			}
			Console.WriteLine("Simulation Day {0} starts.", dayNr);
			foreach (ZooKeeper zooKeeper  in _ZooKeeperList )
			{
				zooKeeper.SimulateZookeeperWork();
			}
			
			Console.WriteLine();

        }
    }
}

