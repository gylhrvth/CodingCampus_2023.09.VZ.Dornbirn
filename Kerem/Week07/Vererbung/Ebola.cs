using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week07.Vererbung
{
    internal class Ebola : Diseases
    {
        private double _dangerouslevel;
        private bool _treatable;

        public Ebola(string name, bool treatable, double dangerouslevel) : base(name)
        {
            _dangerouslevel = dangerouslevel;
            _treatable = treatable;
        }
        public override void PrintMe()
        {
            Console.WriteLine($"I'm a  very terrible {_name} and my dangerous level is at {_dangerouslevel}!!\nBut am i treatable? : {_treatable}!!"); ;
        }
    }
}
