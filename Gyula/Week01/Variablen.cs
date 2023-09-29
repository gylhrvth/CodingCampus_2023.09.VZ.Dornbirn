using System;
namespace Gyula.Week01
{
	public class Variablen
	{
		public static void MyVariablen()
		{
			int i = 12;
			Console.WriteLine(i);
			i = 10;
			Console.WriteLine(i);
			i = i + 3;
			Console.WriteLine(i);
			i = i * 10;
			Console.WriteLine(i);
			i = i - 100;
			Console.WriteLine(i);
			i = i / 10;
            Console.WriteLine(i);

			/*
			i++;
			i = i + 1;
			*/

			/* For Schleife für zählen */
			for (int j = 0; j < 10; ++j)
			{
				Console.WriteLine(j + ". Hello World!");
			}

			int k = 0;
			while (k < 10)
			{
				Console.WriteLine("k: " + k);
				++k;
			}

			for (int l = 10; l > 0; l--)
			{
				if (l > 5)
				{
					Console.Write("Hello ");
				}
				Console.WriteLine("L: " + l);
			}

            for (int m = 0; m < 10; m++)
            {
				if (m > 5)
				{
					Console.Write("Apfel ");
				} else
				{
					Console.Write("Birne ");
				}
				Console.WriteLine(m);
            }


        }
    }
}

