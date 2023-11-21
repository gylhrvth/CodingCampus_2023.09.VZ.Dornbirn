using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week07.VererbungUebung
{
    public class TShirt : Clothing
    {
        private string _Fabric;
        private string _Colour;
        
        public TShirt(string name, string fabric, string colour) : base (name) 
        { 
            _Fabric = fabric;
            _Colour = colour;
        }

        public override void PrintClothing()
        {
            Console.WriteLine($"Ich bin ein freshes TShirt von {_Name} mit der Farbe {_Colour} aus {_Fabric}.");
        }


    }
}
