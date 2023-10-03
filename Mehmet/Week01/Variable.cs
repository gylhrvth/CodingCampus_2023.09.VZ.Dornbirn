using System;
using System.ComponentModel.Design;

namespace Mehmet.Week01
{
	public class Variable
	{
		public static void Start()
		{
			Console.WriteLine("Hello Mehmet!");

			for (int x = 0; x < 11; x++)
			{
				Console.WriteLine(x);
			}

			int y = 0;
			while (y < 11)
			{
				Console.WriteLine(y);
				y++;
			}


			for (int z = 0; z < 10; z++)
			{
				Console.WriteLine(z);
			}

            Console.WriteLine("==================");

            int w = 0;
			if (w % 2 == 0)
			{
                Console.WriteLine(w);
            }
		
	
			
		

		

        }
	}
}

