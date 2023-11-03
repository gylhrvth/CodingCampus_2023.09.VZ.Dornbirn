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
            CreateList(20, 1, 101);
            List<int> list = CreateList(20, -20, -10);
            PrintList(list);

            Console.WriteLine("List with even Numbers: ");
            List<int> evenNum = PrintEvenNumber(list);
            PrintList(evenNum);

            Console.WriteLine("List with odd Numbers: ");
            List<int> unEven = PrintOddNumber(list);
            PrintList(unEven);

            Console.WriteLine("Biggest Number: ");
            int biggest = BiggestNumber(list);
            Print(biggest);
            int countOfEven = CountEvenNumber(list);

            Console.WriteLine("Anzahl gerader Zahlen: ");
            Print(countOfEven);

            Console.WriteLine("Zahlen absteigend sortiert: ");
            List<int> listDesc = SortListDes(list);
            PrintList(listDesc);

            List<int> desList = SortBySizeDes(list);
            PrintList(desList);

            Console.WriteLine("Liste mit gelöschten ungeraden Zahlen: ");
            List<int> remList = SortRemove1(list);
            PrintList(remList);

            List<int> sortRem = SortRemove2(remList);
            PrintList(sortRem);

            List<int> newSortRem = SortRemove3(list);
            PrintList(newSortRem);

            List<int> jointList = JoinList(list, desList);
            PrintList(jointList);

        }

        public static void PrintList(List<int> value)
        {
            Console.WriteLine("[{0}]", string.Join(", ", value));
        }
        public static void Print(int value)
        {
            Console.WriteLine("[{0}]", value);
        }

        public static List<int> CreateList(int size, int boundMin, int boundMax)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < size; i++)
            {
                list.Add(random.Next(boundMin, boundMax));
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
        public static List<int> PrintOddNumber(List<int> list)
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
            int biggest = int.MinValue;

            foreach (var number in list)
            {
                if (number > biggest)
                {
                    biggest = number;
                }
            }
            return biggest;
        }


        public static List<int> SortListDes(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count -i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            return list;
        }

        public static int Compare(int a, int b)
        {
            return b - a;
        }
        public static List<int> SortBySizeDes(List<int> list)
        {
            list.Sort(Compare);

            return list;
        }

        public static List<int> SortRemove1(List<int> list)
        {
            List<int> remList = new List<int>(list);

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            return list;
        }

        public static List<int> SortRemove2(List<int> list)
        {
            List<int> evenNumbers = SortRemove1(list);
            foreach (var number in evenNumbers)
            {
            }
            return evenNumbers;
        }

        public static List<int> SortRemove3(List<int> list)
        {
            list.Where(number => number % 2 == 0);

            return list;
        }

        public static List<int> JoinList(List<int> randomList, List<int> sortedList)
        {
            List<int> jointList = new List<int>(randomList);
            randomList.AddRange(sortedList);

            return randomList;
        }
    }
}
