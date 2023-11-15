using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Timo.Week06._01Person;

namespace Timo.Week06._03DynamischeDatenstrukturen
{
    public class List_Example
    {
        public static Random random = new Random();
        public static void Start()
        {
            //List Auswerten
            List<int> list = CreateList(20);
            PrintList(list);
            Console.WriteLine(CountStraightNumbers(list));
            Console.WriteLine(BiggestNumber(list));
            Console.WriteLine(SmalestNumber(list));
            PrintList(SortedList(list, false));
            PrintList(DeleteOdd(list));
            Console.WriteLine("=====================================");

            //List zusammenfügen
            List<int> List1 = CreateList(20);
            SortedList(List1, true);
            List<int> List2 = CreateList(20);
            SortedList(List2, true);
            PrintList(MergeLists(List2, List2));
            



        }

        public static List<int> CreateList(int max)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < max; i++)
            {
                list.Add(random.Next(0, 100));
            }
            return list;
        }
        public static void PrintList(List<int> list)
        {
            Console.WriteLine("[{0}]", string.Join(", ", list));
        }
        public static void PrintList(List<Person> list)
        {
            Console.WriteLine("[{0}]", string.Join(", \n", list));
        }
        public static int CountStraightNumbers(List<int> list)
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
        public static int BiggestNumber(List<int> list)
        {
            int biggestNumber = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > biggestNumber)
                {
                    biggestNumber = list[i];
                }
            }
            return biggestNumber;
        }
        public static int SmalestNumber(List<int> list)
        {
            int biggestNumber = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < biggestNumber)
                {
                    biggestNumber = list[i];
                }
            }
            return biggestNumber;
        }
        public static List<int> SortedList(List<int> list, bool asc)
        {
            for (int i = list.Count; i > 1; i--)
            {
                for (int a = 0; a < i - 1; a++)
                {
                    if ((asc && list[a] > list[a + 1]) || (!asc && list[a] < list[a + 1]))
                    {
                        int temp = list[a + 1];
                        list[a + 1] = list[a];
                        list[a] = temp;
                    }
                }
            }
            return list;
        }
        public static List<int> DeleteOdd(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 1)
                {
                    list.Remove(list[i]);
                    i = i - 1;
                }
            }
            return list;
        }

        public static List<int> MergeLists(List<int> l1, List<int> l2)
        {
            List<int> megedList = new List<int>();

            int iLeft = 0;
            int iRight = 0;

            // mergesort
            while (iLeft < l1.Count && iRight < l2.Count)
            {
                if (l1[iLeft] < l2[iRight])
                {
                    megedList.Add(l1[iLeft]);
                    ++iLeft;
                }
                else
                {
                    megedList.Add(l2[iRight]);
                    ++iRight;
                }
            }
            while (iLeft < l1.Count)
            {
                megedList.Add(l1[iLeft]);
                ++iLeft;
            }
            while (iRight < l2.Count)
            {
                megedList.Add(l2[iRight]);
                ++iRight;
            }
            return megedList;
        }
    }
}
