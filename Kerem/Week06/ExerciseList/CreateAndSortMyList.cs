using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week06;

public class CreateAndSortyMyList
{
    private static Random rand = new Random();
  
    public static List<int> CreateRandomList(int length)
    {
        List<int> list = new List<int>();

        for( int i = 0; i < length; i++ )
        {
            list.Add(rand.Next(0, 100));
            
        }
        return list;


    }
    public static void PrintList(List<int> list)
    {
        bool first = true;
        Console.Write("[");
        foreach (int element in list)
        {
          
            if (first)
            {

                Console.Write(element);
                first = false;
            }
            Console.Write(", " + element);


        }
        Console.Write("]");
        Console.WriteLine();
    }
    public static int SearchSmallestNumber(List<int> list)
    {
        int MinNumber = Int32.MaxValue;
        foreach(int element in list)

        if (element < MinNumber)
        {
            MinNumber = element;
        }
        return MinNumber;

    }
  
    public static int SearchBiggestNumber(List<int> list)
    {
        int MaxNumber = Int32.MinValue;
        foreach(int element in list)

        if (element > MaxNumber)
        {
            MaxNumber = element;
        }

        return MaxNumber;
    }
    public static int CountEvenNumbers(List<int> list)
    {
        int counter = 0;
        for(int i = 0; i < list.Count; i++)
        if(list[i]  % 2 == 0)
        {
          counter++;
        }

        return counter;
    }
    public static List<int> SortListDesc(List<int> list)
    {
        //List<int> desc = new List<int>();

        for(int i = 0; i< list.Count;i++ )
        {
            for (int j = i + 1; j < list.Count; j++)
            {
                if (list[i] < list[j])
                {
                    int temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }
        }
        return list;
    }
    public static void RemoveOddNumber(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] % 2 != 0)
            {
                list.RemoveAt(i);
                i--;
            }
        }
    }
}
