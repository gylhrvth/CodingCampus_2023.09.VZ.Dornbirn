using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week06._03List
{
    public class List
    {
        private static Random random = new Random();

        public static List<int> CreateListRandomFirst()
        {
            List<int> list = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                list.Add(random.Next(0, 100));
            }

            return list;
        }

        public static void PrintList(List<int> list)
        {
            bool first = true;
            Console.Write("[ ");
            foreach (int item in list)
            {
                if (first)
                {
                    Console.Write(item);
                    first = false;
                }
                Console.Write(", " + item);
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

        public static int CountEvenNumbersList(List<int> list)
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

        public static int FindSmallestNumber(List<int> list)
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

        public static int FindMaxValueList(List<int> list)
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

        public static void DeleteAllOddNumbersList(List<int> list)
        {
            for(int i = 0; i < list.Count; i++)
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
