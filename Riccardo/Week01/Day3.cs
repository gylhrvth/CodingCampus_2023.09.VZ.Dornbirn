using System;
namespace Riccardo.Week01
{
    public class Day3
    {
        public static void Start()
        {
            for (int x = 0; x < 11; x++)
            {
                Console.WriteLine($"{x}");
            }

            int k = 0;
            while (k < 11)
            {
                Console.WriteLine($"{k}");
                k = k + 1;
            }

            int y = 0;
            while (y < 10)
            {
                Console.WriteLine($"{y}");
                y = y + 1;
            }

            for (int x = 0; x < 11; x++)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine("Ist gerade!!! " + x);
                }
                else
                {
                    Console.WriteLine("Ist ungerade!!!" + x);
                }
            }

            int l = 10;
            while (l >= -10)
            {
                Console.WriteLine(l);
                l = l - 1;
            }

            for (int r = 10; r >= -10; r--)
            {
                Console.WriteLine(r);
            }
                
        }      
    }
}

