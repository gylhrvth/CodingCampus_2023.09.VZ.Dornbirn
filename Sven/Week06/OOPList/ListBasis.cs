using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week06.OOPList
{
    internal class ListBasis
    {

        private static Random random = new Random();


        public static void PrintList(List<int> list)
        {
            bool first = true;
            Console.Write("[ ");
            foreach (int element in list)
            {
                if (first)
                {
                    Console.Write(element);
                    first = false;
                }
                Console.Write(", " + element);


            }
            Console.Write(" ]");
            Console.WriteLine();
        }

        public static List<int> CreateRandomList(int count, int min, int max)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < count; i++)
            {
                list.Add(random.Next(min, max));
            }


            return list;

        }

        public static int CountEvenNumbers(List<int> list)
        {
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    count++;
                }

            }
            return count;
        }

        public static int GetSmallestNumber(List<int> list)
        {
            int result = int.MaxValue;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < result)
                {
                    result = list[i];
                }
            }

            return result;
        }

        public static int GetBiggestNumber(List<int> list)
        {
            int result = int.MinValue;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > result)
                {
                    result = list[i];
                }
            }

            return result;
        }

        public static List<int> BubbleSortList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] < list[j])
                    {
                        int temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return list;
        }

        public static void DeleteOddNumbers(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    list.RemoveAt(i);
                    i--;

                }
            }
        }
    }
}
