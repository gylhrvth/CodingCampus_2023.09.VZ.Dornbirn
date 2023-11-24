using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Martin.Week07.Vererbung
{
    public class RGBTastatur : Tastatur // Vererbung -> 
    {
        public int _LichtStärke;

        //base -> 
        public RGBTastatur(string name, bool hasLoudClick,string color, int lichtStärke) : base(name,hasLoudClick,color)
        {
            _LichtStärke = lichtStärke;

        }

        public override void PrintTastatur() // override überschreibt die exestierte methode
        {
            Console.WriteLine($"Tastatur: {_Name} \n HasLoudClick: {_HasLoudClick} \n Color: {_Color} \n Lightpower: {_LichtStärke}");
        }
    }
}
