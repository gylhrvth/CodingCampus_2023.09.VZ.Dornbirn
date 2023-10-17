using System;
namespace Eren.Week03
{
    public class ArrayMinMaxAvg
    {
        public static Random rand = new Random();

        public static void StartArrayMinMaxAvg()
        {

            int[] Randomnum = RandomArray(10);

            foreach(int element in Randomnum)
            {
                Console.Write(element+ " ");
            }
            Console.WriteLine();

            int ArrMin = ArrayMin(Randomnum);

            Console.WriteLine("Minimum = "+ ArrMin);

            int ArrMax = ArrayMax(Randomnum);

            Console.WriteLine("Maximum = " + ArrMax);

            double ArrAvg = ArrayAvg(Randomnum);

            Console.WriteLine("Average = " + ArrAvg);

        }

        public static int[] RandomArray(int size)
        {
            int[] Array = new int[size];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = rand.Next(0, 100);
            }
            return Array;
        }

        public static int ArrayMin(int[] Randomnum)
        {
            return Randomnum.Min();
        }
        public static int ArrayMax(int[] Randomnum)
        {
            return Randomnum.Max();
        }
        public static double ArrayAvg(int[] Randomnum)
        {
            return Randomnum.Average();
        }

    }

}


