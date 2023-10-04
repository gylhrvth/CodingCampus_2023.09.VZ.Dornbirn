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
            long result;

            Console.WriteLine("\nAufagabe 1:\n");
            Calculate();

            Console.WriteLine("\nAufagabe 2:\n");
            Factorial();

            Console.WriteLine("\nAufagabe 3:\n");
            Zählen();

            Console.WriteLine("\nAufagabe 3:\n");
            Teilen();

        }

        private static void Teilen()
        {
            int number1 = 5;
            char x = '?';
            for (int number = 0; number <= 20; number++)
            {
                Console.WriteLine($"{number,3} / {number1} = {x,5}");
                Console.WriteLine($"{number,3} / {number1:f1} = {x,3}");
            }
        }
        private static void Zählen()
        {
           
            for(int number = 0; number <= 1000; number++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Result 1 ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("digit ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"= {number/10.0,9:N1} ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Result 2 ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("digit ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"= {number / 10.0:N2} ");

            }
        }
        private static void Factorial()
        {
            long number;
            long factorial = 1;
            for (number = 1; number <= 20; number++)
            {
                factorial = factorial * number;
                Console.WriteLine($"{number,5}! =  {factorial,20}");
            }

        }

        private static void Calculate()
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
    

