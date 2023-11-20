using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week07.VererbungBsp1
{
    internal class Milchkuh : Rind
    {
        private float _Weight;

        public Milchkuh(string name, int age, float weight) : base( name, age)
        {
            _Weight = weight;
        }

        public override void PrintMe()
        {
            //base.PrintMe();                   //Hier kannst du die PrintMe Methode von der Rind Klasse aufrufen
            Console.WriteLine($"Das Tier \"Milchkuh\" mit dem Namen \"{_Name}\" ist \"{_Age}\" Jahre alt und hat ein Gewicht von {_Weight} kg");

        }
    }
}
