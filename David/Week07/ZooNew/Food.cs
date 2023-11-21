using System;
using System.Reflection;
using System.Xml.Linq;

namespace David.Week07.ZooNew
{
	public class Food
	{
        private string _FoodName;
        private string _FoodUnit;
        private float _FoodPrice;

        public Food(string foodName, string foodUnit, float foodPrice)
		{
			_FoodName = foodName;
			_FoodUnit = foodUnit;
			_FoodPrice = foodPrice;

		}
        public void PrintAnimals()
        {
            Console.WriteLine($"      --->{_FoodName}, {_FoodUnit}, {_FoodPrice}");
        }
    }
}

