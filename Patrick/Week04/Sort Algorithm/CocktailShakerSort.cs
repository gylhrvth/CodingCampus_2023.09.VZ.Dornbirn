using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Patrick.Week04.InsertionSort;

namespace Patrick.Week04.Sort_Algorithm
{
    internal class CocktailShakerSort
    {

        public static void Start()
        {
            int[] arrayRandom = CreateRandomArray(10);
            PrintArray(arrayRandom);
            Console.WriteLine();
            Console.WriteLine("===================================");
            PrintArray(CocktailShakerSoort(arrayRandom));

        }

        public static int[] CocktailShakerSoort(int[] arrayRandom)
        {
            int low = 1;
            int move = low;
            int high = arrayRandom.Length - 1;

            while (low < high)
            {
                for (int i = high; i > low + 1; i--)
                {
                    if (arrayRandom[i - 1] > arrayRandom[i])
                    {
                        int tempMemoryUp = arrayRandom[i - 1];
                        arrayRandom[i - 1] = arrayRandom[i];
                        arrayRandom[i] = tempMemoryUp;
                        move = i;
                    }
                    low = move;
                }
                
                for (int j = 1; j < high; j++)
                {
                    if (arrayRandom[j] > arrayRandom[j + 1])
                    {
                        int tempMemoryDown = arrayRandom[j + 1];
                        arrayRandom[j + 1] = arrayRandom[j];
                        arrayRandom[j] = tempMemoryDown;
                    }
                }
                move = high;
            }
            return arrayRandom;

        }
    }
}
