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
        public string _Color;

        //base -> 
        public RGBTastatur(string name, bool hasLoudClick,string color) : base(name,hasLoudClick)
        {
            _Color = color;

        }

        public override void PrintTastatur() // override überschreibt die exestierte methode
        {
            Console.WriteLine($"Tastatur: {_Name} \n HasLoudClick: {_HasLoudClick} \n Color: {_Color}");
        }
    }
}
