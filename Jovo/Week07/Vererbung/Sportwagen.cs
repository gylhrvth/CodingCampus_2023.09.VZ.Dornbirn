using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week07.Vererbung
{
    internal class Sportwagen
    {
        protected string _Name;
        private int _Year;


        public Sportwagen(string name, int year) 
        {
            _Name = name;
            _Year = year;
        }



        public virtual void PrintMe() 
        {
            Console.WriteLine(_Name);
        }
    }
}
