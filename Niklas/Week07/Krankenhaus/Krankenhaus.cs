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
        private string _area;

        public string Name
        {
            get => _name;

            set
            {
                Console.Write("" + value);
                _name = value;
            }
        }
        public int Year
        {
            get => _year;

            set
            {
                Console.WriteLine(", gegründet: " + value);
                _year = value;
            }
        }
        public string Area
        {
            get => _area;
            set
            {
                Console.WriteLine("Ambulanz ist: " + value);
                    _area = value;
            }
        }
        public Krankenhaus(string name, int year)
        {
            _name = name;
            _year = year;
        }



    }
}
