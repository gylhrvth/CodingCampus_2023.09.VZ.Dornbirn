using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Selina.Week02
{
    internal class Datentypen
    {
        public static void Start()
        {
            double result = 0;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nßnAufagabe 1:\n");
            Calculate(result);

            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("\n\nAufagabe 2:\n");
            Factorial(result);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nAufagabe 3:\n");
            Count(result);

            Console.ForegroundColor =ConsoleColor.Yellow;
            Console.WriteLine("\n\nAufagabe 4:\n");
            DivideAndConquer(result);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\nAufagabe 5:\n");
            CalculatePiLeibniz(result);


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nAufagabe 6:\n");

        }


        static double CalculatePiLeibniz(double result)
        {
            double pi = 0.0;
            double n = 1000000;

            for (int i = 0; i < n; i++)
            {
                double term = (i % 2 == 0) ? 1.0 : -1.0;
                double denominator = 2.0 * i + 1.0;

                pi += term / denominator;
            }

            result = 4 * pi;
            Console.WriteLine(result);
            return result;
        }
        private static double DivideAndConquer(double result)
        {
            double number1 = 5;
            for (double number = 0; number <= 20; number++)
            {
                result = number / number1;
                Console.WriteLine($"{number,3} / {number1} = {result,7:f2}");
                Console.WriteLine($"{number,3} / {number1:N1} = {result,5:f2}");

                
            }
            return result;
        }
        private static double Count(double result)
        {
           
            for(double number = 0; number <= 1000; number++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Result 1 ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("digit ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"= {number/10.0,9:N1} ");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Result 2 ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("digit ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"= {number / 10.0:N2} ");
            }
            return result;
        }
        private static double Factorial(double result)
        {
            long number;
            long factorial = 1;
            for (number = 1; number <= 20; number++)
            {
                factorial = factorial * number;
                Console.WriteLine($"{number,5}! =  {factorial,20}");
            }
            return result;
        }
        private static double Calculate(double result)
        {
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
            return result;
        }
    }
}
    

