using System;
namespace David.Week06.OOP
{
	public class Car
	{
		public string Brand { get; private set; }

		public string Model { get; private set; }

		public int Year	{ get; private set; }

		
		public Car(string brand, string model, int year)
		{
			Brand = brand;
			Model = model;
			Year = year;
		}

		public void Honk()
		{
			Console.WriteLine("Das Auto hupt!");
		}

		public string GetFullInfo()
		{
            return $"{Brand}, {Model}, {Year};";
		}

		public float CalculateFuelConsumption(int kilometers, float consumptionRate)
		{
			float consumptionPerKm = consumptionRate / 100;

			return kilometers * consumptionPerKm;
		}
	}
}


