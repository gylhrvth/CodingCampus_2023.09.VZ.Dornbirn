using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week07.BankSimulation
{
    internal class Bank
    {
        private string _name;
        private int _year;

        public string Name
        {
            get => _name; set
            {
                Console.Write($"Bank {value}");
                _name = value;
            }
        }
        public int Year
        {
            get => _year; set
            {
                Console.WriteLine($", founded in {value}");
                _year = value;
            }
        }
    }
}
