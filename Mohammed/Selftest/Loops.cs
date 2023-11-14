using System;
namespace Mohammed.Selftest
{
    public class Loops
    {
        public static void Start()
        {
            //Aufgabe1
            
            //for (int i = 10; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //Aufgabe 2

            for (int j = -30; j <= 30; j += 3)
            {
                Console.WriteLine(j);
            }

            //Aufgabe3
            int i = 0;

            while (i <= 10)
            {
                Console.WriteLine(i);

                if (i > 5)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                }
                i++;


            }


        }

        

       
    }
}

