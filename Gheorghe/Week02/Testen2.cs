using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week02
{
    internal class Testen2
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe Summe ist :");
            Summe(5, 10);
            Console.Write("===========================");
            Console.WriteLine();



            Console.Write("Aufgabe Faktorial :");
            PrintFaktorial(20);
            Console.Write("=============================");
            Console.WriteLine();

            Console.WriteLine("Aufgabe FaktorialPlus :");
            PrintFaktorialPlus(1, 20);
            Console.Write("==============================");
            Console.WriteLine();

            Console.WriteLine("Aufgabe Zählen in 0.1");
            PrintCounter(100);
            Console.Write("===========================");
            Console.WriteLine();

            Console.WriteLine("Aufgabe Zählen in 0.1 float");
            PrintCounter2(100);
            Console.Write("===========================");
            Console.WriteLine();


        }

        public static int Summe(int number1, int number2)
        {
            int summ = 0;
            for (int i = number1; i <= number2; i++)
            {
                summ += i;
            }
            Console.WriteLine(summ);
            return summ;


        }

        public static long PrintFaktorial(long number2)
        {
            long faktorial = 1;
            for (long i = 1; i <= number2; i++)
            {
                faktorial *= i;
            }
            Console.WriteLine(faktorial);
            return faktorial;
        }

        public static long PrintFaktorialPlus(long number1, long number2)
        {

            for (long i = number1; i <= number2; i++)
            {

                Console.WriteLine("{0, 20}! = {0, -25}", i, PrintFaktorial(i));

            }

            return 0;
        }

        public static double PrintCounter(double number)
        {

            for (double i = 0; i <= number; i += 0.1)
            {

                Console.WriteLine("Result  {0:N1}", i);
                Console.WriteLine($"result {i:N2}");
            }

            return number;
        }

        public static float PrintCounter2(int number)
        {
            int result = 0;
            for (int i = number; i < number * 10; i++)
            {
                result += 10;
               Console.WriteLine(result/100.0);
                Console.WriteLine("Resultdigit 1 = {0,-3:0.0}", i);
                Console.WriteLine("Resultdigit 2 = {0,7:N2}", i);
            }
            return number;
        }

      

    }
}
