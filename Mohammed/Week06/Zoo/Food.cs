using System;
namespace Mohammed.Week06.Zoo
{
	public class Food
	{
        private string _Name;
		private string _Unit;
		public double _PreisPerUnit;


		public string Name
		{
			get => _Name;
			
		}

		public string Unit
		{
			get => _Unit;
			set => _Unit = value;
		}

		public double PreisPerUnit
		{
			get => _PreisPerUnit;
			set => _PreisPerUnit = value;
		}

		public Food(string name, string unit, double preisPerUnit)
		{
			_Name = name;
			_Unit = unit;
			_PreisPerUnit = preisPerUnit;
		}

		public void PrintFood(int FoodCount)
		{
			Console.WriteLine($"│\t\t\t\t├── {_Name} {FoodCount} {_Unit}");
		}


		public override string ToString()
		{
			return "Food: " + _Name + "  Unit: " + _Unit;
		}
       
	}

	

}

