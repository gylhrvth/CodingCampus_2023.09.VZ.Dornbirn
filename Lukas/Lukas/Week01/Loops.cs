using System;
namespace Lukas.Week01
{
    public class Loops
    {
        public Loops()
        {
        }

        public static void Start()
        {


            for (int j = 0; j < 100; j++)
            {
                Console.WriteLine("Hallo");
            }


            int i = 0;
            while (i < 100)
            {
                Console.WriteLine("Hallo");
                i++;
            }

            Console.WriteLine("Triangle:");
            PrintTriangleTopRight("q", 5);

        }


        public static void PrintTriangleTopRight(string letter, int height)
        {
            for (int i = 0; i < height; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                //Tolle Lösung
                //for(int x=height - 1; x >= i; x--)
                //{
                //    Console.Write(letter);
                //}
                //Console.Write(height - i);

                for (int x = 0; x < height - i; x++)
                {
                    Console.Write(letter);
                }

                Console.WriteLine();
            }
        }
    }
}

