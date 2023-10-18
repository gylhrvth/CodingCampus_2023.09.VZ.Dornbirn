using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week04
{
    internal class Rekursion
    {
        public static void Start()
        {
            //Aufgabe - Rekursion für 
            Console.WriteLine("Rekursive Summe:");
            Console.WriteLine(RekSumm(4));
            Console.WriteLine("Rekursiv Faktorial:");
            Console.WriteLine(RekFaktorial(20)); //int bei 33 = minus zahl why?
            Console.WriteLine("Fibonacci Reihe");
            Console.WriteLine(CalcFibonacci(7));

        }
        //Aufgabe: Rekursive Summe
        public static int RekSumm(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            int summe = number + RekSumm(number - 1);
            Console.WriteLine(summe);
            return summe;
        }
        //Aufgabe: Rekursive Faktorial
        public static long RekFaktorial(long number)
        {
            if (number == 1)
            {
                return 1;
            }
            long summe = number * RekFaktorial(number - 1);
            return summe;
        }
        //Aufgabe: Fibonacci
        public static int CalcFibonacci(int number)
        {
            if (number == 1 || number == 2)
            {
                return 1;
            }
            int fibo = CalcFibonacci(number - 1) + CalcFibonacci(number - 2);
            return fibo;

        }


    }
}
