using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week07.Vererbung
{
    internal class Scorpiones : Arthropoda
    {
        private bool _IsItPoisonous;


        public Scorpiones(string name, bool IsItPoisonous) : base(name)
        {
            _IsItPoisonous = IsItPoisonous;
        }


        public override void PrintMe()
        {
            Console.WriteLine("Scorpiones: {0}, Giftig: {1}", _Name, _IsItPoisonous);
        }


    }
}
