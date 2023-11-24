using System;
namespace Mohammed.Week06.Zoo
{
	public class Animal
	{
		private string _Name;
		private string _Species;
		private string _Genus;
		private Food _Food;
		private int _FoodCount;
		private string _Unit;
		private List<Food> _Foodlist = new();
        private int _Health;
		private int _MaxHealth;
		private int _Bite;




        public string Name
		{
			get => _Name;

		}

		public string Species
		{
			get => _Species;
		}

		public string Genus
		{
			get => _Genus;
		}

		public Food food
		{
			get => _Food;
		}

		public int FoodCount
		{
			get => _FoodCount;
		}

		public string Unit
		{
			get => _Unit;
		}

		public int Helath
		{
			get => _Health;
		}

		public int MaxHealth
		{
			get => _MaxHealth;
		}

		public int Bite
		{
			get => _Bite;
		}
		public Animal(string name, string species, Food food, int foodcount, string unit, int health, int maxhealth, int bite)
		{
			_Name = name;
			_Species = species;
			_Food = food;
			_FoodCount = foodcount;
			_Unit = unit;
			_Health = health;
			_MaxHealth = maxhealth;
			_Bite = bite;
		}

		public void PrintAnimal(string praefix)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write(_Foodlist.Count);
			Console.WriteLine(praefix + "├──" + _Name + " , " + _Food + " " + _FoodCount + _Unit);
			Console.ResetColor();
		}



		public void GetAnimalsStatistic(Dictionary<Food, double> dic)
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			if (dic.ContainsKey(_Food))
			{
				dic[_Food] += _FoodCount;
			}
			else
			{
				dic[_Food] = _FoodCount;

			}
		}

		
		public override string ToString()
		{
			return _Name;
		}

	}
}
