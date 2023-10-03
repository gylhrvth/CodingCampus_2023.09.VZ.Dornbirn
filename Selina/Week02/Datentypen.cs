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
            //Aufgabe 1:

            //int h = 5;
            //for (int i = 0; i < h; i++)
            //{
            //    if (i <= h)
            //    {
            //        for (int y = 1; y <= i; y++)
            //        {
            //            Console.Write("x");

            //    }
            //    Console.WriteLine("x");
            //}

            //Aufgabe 2:
            int result = 0;
            
            Calculate(result);
            Console.WriteLine($"{result}");

            //Aufgabe 3:
        }

        static int Calculate(int result)
        {
            for (int number=20; number <= 50; number++)
            {
                if (number % 2 == 0)
                {
                    result= result+ number;
                    Console.Write($"{number} + ");
                }
            }
            return result;
        }
    }
}
