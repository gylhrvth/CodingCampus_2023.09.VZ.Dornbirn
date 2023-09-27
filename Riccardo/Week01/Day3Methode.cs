using System;
namespace Riccardo.Week01
{
    public class Day3Methode
    {
        public Day3Methode()
        {
        }

        public static void Start()
        {
            printsquare("x", 10);
               
        }

        public static void printsquare(string symbol, int count) 
        {
            for (int x = 0; x < count; x++)
            {
                Console.Write(symbol);
                
                for (int y = 0; y < count; y++)
                {
                    Console.WriteLine(symbol);
                }
            }

        }
    }
}