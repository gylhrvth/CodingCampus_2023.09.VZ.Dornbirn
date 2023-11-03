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

        public static void Main()
        {
            //List<int> list = CreateRandomList(20, 0, 100);
            //PrintList(list);
            //Console.WriteLine();
            //Console.WriteLine(CountEvenNumbersList(list));
            //Console.WriteLine();
            //Console.WriteLine(FindSmallestNumber(list));
            //Console.WriteLine();
            //Console.WriteLine(FindMaxValueList(list));
            //Console.WriteLine();

            ////easy
            ///*
            //list.Sort();
            //PrintList(list);
            //list.Reverse();
            //PrintList(list);
            //*/

            //PrintList(BubbleSortList(list));

            //DeleteAllOddNumbersList(list);

            //PrintList(list);

            //List<int> list1 = CreateRandomList(20, 0, 100);
            //List<int> list2 = CreateRandomList(20, 0, 100);

            //list1.Sort();
            //list2.Sort();

            //PrintList(MergeOrderedLists(list1, list2));


            List<char> list = new() { 'a', 'b', 'c' };

            foreach (char c in list)
            {
                Console.Write("{0} ", c);
            }
            Console.WriteLine();

            heapPermutationList(list.Count, list);
        }

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

        public static List<int> MergeOrderedLists(List<int> list1, List<int> list2)
        {
            List<int> result = new List<int>();

            int i = 0;
            int j = 0;
            int k = 0;
            while (i < list1.Count && j < list2.Count)
            {
                if (list1[i] < list2[j])
                {

                    result.Add(list1[i]);
                    ++k;
                    ++i;
                }
                else
                {

                    result.Add(list2[j]);
                    ++k;
                    ++j;
                }
            }

            while (i < list1.Count)
            {

                result.Add(list1[i]);
                ++k;
                ++i;
            }

            while (j < list2.Count)
            {

                result.Add(list2[j]);
                ++k;
                ++j;
            }

  

            return result;
        }

        public static List<char> heapPermutationList(int k, List<char> charList)
        {
            int count = 0;
            if (k <= 1)
            {
                return charList;
            } else
            {

                heapPermutationList(k - 1, charList);
                for(int i = 0; i < k-1; i++)
                {
                    if(k % 2 == 0)
                    {
                        char temp = charList[i];
                        charList[i] = charList[k - 1];
                        charList[k - 1] = temp;

                    } else
                    {
                        char temp = charList[0];
                        charList[0] = charList[k - 1];
                        charList[k - 1] = temp;

                    }

                    count++;

                    foreach (char c in charList)
                    {
                        Console.Write("{0} ", c);
                    }
                    Console.WriteLine();


                    heapPermutationList(k - 1, charList);


                }

                return charList;

            }
        }

    }
}
