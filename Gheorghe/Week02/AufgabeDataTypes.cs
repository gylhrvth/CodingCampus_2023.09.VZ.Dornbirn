using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week02
{
    internal class AufgabeDataTypes
    {
        public static void Start()
        {
            int Summe = MySumme(20, 50);
            Console.WriteLine("Summe = " + Summe);
        }

        public static int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public static int MySumme(int from, int to)
        {
            int result = 0;
            for (int i = from; i <= to; i++)
            {
                result  +=  i;
            }
            return result;
        }
    }
}




      

