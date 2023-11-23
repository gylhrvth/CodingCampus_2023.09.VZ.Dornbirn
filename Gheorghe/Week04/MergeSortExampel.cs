using static Gheorghe.Week03.Arrays03;

namespace Gheorghe.Week04
{
    internal class MergeSortExampel
    {
        public static void Start()
        {
            int[] arr = CrazyRangeArray(10);
            PrintCrazyRangeArry(arr);



            int[] result = MergeSort(arr, 0, arr.Length, "");
            Console.WriteLine("Sorted:");
            PrintCrazyRangeArry(result);


        }
        public static int[] MergeSort(int[] arr, int start, int end, string prefix)
        {
            int[] result = new int[end - start];
            if (end - start == 1)
            {
                result[0] = arr[start];
                return result;
            }

            int[] mergeLeft = MergeSort(arr, start, start + (end - start) / 2, prefix + " ");
            int[] mergeRight = MergeSort(arr, start + (end - start) / 2, end, prefix + " ");

            int iLeft = 0;
            int iRight = 0;
            int iResult = 0;

            while (iLeft < mergeLeft.Length && iRight < mergeRight.Length)
            {
                if (mergeLeft[iLeft] < mergeRight[iRight])
                {
                    result[iLeft] = mergeLeft[iLeft];
                    ++iResult;
                    ++iLeft;
                }
                else
                {
                    result[iResult] = mergeRight[iRight];
                    ++iResult;
                    ++iRight;
                }
            }
            while (iLeft < mergeLeft.Length)
            {
                result[iResult] = mergeLeft[iLeft];
                ++iResult;
                ++iLeft;
            }
            while (iRight < mergeRight.Length)
            {
                int Result = 0;
                result[Result] = mergeRight[iRight];
                ++iResult;
                ++iRight;

            }
            return result;

        }


        public static int[] CopyPartOfArray(int[] arr, int start, int end)
        {
            int[] result = new int[end - start];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = arr[start + i];
            }
            return result;
        }


        public static int[] MergeSortWithCopy(int[] arr, string prefix)
        {
            Console.WriteLine("{1} MergeSortWithCopy(..., {0})", string.Join(",", arr), prefix);
            if (arr.Length == 1)
            {
                return CopyPartOfArray(arr, 0, arr.Length);
            }
            int[] result = new int[arr.Length];
            int[] mergeLeft = MergeSortWithCopy(CopyPartOfArray(arr, 0, arr.Length / 2), prefix + "    ");
            int[] mergeRight = MergeSortWithCopy(CopyPartOfArray(arr, arr.Length / 2, arr.Length), prefix + "    ");

            int iLeft = 0;
            int iRight = 0;
            int iResult = 0;



            while (iLeft < mergeLeft.Length && iRight < mergeRight.Length)
            {
                if (mergeLeft[iLeft] < mergeRight[iRight])
                {
                    result[iResult] = mergeLeft[iLeft];
                    ++iResult;
                    ++iLeft;
                }
                else
                {
                    result[iResult] = mergeRight[iRight];
                    ++iResult;
                    ++iRight;
                }
            }
            while (iLeft < mergeLeft.Length)
            {
                result[iResult] = mergeLeft[iLeft];
                ++iResult;
                ++iLeft;
            }
            while (iRight < mergeRight.Length)
            {
                result[iResult] = mergeRight[iRight];
                ++iResult;
                ++iRight;
            }

            Console.WriteLine("{1}Teilergebnis: {0}", string.Join(", ", result), prefix);
            return result;

        }
    }
}
