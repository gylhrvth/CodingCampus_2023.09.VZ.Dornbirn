using System.Numerics;

namespace Fabian.Week06
{
    public class Lists
    {
        private static Random rnd = new();
        public static void Start()
        {
            List<int> list = CreateListRandom(20);
            PrintList(list);
            Console.WriteLine("\n");
            Console.WriteLine("Even numbers: " + CountEvenNums(list));
            Console.WriteLine("Smallest number: " + GetSmallest(list));
            Console.WriteLine("Biggest number: {0}\n", GetBiggest(list));
            List<int> sorted = SortList(list, false);
            Console.Write("Sorted list: ");
            PrintList(sorted);
            Console.WriteLine("\n");
            List<int> list2 = RemoveOddNums(sorted);
            Console.Write("Remove odd numbers: ");
            PrintList(list2);
            Console.WriteLine("\n");
            List<int> list3 = CreateListRandom(20);
            List<int> list4 = CreateListRandom(20);
            Console.Write("Add 2 sorted lists together: ");
            PrintList(Add2Lists(list3, list4));
            Console.WriteLine("\n");


        }
        public static void PrintList(List<int> list)
        {
            bool first = true;
            foreach (int i in list)
            {
                if (!first) Console.Write(", " + i);
                else Console.Write(i);
                first = false;
            }
        }
        public static List<int> CreateListRandom(int size)
        {
            List<int> list = new();
            
            for (int i = 0; i < size; i++)
            {
                list.Add(rnd.Next(100));
            }
            return list;
        }       
        public static int CountEvenNums(List<int> list)
        {
            int count = 0;

            foreach (int i in list)
            {
                if(i % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        public static int GetSmallest(List<int> list)
        {
            int min = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < min)
                {
                    min = list[i];
                }
            }
            return min;
        }
        public static int GetBiggest(List<int> list)
        {
            int max = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
            }
            return max;
        }
        public static List<int> SortList(List<int> list, bool asc)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (asc && list[j] > list[j + 1]|| !asc && list[j] < list[j + 1])
                    {
                        (list[j], list[j + 1]) = (list[j + 1], list[j]);
                    }
                }
            }
            return list;
        }
        public static List<int> RemoveOddNums(List<int> list)
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
        public static List<int> Add2Lists(List<int> list1, List<int> list2) 
        {
            list1 = SortList(list1, true);
            list2 = SortList(list2, true);

            List<int> result = new List<int>();

            int iLeft = 0;
            int iRight = 0;

            // mergesort
            while (iLeft < list1.Count && iRight < list2.Count)
            {
                if (list1[iLeft] < list2[iRight])
                {
                    result.Add(list1[iLeft]);
                    ++iLeft;
                }
                else
                {
                    result.Add(list2[iRight]);
                    ++iRight;
                }
            }
            while (iLeft < list1.Count)
            {
                result.Add(list1[iLeft]);
                ++iLeft;
            }
            while (iRight < list2.Count)
            {
                result.Add(list2[iRight]);
                ++iRight;
            }


            return result;
        }
    }
}
