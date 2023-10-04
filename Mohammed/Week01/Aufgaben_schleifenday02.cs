using System;
namespace Mohammed.Week01
{
    public class Day02
    {
        public static void Start()
        {

            for (int m = 0; m < 10; m++)
            {
                Console.WriteLine($"0 - 10  {m}");
            }


            int l = 0;
            while (l < 10)
            {
                Console.WriteLine($"0 -10  {l}");
                l++;
            }



            for (int d = 0; d >= 10; d++)
            {
                Console.WriteLine($"0 - 10  {d}");
            }


            int r = 11;
            if (r % 2 == 0)
            {
                Console.WriteLine("r ist gerade Zahl " + r);
            }
            else
            {
                Console.WriteLine("r ist ungerade Zahl" + r);
            }




        }

     
    }
}



