using System;
namespace David.Week01
{
    public class Methoden
    {


        public static void Start()
        {
            PrintChars("x", 10);
        }


        public static void PrintChars(String symbol, int count)
        {
            Console.WriteLine("Print Characters");
            for (int i = 0; i < count; ++i)
            {
                Console.Write(symbol);
            }


            Console.WriteLine("\n\nPrint Square");
            for (int j = 0; j < count; ++j)
            {
                for (int z = 0; z < count; z++)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine();
            }


            Console.WriteLine("\nPrint Rectangele(2)");
            for (int q = 0; q < 3; q++)
            {
                for (int p = 0; p < count; p++)
                {
                    Console.Write(symbol);
                }

                    Console.WriteLine();
                

            }

            Console.WriteLine("\nPrint Triangle(3)");
            for (int q = 0; q < 4; q++)
            {
                for (int p = 0; p < count; p++)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine();


            }
            Console.WriteLine("\nPrint Triangle(4)")

        }



    }










    
}


