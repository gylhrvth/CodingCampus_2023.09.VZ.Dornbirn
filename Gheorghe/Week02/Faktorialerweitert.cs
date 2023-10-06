using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week02
{
    internal class Faktorialerweitert
    {
        public static void Start()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("{0,20}!= {1,-20}", i, Zählen_in_0.Factorialcalculus(i));
            }
        }
    }
}
