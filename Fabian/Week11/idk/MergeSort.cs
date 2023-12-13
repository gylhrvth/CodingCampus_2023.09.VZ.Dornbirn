namespace Fabian.Week11.idk
{
    internal class MergeSort
    {
        public static void Start()
        {
            int[] array = { 6, 5, 2, 8, 9, 3, 1, 4, 7, 10 };
            MergeSortStart(array);

            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        public static void MergeSortStart(int[] array)
        {
            if (array.Length <= 1) return;

            int[] leftArray = new int[array.Length / 2];
            int[] rightArray = new int[array.Length - array.Length / 2];

            int i = 0;
            int j = 0;

            for (; i < array.Length; i++)
            {
                if (i < leftArray.Length)
                {
                    leftArray[i] = array[i];
                }
                else
                {
                    rightArray[j] = array[i];
                    j++;
                }
            }


            MergeSortStart(leftArray);
            MergeSortStart(rightArray);
            Merge(leftArray, rightArray, array);

        }

        public static void Merge(int[] leftArray, int[] rightArray, int[] array)
        {
            int leftSize = array.Length / 2;
            int rightSize = array.Length - leftSize;

            int i = 0, r = 0, l = 0;

            while (l < leftSize && r < rightSize)
            {
                if (leftArray[l] < rightArray[r])
                {
                    array[i] = leftArray[l];
                    i++;
                    l++;
                }
                else
                {
                    array[i] = rightArray[r];
                    i++;
                    r++;
                }
            }
            while (l < leftSize)
            {
                array[i] = leftArray[l];
                i++;
                l++;
            }
            while (r < rightSize)
            {
                array[i] = rightArray[r];
                i++;
                r++;
            }


        }
    }
}
