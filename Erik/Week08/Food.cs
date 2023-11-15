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

        public List<Food> foods { get => _FoodList; }
        public string foodName { get => _FoodName; }
        public int unit { get => _Unit; set => _Unit = value; }
        public int costPerUnit { get => _CostPerUnit; }

        public Food(string foodName, int unit, int costPerUnit)
        {
            _FoodName = foodName;
            _Unit = unit;
            _CostPerUnit = costPerUnit;
            _FoodList = new List<Food>();
        }


    }
}

