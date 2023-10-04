using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week02
{
    internal class PrimitiveDatentypen
    {
        public static void Main()
        {
            Summe();
            
        }

        public static void Summe()
        {
            int sum;
            int solution = 20;
            for (int i = 21; i <= 50; i++)
            {
                sum = i;
                solution = sum + solution;

            }

            Console.WriteLine(solution);
        }
    }
}
