using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Simon.Week02;

namespace Simon.Week06.Listen
{
    public class Listenerstellen
    {
        private static Random rand = new Random();
        public static void Start()
        {
            List<int> l1 = (SortListAscending(CreateList(0, 100, 20)));
            PrintList(l1); // wieso funktioniert nicht?????????
            List<int> l2 = (SortListAscending(CreateList(0, 100, 20)));
            List<int> l3 = (SortListAscending(CreateList(0, 100, 20)));

            Console.WriteLine("straigt numbers:");
            Console.WriteLine(CountStraightNumbers(l1));
            Console.WriteLine("smallest number:");
            Console.WriteLine(SearchLowestNumber(l1));
            Console.WriteLine("highest number:");
            Console.WriteLine(SearchHighestNumber(l1));
            Console.WriteLine("sort desc:");
            PrintList(SortListDecending(l1));
            Console.WriteLine("delete not straight:");
            PrintList(DeleteOddNumbers(l1));
            Console.WriteLine();
            PrintList(l2);
            PrintList(l3);

            Console.WriteLine("2 Lists added");
            PrintList(AddLists(l2, l3));
        }

        public static List<int> CreateList(int lower, int upper, int size)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < size; i++)
            {
                list.Add(rand.Next(lower, upper));
            }
            return list;
        }

        public static void PrintList(List<int> list)
        {
            Console.WriteLine("[{0}]", string.Join(", ", list));
        }

        public static int CountStraightNumbers(List<int> list)
        {
            int count = 0;
            //muss ich hier kopieren dass Original liste nicht verändert wird
            for (int i = 0; i < list.Count; i++)
                //wie macht er die nummerierung macht der die bevor er löscht oder wird beim löschen von 2 das 3 zu 2
            {
                if (list[i] % 2 != 0)
                {
                    ++count;
                }
            }
            return count;
        }

        public static int SearchLowestNumber(List<int> list)
        {
            return list.Min();
        }

        public static int SearchHighestNumber(List<int> list)
        {
            return list.Max();
        }

        public static List<int> SortListDecending(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j] < list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            return list;
        }
        public static List<int> SortListAscending(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
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
        public static List<int> DeleteOddNumbers(List<int> list)
        {
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

        public static List<int> AddLists(List<int> list1, List<int> list2)
        {
            List <int> list = new List<int>();
            //list1.AddRange(list2); //wie kann ich hier mit neuem namen initailiserein?
            int i = 0;
            int j = 0;
            while (i < list1.Count && j < list2.Count)
            {
                if (list1[i] < list2[j])
                {
                    list.Add(list1[i]);
                    i++;
                }
                else
                {
                    list.Add(list2[j]);
                    j++;
                }
            }
            while (i < list1.Count)
            {
                list.Add(list1[i]);
                i++;
            }
            while(j < list2.Count)
            {
                list.Add(list2[j]);
                j++;
            }
            return list;
        }

    }
}
