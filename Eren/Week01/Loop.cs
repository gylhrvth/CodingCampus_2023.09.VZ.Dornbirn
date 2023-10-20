using System;
namespace Eren.Week01
{
	public class Loop
	{
		public static void Start()
		{
			//*While Loop*//
			for (int i = 0; i < 11;  i++)
			{
				Console.WriteLine(i);
			}


			//*While while*//

			int x = 0;
			while (x < 11)
            {
                Console.WriteLine(x);
				x++;
            }

			//*Exklusiv 0 und 10*//
            for (int a = 1; a < 10; a++)
            {
                Console.WriteLine(a);
            }



            //*Zähle in einer Schleife von 0 bis inklusive 10 gib nur jede gerade Zahl aus*/
            int b = 0;

            Console.WriteLine("Even Numbers :");
            for (b = 1; b <= 10; b++)
            {
                if (b % 2 == 0)
                {
                    Console.Write(b+ " ");
                }
            }

            Console.WriteLine("\nOdd Numbers :");
            for (b = 1; b <= 10; b++)
            {
                if (b % 2 != 0)
                {
                    Console.Write(b + " ");
                }
            }


            //*Zähle in einer Schleife rückwärts von 10 bis inklusive -10 und gib die Zählvariable aus.*//
            for (int c = 11; c >= -10 ; c--)
            {
                Console.WriteLine(c);
            }


        }
    }
}

