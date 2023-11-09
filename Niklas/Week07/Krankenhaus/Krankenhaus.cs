using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week07.Krankenhaus
{
    internal class Krankenhaus
    {
        private string _name;
        private int _year;

        public string Name
        {
            get => _name;

            set
            {
                Console.Write("" + value);
                value = _name;
            }
        }
        public int Year
        {
            get => _year;

            set
            {
                Console.WriteLine(", gegründet: " + value);
                value = _year;
            }
        }
        public Krankenhaus(string name, int year)
        {
            name = _name;
            year = _year;
        }



    }
}
