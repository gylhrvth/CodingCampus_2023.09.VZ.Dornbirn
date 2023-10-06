using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Net.Sockets;
using System.Xml.XPath;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fabienne.week02
{


    public class Primitiven_Datentypen
    {
        public static void StartPrimitivenDatentypen()
        {
            
           // PrintSum();
            Console.WriteLine();
           // Faktorial(20);
            Console.WriteLine();
            //VonNullBisHundert();
            Console.WriteLine();
            //VonNullBisHundert2();
            //TeilenUndHerrschen("x", 5);
            CalculationPi();
            Console.WriteLine();
           // CalculationPiGyula();
            CalculationPi2();
        }

       /* public static void PrintSum()
        {
            int result = 0;

            for (int i = 20; i <= 50; i++)
            {
                result += i;
                Console.WriteLine(result);
            }

            Console.WriteLine();
        }

        public static void Faktorial(long number)
        {
            long result = 1;

            for (int i = 1; i <= number; i++)
            {
                result = result * i;

                Console.WriteLine("{0, -2}! = {1, 20} ",i,result) ;
            }
        }

        public class funktionWithReturn //was gyula vorgezeigt hat
        {
            public static void Start()
            {
                Console.WriteLine(Add(3, 22));

                int c = Add(5, 4);

                Console.WriteLine(c);
            }

            public static int Add(int a, int b)
            {
                int result = a + b;

                return result;
            }
        }

        public static void VonNullBisHundert()
        {
            Console.WriteLine("Variante 1:");
            for (double number = 0; number <= 1000; number++)
            {
                Console.Write("Digit ");
                Console.WriteLine($"= {number / 10.0:N1} ");
            }
            Console.WriteLine();

            Console.WriteLine("Variante 2:");
            for (double number = 0; number <= 1000; number++)
            {
                Console.Write("Digit ");
                Console.WriteLine($"= {number / 10.0:N2} ");
            }
        }

        public static void VonNullBisHundert2()
        {
            for (double number = 0; number <= 1000; number++)
            {
                
                Console.WriteLine($"Result 1 Digit = {number / 10.0:N1} ");
               
                Console.WriteLine($"Result 2 Digit = {number / 10.0,9:N2} ");
            }
            Console.WriteLine();
        }

        public static void TeilenUndHerrschen(string symbol, int number)
        {
            for (int digit = 0; digit <= 20; digit++)
            {
                Console.WriteLine("5= " + digit/5);
                Console.WriteLine("5.0= " + digit/5.0);
            }
        } */

        public static void CalculationPi()
        {
            //2: 3,141392653591791
            //1: 3,141392653591791
            double digit = 0;

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            bool toggle = true;

            for (double number = 1; number <= 10000000000; number = number + 4)
            {
                /*
                if (toggle)
                {
                    digit += 4 / number;
                }
                else
                {
                    digit -= 4 / number;
                }
                toggle = !toggle;
                */

                digit += 4 / number;
                digit -= 4 / (number + 2);


                //digit += 4 / number;
                //digit = digit * -1;
            }
            stopWatch.Stop();
            Console.WriteLine($"Took {stopWatch.ElapsedMilliseconds:0.00}ms");

            Console.WriteLine(digit);
        }

       /* public static void CalculationPiGyula()
        {
            double digitMax = 4;
            double digitMin = 0;

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            long number = 1;
            while (digitMax - digitMin > 0.0000000001)
            {
                digitMax = digitMin + 4.0 / number;
                number += 2;
                digitMin = digitMax - 4.0 / number;
                number += 2;
                if (number % 100000 < 4)
                {
                    Console.WriteLine("Pi ist zwischen {0} und {1}", digitMin, digitMax);
                }
            }
            stopWatch.Stop();
            Console.WriteLine($"Took {stopWatch.ElapsedMilliseconds:0.00}ms");

            Console.WriteLine("Pi ist zwischen {0} und {1}", digitMin, digitMax);
        } */

        public static void CalculationPi2()
        {
            double n1 = 1;
            double n2 = 2;
            double n3 = 3;

            double abc = 0;

            double result = 0;
            double result1 = 0;
            double endresult = 0;

            while (abc > 1000000)
            {
                ++n1;
                ++n2;
                ++n3;

                result = 4.0 / (n1 * n2 * n3);

                ++n1;
                ++n2;
                

                result1 = (4.0 / (n1 * n2 * n3)) * -1.0;
            }

            endresult = result + result1;    

            Console.WriteLine(endresult + 3.0);
        }

       /* public static double CalculatePiNilakantha()
        {
            double pi = 3;

            for (double i = 2; i <= 100; i += 2)
            {
                pi += 4 / (i * (i + 1) * (i + 2));
                Console.WriteLine($"pi = {pi}");
                pi *= -1;
            }
            return pi;
        }*/


    }

    

}

