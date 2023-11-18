using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week07._01Mensch
{
    public class Doctor : Human
    {
        protected string _Role;

        public Doctor(string name, string gender, string profession) : base(name, gender)
        {
            _Role = profession;
        }

        public override void Print()
        {

            Console.WriteLine("I am {0}. I am an {1}.",_name, _Role);
        }
    }
}
