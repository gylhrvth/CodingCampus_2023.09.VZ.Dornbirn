using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week07.VererbungBsp1
{
    internal class Rind
    {
        protected string _Name;                 // protected ist für eine Übernahme in der abgeleiteten (vererbten) Klasse
        protected int _Age;

        public Rind(string name, int age)
        {
            _Name = name;
            _Age = age;
        }

        public virtual void PrintMe()
        {
            Console.WriteLine($"Das Tier Rind mit dem Namen \"{_Name}\" ist \"{_Age}\" Jahre alt!");
        }
    }

}



