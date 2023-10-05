using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week02
{
    internal class DataTypes
    {
        public static void Start()
        {
            Console.Write("SUM = ");
            int sum = AddprintSum(20, 50);
            Console.WriteLine(sum);
            Console.WriteLine("PRINTFACTORIAL");
            PrintFactorial(20);
            Console.WriteLine("PRINTDECIMALNUMS");
            double d = printDecimalNums(1000);
            Console.WriteLine();
            Console.WriteLine("PRINTDECIMALNUMSV2");
            printDecimalNumsV2(1000);
            Console.WriteLine("PRINTDECIMALNUMSEXTEND");
            double d3 = printDecimalNumsextend(0, 100);



        }
        public static int AddprintSum(int minNum, int maxNum)
        {
            int sum = 0;

            for (int i = minNum; i <= maxNum; i++)
            {
                sum += i;

            }
            return sum;


        }
        //Faktorial ausdrucken
        public static void PrintFactorial(int maxNum)
        {
            for (int i = 1; i <= maxNum; i++)
            {
                Console.WriteLine("{0,2}! ={1,20}", i, CalcFactorial(i));
            }
        }

        //Faktorial berechnen
        public static long CalcFactorial(int maxNum)
        {
            long result = 1;
            for (int i = 1; i <= maxNum; i++)
            {
                result = result * i;
            }
            return result;
        }
        public static double printDecimalNums(int maxNum) 
        {
            double d = 0.0;
            for (double i = 0.0; i <= maxNum; i++)
            {

                d = i;
                Console.WriteLine(d / 10.0);
                
                
            }
            
            return d;

        }
        public static void printDecimalNumsV2(int maxNum)
        {
            double d2 = 0;
            for(double i = 0; i <=maxNum; i++)
            {
                d2 += i;
                Console.WriteLine(d2 / 10.0);
                
            }
        }
        public static double printDecimalNumsextend(int minNum, int maxNum)
        {
            double d3 = 0;
            for (double i = minNum; i <= maxNum; i += 0.1)
            {
                d3 += 0.1;
                Console.WriteLine($"Result 1 digit = {i,3:N1}");
                Console.WriteLine($"Result 2 digit = {i,7:N2}");
                
            }
            return d3;
        }


    }
}
