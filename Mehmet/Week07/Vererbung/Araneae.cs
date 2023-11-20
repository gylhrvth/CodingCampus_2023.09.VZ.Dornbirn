using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week07.Vererbung
{
    internal class Araneae : Arthropoda
    {
        private bool _Endangered;


        public Araneae(string name, bool endangered) : base(name)
        {
            _Endangered = endangered;
        }


        public override void PrintMe()
        {
            Console.WriteLine("Araneae: {0}, gefährdet: {1}", _Name, _Endangered);
        }


    }
}
