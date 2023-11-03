using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sven.Week06.OOPList.ListBasis;
using static Sven.Week06.OOPList.Mergesort;

namespace Sven.Week06.OOPList
{


    internal class List
    {
        public static void Start()
        {

            List<int> list = CreateRandomList(20, 0, 101);
            Console.WriteLine("Print My Random Number List:");
            PrintList(list);

            Console.WriteLine("\nCount even Numbers:" + CountEvenNumbers(list));

            Console.WriteLine("\nSmallest Number:" + GetSmallestNumber(list));

            Console.WriteLine("\nBiggest Number:" + GetBiggestNumber(list));

            Console.WriteLine("Sort Numbers:");
            PrintList(BubbleSortList(list));

            Console.WriteLine("Without Odd Numbers:");
            DeleteOddNumbers(list);

            PrintList(list);

            Console.WriteLine("MergeSortList");
            List<int> list1 = CreateRandomList(20, 1, 101);
            List<int> list2 = CreateRandomList(20, 1, 101);
            BubbleSortList(list1);
            BubbleSortList(list2);

            PrintList(list1);
            Console.WriteLine("================================================================================");
            PrintList(list2);
            Console.WriteLine("================================================================================");
            PrintList(MergeSort(list1, list2));



        }

    }
}