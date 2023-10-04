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
            Summe(20, 50);
            
        }

        public static void Summe(int start, int end)
        {
            int solution = 0;
            for (int i = start; i <= end; i++)
            {
                solution += i;
            }

            Console.WriteLine(solution);
        }
    }
}
