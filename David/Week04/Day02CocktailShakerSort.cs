using static David.Week03.Week03Day03RandomArrays;
namespace David.Week04
{
	internal class Day02CocktailShakerSort
	{
		public static void Start()
		{

			int[] arrayRandom = crazyR(10);
			PrintArray(arrayRandom);
            Console.WriteLine();
            Console.WriteLine("------");
            PrintArray(CocktailShakerSort(arrayRandom));

		}

        public static int[] CocktailShakerSort(int[] arrayRandom)
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

        public static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}


