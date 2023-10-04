using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week02
{
    public class PrimitiveDatentypen2
    {
        public static void Start()
        {
            //PrintingTheSumOfNumbers(2, 30);
            int result = SumOfNumbersButBetter(20, 50);
            Console.WriteLine("Die Summe der Zahlen ist: " + result);
            //Console.WriteLine(CalculateTheFactorial();

        }




        public static void PrintingTheSumOfNumbers(int numberToStart, int numberToCount)
        {
            int numberFinal;
            int numberCountUp = numberToStart + 1;
            int numberIncreaseByOne;
            int numberForPrint = 2;

            numberFinal = numberToStart + numberCountUp;
            numberIncreaseByOne = numberFinal;
            numberCountUp++;
            Console.WriteLine("1. Zahl = " + numberFinal);

            do
            {
                numberFinal = numberCountUp + numberIncreaseByOne;
                Console.WriteLine(numberForPrint + ". Zahl = " + numberFinal);
                numberIncreaseByOne = numberFinal;
                numberCountUp++;
                numberForPrint++;

            } while (numberCountUp != numberToCount + 1);

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Die Summer der Zahlen ist: " + numberFinal);


        }


        public static int SumOfNumbersButBetter(int from, int to)
        {
            int result = 0;
            for (int i = from; i <= to; i++)
            {
                result = result + i; //das selbe wie resault += i
            }
            return result;
        }





        public static void CalculateTheFactorial()
        {
            long number = 1;

            for (long i = number; i <= 20; i++)
            {
                i = number * i;

                Console.WriteLine(i);

            }



        }

    }
}



