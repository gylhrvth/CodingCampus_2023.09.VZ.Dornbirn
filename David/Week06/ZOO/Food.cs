using System;
using System.Drawing;

namespace David.Week06.ZOO
{
	public class Food
	{
		string _FoodName;
		string _UnitName;
		double _UnitPrice;


		public Food(string foodName, string unitName, double unitPrice)
		{
			_FoodName = foodName;
			_UnitName = unitName;
			_UnitPrice = unitPrice;
		}

		public void PrintFood()
		{
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"         ||--> Kind: {_FoodName}, Unit: {_UnitName}, Price: {_UnitPrice}");
		}
	}
}

