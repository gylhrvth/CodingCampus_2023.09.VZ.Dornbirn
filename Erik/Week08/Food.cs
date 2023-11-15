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

        public Food(string foodName, int unit, int costPerUnit)
        {
            _FoodName = foodName;
            _Unit = unit;
            _CostPerUnit = costPerUnit;
        }


    }
}

