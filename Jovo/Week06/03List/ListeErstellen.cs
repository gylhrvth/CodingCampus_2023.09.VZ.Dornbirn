using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Markup;
using static Jovo.Week06._03List.ListeAuswerten;
using static Jovo.Week06._03List.ListeZusammenführen;

namespace Jovo.Week06._03List
{
    public class ListeErstellen
    {

       
        public static void Main()
        {

            List<int> list = CreateRandomList(20, 0, 101);
            Console.WriteLine("Print My Random Number List:");
            //print your list with random numbers
            PrintList(list);

            //Count all even numbers
            Console.WriteLine("\nCount even Numbers:" + CountEvenNumbersList(list));

            //Find the smallest number
            Console.WriteLine("\nSmallest Numbers:" + FindSmallestNumber(list));

            //Find the biggest number
            Console.WriteLine("\nBiggest Number:" + FindMaxValueList(list));

            //Sort your numbers ( with a bubbglesort.ALG)
            Console.WriteLine("Sort My Numbers:");
            BubbleSortList(list);
            PrintList(list);

            //Delet all odd numbers
            Console.WriteLine("All Odd Numbers deleted:");
            DeleteAllOddNumbersList(list);

            PrintList(list);



            List<int> list1 = CreateRandomList(20, 0, 101); //dont take list else list1 and list 2 are the same numbers!
            List<int> list2 = CreateRandomList(10, 0, 101);

            list1.Sort(); //sortiert beide listen
            list2.Sort();
            PrintList(list1);
            PrintList(list2);   

            Console.WriteLine("Result from both lists:");
            PrintList(MergeBothLists(list1, list2));

        }

      

    }

}

