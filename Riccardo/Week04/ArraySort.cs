using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Riccardo.Week03.ArraysUebung;

namespace Riccardo.Week04
{
    public class ArraySort
    {
        public static void Start()
        {
            int[] arr = RandomZufall(10);

            BublesortAscending(arr);

        }


        public static void BublesortAscending(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int swap = 0;
                        arr[j] = arr[j + 1];

                    }

                }
            }

        }
    }
}
