using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Markup;
using static Jovo.Week06._03List.ListeAuswerten;

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
            PrintList(BubbleSortList(list));

            //Delet all odd numbers
            Console.WriteLine("All Odd Numbers deleted:");
            DeleteAllOddNumbersList(list);

            PrintList(list);


            


        }

      

    }

}

