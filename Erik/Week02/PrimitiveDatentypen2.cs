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
            //int result = SumOfNumbersButBetter(20, 50);
            //Console.WriteLine("Die Summe der Zahlen ist: " + result);
            //CalculateTheFactorial(20);
            //CountFromZeroToHundred();
            //CountFromZeroToHundred2();
            //CountFromZeroToHundred3();
            //CountFromZeroToHundredExtended();
            divideTheNumbers();
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

        public static long CalculateTheFactorial(long number2)
        {
            long number = 1;
            for (long i = 1; i <= number2; i++)
            {
                number = number * i;
                Console.WriteLine("{0,-2} != {1,20}", i, number);
            }
            return number;
        }

        public static void CountFromZeroToHundred()
        {
            for (double i = 0; i <= 100; i += 0.1)
            {
                Console.WriteLine(i);
            }
        }

        public static void CountFromZeroToHundred2()
        {
            for (double i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
                i += 0.1;
            }
        }

        public static void CountFromZeroToHundred3()
        {
            for (float i = 0; i <= 100 * 10; i++)
            {
                Console.WriteLine(i / 10);
            }
        }

        public static void CountFromZeroToHundredExtended()
        {
            float number;
            for (int i = 0; i <= 100; i++)
            {
                number = (float)i / 10;
                Console.WriteLine("Result 1  digit = {0:N1}", number); //eine Nachkommastelle :D
                Console.WriteLine("Result 2  digit = {0,9:N2}", number); //zwei Nachkommastelle :D
            }
        }

        public static void divideTheNumbers()
        {          
            for (int x = 0; x <= 20; x++)
            {
                Console.WriteLine(x + " / " + 5 + " = " + x / 5 );
                Console.WriteLine(x + " / " + 0.5 + " = " + x / 0.5 );
            }
        }
    }
}




