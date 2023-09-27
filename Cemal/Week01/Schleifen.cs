using System;
using System.Runtime.InteropServices;

namespace Cemal.Week01
{

	public class Schleifen
	{
		public static void Aufgabe1()
		{
            Console.WriteLine("Aufgabe 1");

            for (int i = 0; i <= 10; i++)
			{
				Console.WriteLine("For-Schleife: " + i);
			}

			int k = 0;

			while (k <= 10)
			{
                Console.WriteLine("While-Schleife: " + k);

				k++;
            }


            Console.WriteLine("Aufgabe 2");

            for (int o = 0; o < 10; o++)
			{
				Console.WriteLine(o);
			}

            Console.WriteLine("Aufgabe 3");

            for (int z = 0; z <= 10; z++)
			{
				if (z % 2 == 0)
				{
					Console.WriteLine(z);
				}
			}

            Console.WriteLine("Aufgabe 4");

			for (int e = 10; e >= -10; e--)
			{
				Console.WriteLine(e);
			}
		}
	}

}
