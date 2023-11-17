using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week07.BankSimulation
{
    internal class BankExample
    {
        public static void Start()
        {
            Bank bank = new Bank();

            bank.Name = "Sparkasse";
            bank.Year = 1922;
        }
    }
}
