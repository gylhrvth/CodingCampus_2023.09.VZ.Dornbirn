using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week02
{
    internal class PrimitiveDatentypen
    {

        public static void start()
        {
            int result = Add(20, 50);
            Console.WriteLine("i = " + result);
            Console.WriteLine("--------------------------");

            long result2 = Add2(1, 20);
            Console.WriteLine("--------------------------");

            double result3 = Add3(1000);
            Console.WriteLine("--------------------------");

            float result4 = Add4(1000);
            Console.WriteLine("--------------------------");

            int result5 = Add5(20);
            Console.WriteLine("--------------------------");

            double result6 = Add6();
            Console.WriteLine("--------------------------");

            double result7 = Add7();
            Console.WriteLine("--------------------------");

            double random = new Random().Next(10000) + 1;
            Console.WriteLine(random);
            double result8 = MathSqrt(random);
            Console.WriteLine("--------------------------");

            double result9 = MathSqrt2(1297419);
            Console.WriteLine("--------------------------");

        }


        public static int Add(int x, int y)
        {
            int result = 0;
            for (int i = x; i <= y; i++)
            {
                result += i;              
            }
            return result;
        }


        public static long Add2(int x, int y)

        {

            long result2 = x;

            for (long i = result2; i <= y; i++)
            {
                result2 *= i;
                Console.Write($"{i,2}" + "! = ");
                Console.Write($"{result2,20}");
                Console.WriteLine();
            }
            return result2;
        }

        public static double Add3(int x)
        {

            double result3 = x;

            for (double y = 0; y <= x; y++)
            {
                result3 = y;

                Console.WriteLine(result3 / 10);
            }

            return result3;
        }

        public static float Add4(float x)
        {

            float result4 = 0;
            Console.WriteLine($"{result4,-3:0.00}");
            for (float y = 0; y < x; y++)
            {
                result4 += x;
                Console.WriteLine($"{result4 / x / 10,-3:00.00}");
            }
            return result4;
        }

        public static int Add5(int y)
        {
            int result5 = 5;
            double n2 = 5;
            for (int i = 0; i <= y; i++)
            {
                Console.WriteLine($"{i}" + " / " + $"{result5}" + " = " + i / result5);
                Console.WriteLine($"{i}" + " / " + $"{n2,-3:0.0}" + " = " + $"{i / n2,2:0.0}");
            }
            return result5;
        }

        public static double Add6()
        {
            //double: 3,1415926535895253
            //        3.14159265358979323846
            //long:   3,1415926535977925
            double x = 2;
            double z = 3;
            for (int y = 0; y < 100000000; y++)
            {
                if (y % 1000000 == 0)
                {
                    Console.WriteLine(x * (x + 1) * (x + 2));
                }


                double g = 4.0 / (x * (x + 1) * (x + 2));              
                x++;
                x++;

                double h = 4.0 / (x * (x + 1) * (x + 2));
                x++;
                x++;

                z = z + (g - h);
            }
            Console.WriteLine(z);
            return z;
        }

        public static double Add7()
        {

            double n = 2.0;


            for (int y = 0; y < 15; y++)
            {
                n = (n / 2.0) + (1.0 / n);
                Console.WriteLine(n);
            }
            
            return n;
        
        }


        public static double MathSqrt(double Start)
        {
          
            
            double half = Start / 2;
            double min = 0;
            double max = Start;

            for (int y = 0; y < 10000; y++)
            {
                double quadr = half * half;
                if(quadr > Start)
                {
                    max = half;
                } else
                {
                    min = half;
                }
                half = ((max - min) / 2) + min;
            }
            Console.WriteLine(half);
            return half;
        }


        public static double MathSqrt2(double z)
        {

            
            double x = Math.Sqrt(z);
            double xhalf = x / 2;
            double min = 0;
            double max = x;
            Console.WriteLine("x  =      " + x);
           

            for (int y = 0; y < 16; y++)
            {
                
                if (xhalf * xhalf > z)
                {
                    max = xhalf;
                }
                else
                {
                    min = xhalf;
                }
                xhalf = ((max - min) / 2) + min;
                
               
            }

            Console.WriteLine("x NEU = " + xhalf);
            Console.WriteLine("%" + $"{(1 - (xhalf / x))*100,4:0.000000000}");
            return xhalf;

            

        }

    }
}
