using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Erik.Week08
{
    public class Food
    {
        private string _FoodName;
        private int _Unit;
        private int _CostPerUnit;
        private List<Food> _FoodList;

        public Food(string foodName, int unit, int costPerUnit)
        {
            _FoodName = foodName;
            _Unit = unit;
            _CostPerUnit = costPerUnit;
            _FoodList = new List<Food>();s
        }

        public void FoodList(Food food)
        {
            foreach (Food element in _FoodList)
            {
                _FoodList.Add(food);
            }
        }

    }
}

