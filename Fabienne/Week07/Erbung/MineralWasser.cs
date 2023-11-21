using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Fabienne.Week07.Erbung
{
    public class MineralWasser : Water
    {
        private int _Amount;
        public MineralWasser(string name, int amount) : base(name)
        {
            _Amount = amount;
        }
        public override void Print()
        {
            Console.WriteLine($"{_Amount,1:N1} l of {_Name}");
        } 
    }
}
