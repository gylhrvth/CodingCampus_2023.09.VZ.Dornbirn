using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week06.List
{



    public class ListEvaluator
    {
        public static Random random = new Random();

        public static void Start()
        {

            List<int> list = CreateList(20);
            List<int> list1 = CreateList(20);
            List<int> list2= CreateList(20);


            foreach (int value in list)
            {



                Console.Write(value + ",");
            }

            Console.WriteLine();

            Console.WriteLine("Anzahl der geraden Zahlen: " + CountEven(list));
            Console.WriteLine("=========================");

            Console.WriteLine("Kleinte Zahl ist:");
            Console.WriteLine(FindMin(list));
            Console.WriteLine("========================");

            Console.WriteLine("Größer Zahl ist:");
            Console.WriteLine(FindMax(list));
            Console.WriteLine("========================");

            Console.WriteLine("SortedList Ascending:");
            BubbleSortList(list);
            PrintList(list);
            Console.WriteLine("========================");


            Console.WriteLine("Removed Number:");
            DeleteOdd(list);
            PrintList((list));
            Console.WriteLine("========================");


            Console.WriteLine("SortedMerge:");    
            SortingMerge( list1, list2 );
            PrintList(list);
            Console.WriteLine("==========================");


        }



        public static List<int> CreateList(int size)

        {
            List<int> list = new List<int>();
            for (int i = 0; i < size; i++)
            {
                list.Add(random.Next(1, 100));

            }
            return list;
        }

        public static int CountEven(List<int> list)
        {
            int countEven = 0;
            foreach (int value in list)
            {
                if (value % 2 == 0)
                {
                    countEven++;
                }

            }
            return countEven;
        }

        public static int FindMin(List<int> list)
        {
            int min = int.MaxValue;
            foreach (int value in list)
            {
                if (value < min)
                {
                    min = value;
                }
            }
            return min;
        }

        public static int FindMax(List<int> list)
        {
            int max = int.MinValue;
            foreach (int value in list)
            {
                if (value > max)
                {
                    max = value;
                }
            }
            return max;
        }

        public static List<int> BubbleSortList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] > list[j])
                    {
                        int temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return list;

        }

        public static void DeleteOdd(List<int> list)
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
        public static void PrintList(List<int> list)
        {
            foreach (int value in list)
            {
                Console.WriteLine(value);
            }
        }
        public static List<int> SortingMerge(List<int> list1, List<int> list2)
        {
            int i = 0;
            int j = 0;
            List<int> result = new List<int>();

            while (i < list1.Count && j < list2.Count)
            {
                if ((list1[i] < list2[j]))
                {
                    result.Add(list1[i]);
                    i++;
                }
                else
                {
                    result.Add(list2[j]);
                    j++;
                }
                while (i < list1.Count)
                {
                    result.Add(list1[i]);
                    i++;
                }
                while (j < list2.Count)
                {
                    result.Add(list2[j]);
                    j++;
                }
               
            }
            return result;

        }
    }
}











