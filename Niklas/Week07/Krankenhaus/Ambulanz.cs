using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week07.Krankenhaus
{
    internal class Ambulanz
    {
        private string _time;
        private string _places;
        private int _waiting;

        public string Time
        {
            get => _time;
            set
            {
                Console.WriteLine($"---The time is: {value}");
                _time = value;
            }
        }
        public int Waiting
        {
            get => _waiting;
            set
            {
                Console.WriteLine($"---{value} person in the waitingroom.");
                _waiting = value;
            }
        }


        public Ambulanz(string time, int waiting)
        {
            _time = time;
            _waiting = waiting;
        }



    }
}
