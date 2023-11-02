using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kerem.Week06.CreateAndSortyMyList;

namespace Kerem.Week06;

public class ListExample
{
    public static void Start()
    {
       
        List<int> list = CreateRandomList(20);
        Console.WriteLine("Print My Random Number List:");
        PrintList(list);

        Console.Write("Count Even Numbers:" + CountEvenNumbers(list));

        Console.Write("\nSmallest Numbers:" + SearchSmallestNumber(list));
     
        Console.WriteLine("\nBiggest Number:" + SearchBiggestNumber(list));
        
        Console.WriteLine("Sort My Numbers:");
        PrintList(SortListDesc(list));

        Console.WriteLine("Odd Numbers deleted:");
        RemoveOddNumber(list);

        PrintList(list);
    }
}
