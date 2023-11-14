using System;
namespace David.Week06.OOP
{
	public class Program
	{
		static void Main(string[] args)
		{

			Car myCar = new Car("Toyota", "XLS 100", 2004);
			myCar.Honk();

			string info = myCar.GetFullInfo();
			Console.WriteLine(info);

			float consumption = myCar.CalculateFuelConsumption(400, 4.5f);
			Console.WriteLine("Das Auto verbraucht: " + consumption + " Liter Benzin pro 100 Km.");
        }
    }
}

