using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week04
{
    internal class RecursionExample
    {
        public static void Main()
        {
            Console.WriteLine(RecursiveSum(10));

        }

        public static int RecursiveSum(int x)
        {
            for(int i = 0; i < x; x++)
            {
                if(i == 0)
                {
                    return x;
                } else
                {
                    return x + RecursiveSum(x - 1);
                }
            }
        }
    }
}
