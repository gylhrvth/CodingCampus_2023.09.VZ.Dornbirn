using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week07.Vererbung
{
    public class Tastatur
    {
        protected string _Name; // protected ->
        protected bool _HasLoudClick;

        public Tastatur(string name, bool hasLoudClick)
        {
            _Name = name;
            _HasLoudClick = hasLoudClick;
        }

        public virtual void PrintTastatur() // virtual ->
        {
            Console.WriteLine($"Tastatur: {_Name} \n HasLoudClick: {_HasLoudClick}");
        }
    }
}
