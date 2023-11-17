using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week06.Zoo
{
    internal class Food
    {
        private string _name;
        private int _amount;
        private int _price;

        public Food(string name, int amount, int price)
        {
            _name = name;
            _amount = amount;
            _price = price;
        }

        public void PrintZoo()
        {
            Console.WriteLine("  " + Convert.ToChar(9553) + "    " + Convert.ToChar(9562) + $"Eats: {_name}, {_amount} piece for: {_price}$ ({_amount * 28} piece and {_amount * _price * 28}$ per month)");
        }

        public override string ToString()
        {
            return $"{_name}";
        }
    }
}
