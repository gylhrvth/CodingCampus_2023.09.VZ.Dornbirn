using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Patrick.Week03.ExamplesArrays;                                             //Hiermit kann ich auf die Methoden im Element ExamplesArrays zugreifen

namespace Patrick.Week04
{
    internal class BubbleSort
    {
        
        public static void start()
        {
            int[] array = RandomNumberArray(0, 101, 10);
            //AUFGABE 1
            PrintArrayFor(BubbleSortAscOrDesc(array, false));                           // Erstelle einen Bubblesort aufsteigend, absteigend und dieser soll durch einen Bool änderbar sein.
            Console.WriteLine("===================================");
            Console.WriteLine("===================================");
            
        }

        public static int[] BubbleSortAscOrDesc(int[] array, bool ascOrDesc)
        {

            if (ascOrDesc == true)
            {
                for (int x = 0; x < array.Length; x++)
                {
                    for (int y = 0; y < array.Length - 1; y++)
                    {
                        if (array[y] > array[y + 1])
                        {
                            int temporaryMemoryAsc = array[y];
                            array[y] = array[y + 1];
                            array[y + 1] = temporaryMemoryAsc;
                        }
                    }
                }
                Console.WriteLine("Bubblesort: The bool is true, the Array is ascending:");
            }
            else
            {
                for (int x = 0; x < array.Length; x++)
                {
                    for (int y = 0; y < array.Length - (x + 1); y++)
                    {


                        if (array[y] < array[y + 1])
                        {
                            int temporaryMemoryDesc = array[y];
                            array[y] = array[y + 1];
                            array[y + 1] = temporaryMemoryDesc;
                        }
                    }
                }
                Console.WriteLine("Bubblesort: The bool is false, the Array is descending:");
            }
            return array;
        }


    }
}
