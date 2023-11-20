using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week07._01Mensch
{
    abstract public class Human
    {
        protected string _name;
        private string _gender;

        public Human(string name, string gender)
        {
            _name = name;
            _gender = gender;
        }

        abstract public void Print();
        //{
        //    //Console.WriteLine("I am {0}.", _name);
        //}

    }
}
