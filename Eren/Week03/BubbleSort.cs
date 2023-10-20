using System;
namespace Eren.Week03
{


	public class Sort
	{
        public static Random rand = new Random();
        
        public static void StartBubbleSort()
        {

            int[] array = { 9, 1, 8, 2, 7, 3, 6, 4, 5 };

            BubbleSort(array);

            Console.WriteLine("[{0}]", string.Join(", ", array ));
            


        }

        public static void BubbleSort(int[] array)
        {
            int temporär;

            for(int i = 0; i < array.Length - 1; i++ )
            {
                for(int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        temporär = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temporär;
                    }
                }
            }
        }

        public static void BubbleSortDes(int[] array)
        {
            int temporär;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        temporär = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temporär;
                    }
                }
            }
        }




    }
}

