using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Selina.Week02
{
    internal class Datentypen
    {
        public static void Start()
        {

            Console.WriteLine("\nAufagabe 1:\n");
            Calculate();
            Console.WriteLine("\nAufagabe 2:\n");
            Factorial();

        }

        static void Factorial()
        {
            long number;
            long factorial = 1;
            for (number = 1; number <= 20; number++)
            {
                factorial = factorial * number;
                Console.WriteLine($"{number,5}! =  {factorial,20}");
            }
        }

        static void Calculate()
        {
            int result = 0;
            for (int number = 20; number <= 50; number++)
            {
                    if (number == 20)
                    {
                        Console.Write($"{number}");
                    }
                    else if(number > 20)
                    {
                        Console.Write($" + {number}");
                    }
                    
                    result = result+ number;
                
            }
            Console.WriteLine($" = {result}");
        }
    }
}
    

