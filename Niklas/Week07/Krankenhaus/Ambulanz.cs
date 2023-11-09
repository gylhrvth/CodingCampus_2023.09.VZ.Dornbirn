using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week07.Krankenhaus
{
    internal class Ambulanz
    {
        private DateTime _time;
        private string _places;
        private string _waiting;

        public DateTime Time
        {
            get => _time;
            set
            {
                Console.WriteLine($"The tine is: {value}");
                value = _time;
            }
        }
        public Ambulanz(DateTime time)
        {
            _time = time;
        }



    }
}
