using System;
namespace David.Week01
{
	public class Day2
	{
		public static void Start()
		{

            for(int i = 0; i <= 10; i++)
            {
				Console.WriteLine(i);
			}

			int k = 0;
			while( k <= 10)
			{
				Console.WriteLine("while " + k);
				k++;
			}
			{
			for(int j = 0; j< 10; j++)
				{
					Console.WriteLine(j);
				}
			}
			{
			int r = 0;
			while(r < 10)
				{
					Console.WriteLine(r);
					r++;
				}


			for (int z = 0; z <= 10; z++)
				{
					if (z % 2 == 0)
					{
						Console.WriteLine(z);
		
					}
				}
                for (int w = 10; w >= -10; w--)
                {
                    Console.WriteLine(w);
                }
            }
        }
	
	}
}
