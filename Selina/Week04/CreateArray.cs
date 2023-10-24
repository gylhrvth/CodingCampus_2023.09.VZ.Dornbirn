using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week04.Ausagbe
{
    
    internal class CreateArray
    {
         
        //User Input:
        public static int ReadNumber(string prompt, string onError)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    int ourNumber = Convert.ToInt32(Console.ReadLine());
                    return ourNumber;
                }
                catch (Exception exc)
                {
                    Console.Error.WriteLine(onError);
                }
            }
        }

        //Random Number:
        public static int[] CreateRandomArray(int size, int from, int to)
        {
            Random rand = new Random();
            int[] randomArray = new int[size];
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rand.Next(from, to);
            }
            return randomArray;
        }

        public static int CountOver30(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 30)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
