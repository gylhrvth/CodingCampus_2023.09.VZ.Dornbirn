using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week07.Vererbung
{
    public class Tastatur
    {
        protected string _Name; // protected -> in sich selber sichtbar, und in den weiteren Vererbungen
        protected bool _HasLoudClick;
        protected string _Color;

        public Tastatur(string name, bool hasLoudClick, string color)
        {
            _Name = name;
            _HasLoudClick = hasLoudClick;
            _Color = color;
        }

        public  virtual void PrintTastatur() // virtual -> kann überschrieben werden muss nicht
        {
            Console.WriteLine($"Tastatur: {_Name} \n HasLoudClick: {_HasLoudClick} \n Color: {_Color}");
        }
    }
}
