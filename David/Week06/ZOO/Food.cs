using System;
using System.Drawing;

namespace David.Week06.ZOO
{
	internal class Food
	{
		public string _FoodName;
		public string _UnitName;
		public float _UnitPrice;

		
		//Konstruktor
        public Food(string foodName, string unitName, float unitPrice)
		{
			_FoodName = foodName;
			_UnitName = unitName;
			_UnitPrice = unitPrice;
		}

		public string FoodName
		{
			get => _FoodName;
		}

		public override string ToString()
		{
			return _FoodName;
		}




	}
}

