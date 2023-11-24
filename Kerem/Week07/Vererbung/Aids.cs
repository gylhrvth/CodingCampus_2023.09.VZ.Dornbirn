using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week08.Vererbung
{
    internal class Aids : Diseases
    {
        private double _dangerouslevel;
        private bool _treatable;

        public Aids(string name, double dangerouslevel, bool treatable) : base(name)
        {
            _dangerouslevel = dangerouslevel;
            _treatable = treatable;
        }
        public override void PrintMe()
        {
            Console.WriteLine($"I'm a terrible {_name} and my dangerouslevel is at {_dangerouslevel}.\nBut am I treatable? : {_treatable}");
        }


    }
}
