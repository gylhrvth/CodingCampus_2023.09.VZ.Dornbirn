using Ali.Week06.Liste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ali.Week06.Liste1;
using static Ali.Week06.Liste.MergeList;

namespace Ali.Week06
{
    public class ListeEx
    {
        public static void Start()
        {
            List<int> list = CreateRandomList(19);
            Console.WriteLine("Print My Random Number List:");
            PrintList(list);

            Console.Write("Count Even Numbers:" + CountEvenNumbers(list));

            Console.Write("\nSmallest Numbers:" + SearchSmallestNumber(list));

            Console.WriteLine("\nBiggest Number:" + SearchBiggestNumber(list));

            Console.WriteLine("Sort My Numbers:");
            PrintList(SortListDesc(list));

            //Console.WriteLine("Odd Numbers deleted:");
            //RemoveOddNumber(list);

            List<int> list1 = CreateRandomList(19);
            List<int> list2 = CreateRandomList(15);
            PrintList(list1);
            PrintList(list2);
            MergeList1(list2);

        }
    }
}

