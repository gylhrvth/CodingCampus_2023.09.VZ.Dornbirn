using System;
using System.ComponentModel;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace David.Week06
{
    public class List1
    {
        public static Random random = new Random(123);

        public static void Start()
        {
            Console.WriteLine("Create List with random Numbers: ");
            CreateList(20);
            List<int> list = CreateList(20);
            PrintList(list);

            Console.WriteLine("List with even Numbers: ");
            List<int> evenNum = PrintEvenNumber(list);
            PrintList(evenNum);

            Console.WriteLine("List with UNeven Numbers: ");
            List<int> unEven = PrintUnEvenNumber(list);
            PrintList(unEven);

            Console.WriteLine("Biggest Number: ");
            int biggest = BiggestNumber(list);
            Print(biggest);
            int countOfEven = CountEvenNumber(list);

            Console.WriteLine("Anzahl gerader Zahlen: ");
            Print(countOfEven);

            Console.WriteLine("Zahlen absteigend sortiert: ");
            List<int> desList = SortBySizeDes(list);
            PrintList(desList);

            Console.WriteLine("Liste mit gelöschten ungeraden Zahlen: ");
            List<int> remList = SortRemove(list);
            List<int> sortRem = PrintSortRemove(remList);
            PrintList(remList);

            List<int> newSortRem = SortRem(list);
            PrintList(newSortRem);
        }

        public static void PrintList(List<int> value)
        {
            Console.WriteLine("[{0}]", string.Join(", ", value));
        }
        public static void Print(int value)
        {
            Console.WriteLine("[{0}]", value);
        }

        public static List<int> CreateList(int size)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < size; i++)
            {
                list.Add(random.Next(0, 100));
            }
            return list;
        }

        public static List<int> PrintEvenNumber(List<int> list)
        {
            List<int> evenNumbers = new List<int>();

            foreach (var number in list)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }
            return evenNumbers;
        }
        public static int CountEvenNumber(List<int> list)
        {
            int count = 0;

            foreach (var number in list)
            {
                if (number % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        public static List<int> PrintUnEvenNumber(List<int> list)
        {
            List<int> evenUnNumbers = new List<int>();

            foreach (var number in list)
            {
                if (number % 2 != 0)
                {
                    evenUnNumbers.Add(number);
                }
            }
            return evenUnNumbers;
        }

        public static int BiggestNumber(List<int> list)
        {
            List<int> evenUnNumbers = new List<int>();
            int biggest = 0;

            foreach (var number in list)
            {
                if (number > biggest)
                {
                    biggest = number;
                }
            }
            return biggest;
        }


        public static int Compare(int a, int b)
        {
            return b - a;
        }
        public static List<int> SortBySizeDes(List<int> list)
        {
            list.Sort(Compare);

            foreach (var number in list)
            {

            }
            return list;
        }


        public static List<int> SortRemove(List<int> list)
        {
            List<int> remList = new List<int>(list);

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    list.RemoveAt(i);
                }
            }
        
            return list;
        }

        public static List<int> PrintSortRemove(List<int> list)
        {
            List<int> evenNumbers = SortRemove(list);
            foreach (var number in evenNumbers)
            {
            }
            return evenNumbers;
        }

        public static List<int> SortRem(List<int> list)
        {
            list.Where(number => number % 2 == 0);
            return list;
        }
    }
}
