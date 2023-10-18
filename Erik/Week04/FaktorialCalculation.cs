using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week04
{
    public class FaktorialCalculation
    {

        public static void Start()
        {


        }

        public static int SumOfNumbers(int n)
        {
            if (n == 0) return 0;

            return n + SumOfNumbers(n - 1);
        }

        public static void SumOfNumbersFaktorial(int context)
        {



        }
    }
}
