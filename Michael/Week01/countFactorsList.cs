using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week01
{
    internal class countFactorsList
    {
        public static void Start(int max)
        {
            int maxFactors = 0;
            int distance = 1;

            for(int i = 2; i <= max; i++)
            {
                int factors = countFactors(i);

                if(factors > maxFactors)
                {
                    maxFactors = factors;
                    Console.WriteLine($"{distance, 10} -> {factors}");
                    distance = 1;
                    //Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    distance++;
                }

                //Console.WriteLine($"factors of {i,3} : {factors}");

                //Console.ResetColor();
            }
        }

        public static int countFactors(int num)
        {
            int count = 0;

            for(int i = 2; i < num/2 + 1; i++)
            {
                if (num % i == 0) count++;
            }

            return count;
        }
    }
}
