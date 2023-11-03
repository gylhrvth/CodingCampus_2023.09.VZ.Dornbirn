using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Jovo.Week06._03List
{
    public class ListeAuswerten
    {
        private static Random random = new Random();

       
        // print/fill your list
        public static void PrintList(List<int> list)
        {
            bool first = true;
            Console.Write("[ ");
            foreach (int element in list)
            {
                if (first)
                {
                    Console.Write(element);
                    first = false;
                }
                Console.Write(", " + element);
              

            }
            Console.Write(" ]");
            Console.WriteLine();
        }

        //Create a Random list that can grow or shrink 
        public static List<int> CreateRandomList(int count, int min, int max)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < count; i++)
            {
                list.Add(random.Next(min, max));
            }


            return list;

        }

        //% = 0 for even numbers cause there is no residual value
        public static int CountEvenNumbersList(List<int> list)
        {
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    count++;
                }

            }
            return count;
        }
        
        //get your smallest number (compare all numbers and the smallest number will be your result)
        //use list.count (count is for getting the numbers from the list)
        //with int i you say take the number at the first spot (takes the random number from the list!!!)
        //list[i] ( i = the number at the spot i(counts up with i++))
        public static int FindSmallestNumber(List<int> list)
        {
            int result = int.MaxValue;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < result)
                {
                    result = list[i];
                }
            }

            return result;
        }


        //get your biggest number(compare all numbers and the smallest number will be your result)
        //use list.count (count is for getting the numbers from the list)
        // with int i you say take the number at the first spot (takes the random number from the list!!!!)
        //list[i] ( i = the number at the spot i(counts up with i++))
        public static int FindMaxValueList(List<int> list)
        {
            int result = int.MinValue;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > result)
                {
                    result = list[i];
                }
            }

            return result;
        }

        //simple bubblesort to sort everything 
        //depends which way you wanna sort just change what has to be bigger/smaller
        public static List<int> BubbleSortList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
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



        //delet your odd numbers (just get all numbers without a residual value and then use remove)
        public static void DeleteAllOddNumbersList(List<int> list)
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
}
