using System;
using System.Runtime.CompilerServices;

namespace Erik.Week06
{
    public class MergeTwoLists
    {
        private static Random randomNumber = new Random();


        public static void Start()
        {
            List<int> RandomList1 = CreateRandomList(10, 1, 100);
            List<int> RandomList2 = CreateRandomList(10, 1, 100);

            RandomList1 = SortRandomList(RandomList1);
            PrintListWithIndex(RandomList1);

            RandomList2 = SortRandomList(RandomList2);
            PrintListWithIndex(RandomList2);

            List<int> finalList = MergeList(RandomList1, RandomList2);
            PrintListWithIndex(finalList);
        }


        private static List<int> CreateRandomList(int size, int min, int max)
        {
            List<int> RandomList = new List<int>();
            for (int i = 0; i < size; i++)
            {
                RandomList.Add(randomNumber.Next(min, max));
            }
            return RandomList;
        }

        public static List<int> SortRandomList(List<int> unsortedList)
        {
            int n = unsortedList.Count;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (unsortedList[j] < unsortedList[j + 1])
                    {
                        int tmp = unsortedList[j];
                        unsortedList[j] = unsortedList[j + 1];
                        unsortedList[j + 1] = tmp;
                    }
                }
            }
            List<int> sortedList = unsortedList;
            return sortedList;
        }

        public static void PrintListWithIndex(List<int> list)
        {
            Console.Write("[");
            for (int i = 0; i < list.Count; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(list[i]);
            }
            Console.WriteLine("]");
        }

        public static List<int> MergeList(List<int> sortedList1, List<int> sortedList2)
        {
            int j = 0;
            int k = 0;
            List<int> finalList = new List<int>();

            while (k < sortedList1.Count && j < sortedList2.Count)
            {
                if (sortedList1[k] < sortedList2[j])
                {
                    finalList.Add(sortedList1[k]);
                    k++;
                }
                else
                {
                    finalList.Add(sortedList2[j]);
                    j++;
                }
            }

            while (k < sortedList1.Count)
            {
                finalList.Add(sortedList1[k]);
                k++;
            }


            while (j < sortedList2.Count)
            {
                finalList.Add(sortedList2[j]);
                j++;
            }

            return finalList;
        }

        /*for (int i = 0; i < sortedList1.Count + sortedList2.Count; i++)
        {
            if (sortedList1[j] > sortedList2[k])
            {
                finalList.Add(sortedList1[j]);
                j++;
            }
            else
            {
                finalList.Add(sortedList2[k]);
                k++;
            }                
        }
        return finalList;*/
    }
}
