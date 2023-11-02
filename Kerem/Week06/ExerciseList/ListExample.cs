using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kerem.Week06.CreateAndSortyMyList;
using static Kerem.Week06.ExerciseList.MergeList;

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
        Console.WriteLine("MergeSortList");
        List<int> list1 = CreateRandomList(20);
        List<int> list2 = CreateRandomList(20);
        SortListDesc(list1);
        SortListDesc(list2);

        PrintList(list1);
        Console.WriteLine("================================================================================");
        PrintList(list2);
        Console.WriteLine("================================================================================");
        PrintList(MergeSort(list1, list2));
    }
}
