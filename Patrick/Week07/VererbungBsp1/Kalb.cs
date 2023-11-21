using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week07.VererbungBsp1
{
    internal class Kalb : Rind
    {
        private string _Visitor;
        private float _Weight;


        public Kalb(string name, int age,float weight, string visitor) : base (name, age)
        {
            _Visitor = visitor;
        }

        public override void PrintMe()
        {
            Console.WriteLine($"Das Tier \"Kalb\" mit dem Namen \"{_Name}\" ist \"{_Age}\" Jahre alt, wiegt {_Weight} kg und " + _Visitor);
        }
    }
}
