using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week07._01Mensch
{
    public class Patient : Human
    {
        private string _sickness;


        public Patient(string name, string gender, string sickness) : base(name, gender)
        {
            _sickness = sickness;
        }

        public override void Print()
        {
            
            Console.WriteLine("I am {0}. I have a {1}.", _name, _sickness);
        }
    }
}
