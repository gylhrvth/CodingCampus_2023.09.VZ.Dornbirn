using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week06.Listen
{
    internal class Connect2Lists
    {
        public static void Start()
        {
            List<int> list1 = CreateList(10, 101);
            List<int> list2 = CreateList(10, 101);

            Console.Write("Sorted List1 = ");
            PrintList(BubbleSortList(list1));
            Console.WriteLine("=================================================================================================");

            Console.Write("Sorted List2 = ");
            PrintList(BubbleSortList(list2));
            Console.WriteLine("=================================================================================================");

            List<int> listResult = ConnectTwoLists(list1, list2);
            Console.Write("2 Lists Sorted = ");
            PrintList(listResult);
        }

        private static void PrintList(List<int> list)
        {
            Console.WriteLine("[{0}]", string.Join(", ", list));
        }

        private static List<int> CreateList(int size, int bound)
        {
            Random random = new Random();
            List<int> list = new List<int>();

            for (int i = 0; i < size; i++)
            {
                list.Add(random.Next(bound));
            }
            return list;
        }

        private static List<int> BubbleSortList(List<int> list)
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

        private static List<int> ConnectTwoLists(List<int> list1, List<int> list2)
        {
            List<int> listResult = new List<int>();
            int i1 = 0;
            int i2 = 0;

            while (i1 < list1.Count && i2 < list2.Count)
            {
                if (list1[i1] > list2[i2])
                {
                    listResult.Add((list2[i2]));
                    i2++;                   
                }
                else
                {
                    listResult.Add(list1[i1]);
                    i1++;
                }
            }
            while (i1 < list1.Count)
            {
                listResult.Add(list1[i1]);
                i1++;
            }

            while (i2 < list2.Count)
            {
                listResult.Add(list2[i2]);
                i2++;
            }
            return listResult;
        }
    }
}
