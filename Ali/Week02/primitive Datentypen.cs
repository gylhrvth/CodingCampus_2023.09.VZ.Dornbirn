using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week02
{
    internal class primitive_Datentypen
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 1");
            int sum = printSum(20, 50);
            Console.WriteLine(sum);

            Console.WriteLine("Aufgabe 2");
            PrintFactorial(20);
            Console.WriteLine();

            Console.WriteLine("Aufgabe 3v1");
            double dezi = printDezi(1000);


            //Console.WriteLine("Test1");
            //double test1 = printtest1(1000);
            //Console.WriteLine();

            Console.WriteLine("Aufgabe 3 erweit.");
            double x = printX(100);
            Console.WriteLine();

            Console.WriteLine("Aufgabe Teilen und Herrschen");
            double y = printY(20);
            


        }
        public static int printSum(int min, int max)
        {
            int sum = 0;

            for (int i = min; i <= max; i++)
            {
                sum = sum + i;
            }
            return sum;


        }
        public static void PrintFactorial(int maxNum)
        {
            for (int i = 1; i <= maxNum; i++)
            {
                Console.WriteLine("{0,2}! ={1,20}", i, printFact(i));
            }
        }



        public static long printFact(int max)
        {
            long sum = 1;
            for (int i = 1; i <= max; i++)
            {
                sum = sum * i;

            }

            return sum;

        }
        public static double printDezi(int maxNum)
        {
            double dezi = 0;

            for (int i = 0; i <= maxNum; i++)


            {
                dezi = i;

                Console.WriteLine(dezi / 10.0);

            }

            return dezi;
        }
        public static double printX(int max)
        {
            double x = 0.0;

            for (double i = 0.0; i <= max; i+=0.1)
            {
                x += 0.1;

                Console.WriteLine($"Result 1 digit ={i,3:0.0}");
                Console.WriteLine($"Result 2 digit ={i,7:0.00}");



            }
            return x;
        }
        public static double printY(int max)
        {
            
            double x = 5.0;
            for(double i = 0.0;i <=max; i++)
            {
                Console.WriteLine($"Ergebnis={x}");
            }
            return max;
        }
        
    }
}

