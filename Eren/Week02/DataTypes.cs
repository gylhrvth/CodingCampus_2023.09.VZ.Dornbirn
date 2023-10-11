using System;
namespace Eren.Week02
{
	public class DataTypes
	{
		public static void StartDataTypes()
		{
			int a = 1;
			int b = -1;

			Console.WriteLine("ist gleich: " + (a == b));

			sbyte test = 120;
			for (int i = 0; i < 20; i++)
			{
				Console.WriteLine("test2 = " + test);
				++test;
			}

			double d = 5.0;
			Console.WriteLine("d = " + d);
			for (int i = 0; i < 20; i++)
			{
                d = d + 0.1;
                Console.WriteLine("d = " + d);
            }

			int d2 = 500;
			for (int i = 0; i < 20; i++)
			{
				d2 = d2 + 10;
				Console.WriteLine("d2 = " + (d2 / 100.0));
			}



			Console.WriteLine("a + 1 = " + (a + 1)); // Addition
            Console.WriteLine("a - 3 = " + (a - 3)); // Substraktion
            Console.WriteLine("a * 5 = " + (a * 5)); // Multiplikation
            Console.WriteLine("a / 5 = " + (a / 5)); // Division (integer)
            Console.WriteLine("a % 5 = " + (a % 5)); // Modulo (Restwert)


			d = 5.25;
            Console.WriteLine("d + 1 = " + (d + 1)); // Addition
            Console.WriteLine("d - 3 = " + (d - 3)); // Substraktion
            Console.WriteLine("d * 5 = " + (d * 5)); // Multiplikation
            Console.WriteLine("d / 5 = " + (d / 5)); // Division (double)

			Console.WriteLine("a = " + a);
			++a;
            Console.WriteLine("a = " + a);
			a++;
            Console.WriteLine("a = " + a);


            Console.WriteLine("a!!! = " + (a++));
            Console.WriteLine("a!!! = " + (++a));


			a += 5; // a = a + 5
            Console.WriteLine("a = " + a);
            a -= 8; // a = a - 8
            Console.WriteLine("a = " + a);
            a *= 2; // a = a * 2
            Console.WriteLine("a = " + a);
            a /= 5; // a = a / 5
            Console.WriteLine("a = " + a);



           


        }


        public static void StartFaktorial()
		{
			
		}
    }
}

