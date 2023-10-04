using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week02
{
    internal class Booleanexamples
    {
        public static void StartBooleanExamples()
        {
            Console.WriteLine("Aufgabe Print Slash");
            PrintSlash("x", 3, true);

            Console.WriteLine("Aufgabe Print Pyramid");
            PrintPyramid("x", 3);

        }

        public static void PrintSlash(String symbol, int count, bool cas)
        {
            if (cas == true)
            {
                for (int i = 0; i < count; i++)
                {
                    for (int y = 0; y < i; y++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(symbol);
                    Console.WriteLine();
                }
            }

            if (cas == false)
            {
                count = 4;
                symbol = "y";

                for (int i = 0; i < count; i++)
                {
                    for (int y = i; y < count; y++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(symbol);
                    Console.WriteLine();
                }
            }
        }

        public static void PrintPyramid(String symbol, int count)
        {
            for(int i = 0;i < count; i++)
            {

            }
        }

        
    }
}
