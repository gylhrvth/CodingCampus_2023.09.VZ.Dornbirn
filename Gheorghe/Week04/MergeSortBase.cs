namespace Gheorghe.Week04
{
    public class MergeSortBase
    {

        public static int[] MergeSort(int[] arr, int start, int end, string prefix)
        {
            //Console.WriteLine("{2}MergeSort(..., {0}, {1})", start, end, prefix);
            int[] result = new int[end - start];
            if (end - start == 1)
            {
                result[0] = arr[start];
                return result;
            }


            int[] mergeLeft = MergeSort(arr, start, start + (end - start) / 2, prefix + "    ");
            int[] mergeRight = MergeSort(arr, start + (end - start) / 2, end, prefix + "    ");

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
            return result;
        }
    }
}