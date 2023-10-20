using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro.Week02
{
    internal class PrimitvData
    {
        public static void Start() {
            CountFloat(0, 100, 0.1f, "");
            Console.WriteLine("----------------");
            Divide(0, 20, 0.0f);
            RandomDouble();
            SecretNumb();


            Console.WriteLine($"{1234.5678:0.00}");        //"1234.57"        2 decimal places, notice that value is rounded
            Console.WriteLine($"{1234.5678,10:0.00}");     //"   1234.57"     right-aligned
            Console.WriteLine($"{1234.5678,-10:0.00}");    //"1234.57   "     left-aligned
            Console.WriteLine($"{1234.5678:0.#####}");     //"1234.5678"      5 optional digits after the decimal point
            Console.WriteLine($"{1234.5678:0.00000}");     //"1234.56780"     5 forced digits AFTER the decimal point, notice the trailing zero
            Console.WriteLine($"{1234.5678:00000.00}");    //"01234.57"       5 forced digits BEFORE the decimal point, notice the leading zero
            Console.WriteLine($"{1234.5612:0}");           //"1235"           as integer, notice that value is rounded
            Console.WriteLine($"{1234.5678:F2}");          //"1234.57"        standard fixed-point
            Console.WriteLine($"{1234.5678:F5}");          //"1234.56780"     5 digits after the decimal point, notice the trailing zero
            Console.WriteLine($"{1234.5678:g2}");          //"1.2e+03"        standard general with 2 meaningful digits, notice "e"
            Console.WriteLine($"{1234.5678:G2}");          //"1.2E+03"        standard general with 2 meaningful digits, notice "E"
            Console.WriteLine($"{1234.5678:G3}");          //"1.23E+03"       standard general with 3 meaningful digits
            Console.WriteLine($"{1234.5678:G5}");          //"1234.6"         standard general with 5 meaningful digits
            Console.WriteLine($"{1234.5678:e2}");          //"1.23e+003"      standard exponential with 2 digits after the decimal point, notice "e"
            Console.WriteLine($"{1234.5678:E3}");          //"1.235E+003"     standard exponential with 3 digits after the decimal point, notice "E"
            Console.WriteLine($"{1234.5678:N2}");          //"1,234.57"       standard numeric, notice the comma
            Console.WriteLine($"{1234.5678:C2}");          //"$1,234.57"      standard currency, notice the dollar sign
            Console.WriteLine($"{1234.5678:P2}");          //"123,456.78 %"   standard percent, notice that value is multiplied by 100
            Console.WriteLine($"{1234.5678:2}");           //"2"              :)


        }

        static void CountFloat(float Start, float End, float Steps, string result)
        {
            for (float i = Start; i <= End; i += Steps)
            {
                //result = "Result orginal float";
                //Console.WriteLine("{0,-20} = {1}", result,i);
                result = "Result 1 digit";
                Console.WriteLine("{0,-13} = {1,-1:N1}", result, i);
                result = "Result 2 digit";
                Console.WriteLine("{0,-13} = {1,7:N2}", result, i);

                //Console.WriteLine($"{i,20}");
                //Console.WriteLine($"2 decimal digits {i,20:0.00}");
            }
            Console.WriteLine();
        }

        static void Divide(int start, int end, float result)
        {
            for (int i = start; i <= end; i++)
            {
                result = i / 5;
                Console.WriteLine($"{i} / 5 = {result,5:0000.00}");
                result = i / 5.0f;
                Console.WriteLine($"{i} / 5.0 = {result,3:00.0000}");

            }
            Console.WriteLine();
        }

        static void RandomDouble()
        {
            double random = new Random().Next(10000) + 1;
            Console.WriteLine("rando int ist    = " + random);

            double root = new Random().NextDouble() + 1;
            Console.WriteLine("rando double ist = " + root);

            Console.WriteLine("----------------");

        }

        static void SecretNumb()
        {

            double secretSum = 1.0;
            Console.WriteLine($"1. element: {secretSum}");

            for (int i = 2; i < 100; i++)
            {
                secretSum = (secretSum / 2) + (1 / secretSum);
                Console.WriteLine($"{i}. element: {secretSum}");
            }

            Console.WriteLine($"Secret Number is: {secretSum}");


            Console.WriteLine("\n");
        }

// X_n+1 = X_n + X_n-1

//1 1 2 3 5 8 13 21 

    }
}
