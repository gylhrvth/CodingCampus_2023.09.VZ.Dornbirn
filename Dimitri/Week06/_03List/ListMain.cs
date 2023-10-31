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
            List<int> list = CreateRandomList(20, 0, 100);
            PrintList(list);
            Console.WriteLine();
            Console.WriteLine(CountEvenNumbersList(list));
            Console.WriteLine();
            Console.WriteLine(FindSmallestNumber(list));
            Console.WriteLine();
            Console.WriteLine(FindMaxValueList(list));
            Console.WriteLine();

            //easy
            /*
            list.Sort();
            PrintList(list);
            list.Reverse();
            PrintList(list);
            */

            PrintList(BubbleSortList(list));

            DeleteAllOddNumbersList(list);

            PrintList(list);
        }
    }
}
