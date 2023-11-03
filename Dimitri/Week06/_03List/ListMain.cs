using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dimitri.Week06._03List.List;

namespace Dimitri.Week06._03List
{
    internal class ListMain
    {
        public static void Main()
        {
            //List<int> list = CreateRandomList(20, 0, 100);
            //PrintList(list);
            //Console.WriteLine();
            //Console.WriteLine(CountEvenNumbersList(list));
            //Console.WriteLine();
            //Console.WriteLine(FindSmallestNumber(list));
            //Console.WriteLine();
            //Console.WriteLine(FindMaxValueList(list));
            //Console.WriteLine();

            ////easy
            ///*
            //list.Sort();
            //PrintList(list);
            //list.Reverse();
            //PrintList(list);
            //*/

            //PrintList(BubbleSortList(list));

            //DeleteAllOddNumbersList(list);

            //PrintList(list);

            //List<int> list1 = CreateRandomList(20, 0, 100);
            //List<int> list2 = CreateRandomList(20, 0, 100);

            //list1.Sort();
            //list2.Sort();

            //PrintList(MergeOrderedLists(list1, list2));


            List<char> list = new() { 'a', 'b', 'c'};

            foreach (char c in list)
            {
                Console.Write("{0} ", c);
            }
            Console.WriteLine();

            heapPermutationList(list.Count, list);
        }
    }
}
