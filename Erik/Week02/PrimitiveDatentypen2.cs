﻿using System;
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
            PrintingTheSumOfNumbers(20, 50);
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
        public static void CalculateTheFactorial()
        {




        }
        
    }
}



