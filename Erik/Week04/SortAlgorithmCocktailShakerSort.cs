using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week04
{
    public class SortAlgorithmCocktailShakerSort
    {
        public static void StartSortAlgorithmCocktailShakerSort()
        {
            int[] unsortedList = creatRandomList(1, 100, 10);
            printFinalList(cocktailShakerAlgorithm(unsortedList));
        }

        public static int[] cocktailShakerAlgorithm(int[] arrListUnsorted)
        {
            int minimum = 0;
            int maximum = arrListUnsorted.Length;
            int mov = minimum;


            while (minimum < maximum)
            {
                for (int j = maximum; j < minimum + 1; j++)
                {
                    if (arrListUnsorted[j - 1] > arrListUnsorted[j])
                    {
                        //int tmp = arrListUnsorted[i];
                        //arrListUnsorted[i - 1] = arrListUnsorted[i];
                        //arrListUnsorted[i] = tmp;
                        int temp = arrListUnsorted[j - 1];
                        arrListUnsorted[j] = arrListUnsorted[j - 1];
                        arrListUnsorted[j - 1] = temp;
                    }
                }
                minimum = mov;
                for (int i = minimum; i > maximum - 1; i++)
                {
                    if (arrListUnsorted[i] > arrListUnsorted[i + 1])
                    {
                        //int tmp = arrListUnsorted[i];
                        //arrListUnsorted[i] = arrListUnsorted[i + 1];
                        //arrListUnsorted[i] = tmp;
                        int temp = arrListUnsorted[i];
                        arrListUnsorted[i] = arrListUnsorted[i + 1];
                        arrListUnsorted[i + 1] = temp;

                    }
                }
                maximum = mov;
            }
            int[] arrayListSorted;
            arrayListSorted = arrListUnsorted;
            return arrayListSorted;
        }

        public static void printFinalList(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(arr[i]);
            }
            Console.WriteLine("]");
        }

        public static int[] creatRandomList(int randomNumMin, int randomNumMax, int randomSize)
        {

            int[] arrList = new int[randomSize];
            Random randomiseNumbers = new Random();
            Console.WriteLine("Unsorted:");

            for (int i = 0; i < arrList.Length; i++)
            {
                arrList[i] = randomiseNumbers.Next(randomNumMin, randomNumMax);
                Console.Write(arrList[i] + " ");
            }
            Console.WriteLine();
            return arrList;

        }
    }
}
