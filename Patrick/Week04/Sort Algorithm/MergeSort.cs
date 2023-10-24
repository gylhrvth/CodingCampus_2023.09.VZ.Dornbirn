using System;
using static Patrick.Week03.ExamplesArrays;

namespace Patrick.Week04
{
    internal class MergeSort
    {
        public static void Start()
        {

            int[] array = RandomNumberArray(0, 100, 20);
            Console.WriteLine("Unsorted Array:");
            PrintArrayFor(array);

            Console.WriteLine();

            int[] result = Mergesort(array, 0, array.Length, "");
            Console.WriteLine("Sorterd Array");
            PrintArrayFor(result);

        }

        public static int[] Mergesort(int[] array, int start, int end, string prefix)
        {
            int[] result = new int[end - start];

            if (end - start == 1)
            {
                result[0] = array[start];
                return result;
            }

            int[] mergeLeft = Mergesort(array, start, start + (end - start) / 2, prefix + "    ");
            int[] mergeRight = Mergesort(array, start + (end - start) / 2, end, prefix + "    ");

            int iLeft = 0;
            int iRight = 0;
            int iResult = 0;

            while (iLeft < mergeLeft.Length && iRight < mergeRight.Length)
            {
                if (mergeLeft[iLeft] < mergeRight[iRight])
                {
                    result[iResult] = mergeLeft[iLeft];
                    iLeft++;
                    iResult++;
                }
                else
                {
                    result[iResult] = mergeRight[iRight];
                    iRight++;
                    iResult++;
                }
                
            }
            while (iLeft < mergeLeft.Length)
            {
                result[iResult] = mergeLeft[iLeft];
                iLeft++;
                iResult++;
            }

            while (iRight < mergeRight.Length)
            {
                result[iResult] = mergeRight[iRight];
                iRight++;
                iResult++;
            }

            return result;
        }

    }
}
