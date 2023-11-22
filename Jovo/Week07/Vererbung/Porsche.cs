using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week07.Vererbung
{
    internal class Porsche : Sportwagen
    {
        private int _Cost;


        public Porsche(string name, int year, int cost) : base (name, year) 
        { 
            _Cost = cost;
          
        }


        public override void PrintMe()
        {
            Console.WriteLine($"die marke {_Name} ist besser");
        }
    }
}
