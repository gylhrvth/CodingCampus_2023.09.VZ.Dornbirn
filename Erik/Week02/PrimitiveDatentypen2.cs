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
            //Console.WriteLine(CountFromZeroToHundred());
            //CountFromZeroToHundred2();
            //CountFromZeroToHundred3();
            //CountFromZeroToHundredExtended();
            //DivideTheNumbers();
            //Console.WriteLine(CalculationOfPiLeibniz());
            //Console.WriteLine("Berechnung von PI (Leibniz)");
            //Console.WriteLine(Math.PI);
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("Berechnung von PI (Nilakantha)");
            //Console.WriteLine(CalculationOfPiNilakantha());
            //TheSecretRow();
            PrimeNumbersIntro();
            PrimeNumbersCalculation();
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

        public static double CountFromZeroToHundred()
        {
            double number = 0;
            for (double i = 0; i <= 100; i += 0.1)
            {
                number = i;
            }
            return number;
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

        public static void DivideTheNumbers()
        {
            for (int x = 0; x <= 20; x++)
            {
                Console.WriteLine(x + " / " + 5 + " = " + x / 5);
                Console.WriteLine(x + " / " + 0.5 + " = " + x / 0.5);
            }
        }

        public static double CalculationOfPiLeibniz()
        {

            double numberPi = 0;
            double number01 = 0;
            double number02 = 0;

            for (int i = 1; i < 99999999; i += 4)
            {
                number01 = (double)4 / i;
                number02 = (double)4 / (i + 2);

                numberPi = numberPi + (number01 - number02);
            }
            return numberPi;

        }

        public static double CalculationOfPiNilakantha()
        {
            double numberPi = 3;
            double numberResault01 = 0;
            double numberResault02 = 0;

            for (int i = 2; i < 10000; i += 4)
            {
                numberResault01 = 4 / (i * (i + 1.0) * (i + 2));
                numberResault02 = 4 / ((i + 2.0) * (i + 3) * (i + 4));

                numberPi = numberPi + (numberResault01 - numberResault02);
            }
            return numberPi;
        }

        public static void TheSecretRow()
        {
            decimal numberResault = 1;

            for (int i = 1; i < 10000; i++)
            {

                numberResault = numberResault / 2 + 1 / numberResault;
                Console.WriteLine(numberResault + i);
            }
        }

        public static void PrimeNumbersCalculation() //primeNumber = max 100
        {

            

            Console.WriteLine("Bitte geben Sie eine Zahl ein! (maximal 100!)");
            Console.Write("Ihre Zahl: " );
            int numberUserInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            while (numberUserInput > 100000000)
            {
                Console.WriteLine("!!Bitte geben Sie eine Zahl ein, die kleiner oder gleich 100 ist!! \n");
                Console.Write("Ihre Zahl: ");
                numberUserInput = Convert.ToInt32(Console.ReadLine());
            }

            PrintPrimParts(numberUserInput);
            /*
                {

                    Console.WriteLine("--------------------------------------------");
                    Console.Write("Ergebnis: ");

                    {
                        int[] primeNumbersToDivide = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47 };

                        while (numberUserInput != 1)
                        {
                            for (int i = 0; i < primeNumbersToDivide.Length; i++)
                            {
                                if (numberUserInput % primeNumbersToDivide[i] == 0)
                                {
                                    numberUserInput = numberUserInput / primeNumbersToDivide[i];
                                    Console.Write(primeNumbersToDivide[i]);

                                    if (numberUserInput != 1)
                                    {
                                        Console.Write(" * ");
                                    }

                                }
                            }
                        }
                        Console.WriteLine();
                    }
                }
                */
            }


        public static void PrintPrimParts(long num)
        {
            Console.Write("Ergebnis: ");
            bool firstElement = true;
            int div = 2;
            while (num > 1)
            {
                if (num % div == 0)
                {
                    if (!firstElement)
                    {
                        Console.Write(" * ");
                    }                    
                    Console.Write("{0}", div);
                    num /= div;
                    firstElement = false;
                } 
                else
                {
                    ++div;
                }
            }
        }

            public static void PrimeNumbersIntro()
            {

                Console.WriteLine(" _______            __                 ______           __          __                                                        __                                                   \r\n/       \\          /  |               /      \\         /  |        /  |                                                      /  |                                                  \r\n$$$$$$$  | ______  $$/  _____  ____  /$$$$$$  |______  $$ |   __  _$$ |_     ______    ______   ________   ______    ______  $$ |  ______    ______   __    __  _______    ______  \r\n$$ |__$$ |/      \\ /  |/     \\/    \\ $$ |_ $$//      \\ $$ |  /  |/ $$   |   /      \\  /      \\ /        | /      \\  /      \\ $$ | /      \\  /      \\ /  |  /  |/       \\  /      \\ \r\n$$    $$//$$$$$$  |$$ |$$$$$$ $$$$  |$$   |   $$$$$$  |$$ |_/$$/ $$$$$$/   /$$$$$$  |/$$$$$$  |$$$$$$$$/ /$$$$$$  |/$$$$$$  |$$ |/$$$$$$  |/$$$$$$  |$$ |  $$ |$$$$$$$  |/$$$$$$  |\r\n$$$$$$$/ $$ |  $$/ $$ |$$ | $$ | $$ |$$$$/    /    $$ |$$   $$<    $$ | __ $$ |  $$ |$$ |  $$/   /  $$/  $$    $$ |$$ |  $$/ $$ |$$    $$ |$$ |  $$ |$$ |  $$ |$$ |  $$ |$$ |  $$ |\r\n$$ |     $$ |      $$ |$$ | $$ | $$ |$$ |    /$$$$$$$ |$$$$$$  \\   $$ |/  |$$ \\__$$ |$$ |       /$$$$/__ $$$$$$$$/ $$ |      $$ |$$$$$$$$/ $$ \\__$$ |$$ \\__$$ |$$ |  $$ |$$ \\__$$ |\r\n$$ |     $$ |      $$ |$$ | $$ | $$ |$$ |    $$    $$ |$$ | $$  |  $$  $$/ $$    $$/ $$ |      /$$      |$$       |$$ |      $$ |$$       |$$    $$ |$$    $$/ $$ |  $$ |$$    $$ |\r\n$$/      $$/       $$/ $$/  $$/  $$/ $$/      $$$$$$$/ $$/   $$/    $$$$/   $$$$$$/  $$/       $$$$$$$$/  $$$$$$$/ $$/       $$/  $$$$$$$/  $$$$$$$ | $$$$$$/  $$/   $$/  $$$$$$$ |\r\n                                                                                                                                           /  \\__$$ |                    /  \\__$$ |\r\n                                                                                                                                           $$    $$/                     $$    $$/ \r\n                                                                                                                                            $$$$$$/                       $$$$$$/  ");

            }
        }
    }





