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
            printDecimalNumsextend();
            Console.WriteLine("PRINTSHARECONQUER");
            printShareConquer();
            Console.WriteLine("NILAKANTHAROW");
            printNilkanthaRow();
            Console.WriteLine();
            Console.WriteLine("LEIBNIZROW");
            printLeibnicReihe();



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
            for (double i = 0; i <= maxNum; i++)
            {
                d2 += i;
                Console.WriteLine(d2 / 10.0);

            }
        }
        public static double printDecimalNumsextend()
        {
            double minNum = 0;
            int maxNum = 100;
            for (double i = minNum; i <= maxNum; i += 0.1)
            {

                Console.WriteLine($"Result 1 digit = {i,3:N1}");
                Console.WriteLine($"Result 2 digit = {i,7:N2}");

            }
            return minNum;
        }
        public static double printShareConquer()
        {



            int maxNum = 20;
            int minNum = 0;


            for (int i = minNum; i <= maxNum; i++)
            {
                Console.WriteLine($"Result w int  {i}/ 5 = {i / 5}");
                Console.WriteLine($"Result w double  {i}/ 5.0 = {i / 5.0}");


            }

            return minNum;

        }

        public static double printNilkanthaRow()
        {
            double num1 = 3;
            double num2 = 2;
            double a = 0;
            double b = 0;

            for (int i = 0; i < 1; i++)
            {
                a = 4 / (num2 * (num2 + 1) * (num2 + 2));
                Console.WriteLine(a);
            }

            num2 += 2;
            for (int j = 0; j < 1; j++)
            {
                b = 4 / (num2 * (num2 + 1) * (num2 + 2));
                Console.WriteLine(b);
            }
            num2 += 2;

            num1 = 3 + (a - b);
            {
                Console.Write(num1);
            }

            return num1;
        }



        public static double printLeibnicReihe()
        {
            double num1 = 1;
            double a = 0;
            double b = 0;

            for (int i = 0; i < 10; i++)
            {
                a = 4 / (num1);
                Console.WriteLine(a);
            }

            num1 += 2;

            for (int j = 0; j < 10; j++)
            {
                b = 4 / (num1);

                Console.WriteLine(b);  
            }

            num1 += 2;

            num1 = a - b;
            {
                Console.Write(num1);

            }

            return num1;
        }
        public static double SecretRow()
        {
            double a = 1.0;
            {
                for(int i = 0; i< 10; i++)
                {
                     
                }
            }






            return 0;
        }


    }
}
