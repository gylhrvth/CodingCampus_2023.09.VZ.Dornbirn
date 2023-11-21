using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Fabienne.Week07.Erbung
{
    public class MineralWasser : WasserMain
    {
        private int _Amount;
        public MineralWasser(string name, int amount) : base()
        {
            _Amount = amount;
        }
       /* public override void PrintMe()
        {
            Console.WriteLine("HI!");
        } */
    }
}
