using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week07._01Mensch
{
    internal class Allgemeinmediziner : Doctor
    {
        private bool _EigenePraxis;

        public Allgemeinmediziner(string name, string gender, string role, bool eigenePraxis) : base(name, gender, role)
        {
            _EigenePraxis = eigenePraxis;
        }

        public override void Print()
        {
            
            if (_EigenePraxis)
            {
                Console.WriteLine("I am {0}. I am an {1}. I have my own Praxis.", _name, _Role);
            }
            else { Console.WriteLine("I am {0}. I am an {1}. I don't have my own Praxis.", _name, _Role); }
        }
    }
}
