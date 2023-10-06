using System;
using System.Collections.Concurrent;
using System.Net.Sockets;

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
            for (int number = 1; number <= 10000; number = number + 2)
            {
                double digit =4 / number;

                digit = digit * -1;
                Console.WriteLine(digit);
            }

        }

        
    }

    
}

