using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week04
{
    public class Algorithms
    {
        public static void StartBubbleSort()
        {
            //PrintArray(BubbleSortAlgorithm(RandomNumbers(1, 10, 10)));



            //PrintArray(RANDOMNUMBERS);
            //PrintArray(SelectionSort(RANDOMNUMBERS));

            int[] array = RandomNumbers(1, 10, 10);

            PrintArray(array);

           PrintArray(InsertionSort(array));


        }

        public static int[] RandomNumbers(int min, int max, int size)
        {
            Random rand = new Random();

            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                int RandomNumber = rand.Next(min, max);

                array[i] = RandomNumber;

            }

            return array;

        }

        public static int[] BubbleSortAlgorithm(int[] randomNumbersArray)
        {
            foreach (int randomNumber in randomNumbersArray)
            {
                Console.Write(" " + randomNumber);
            }


            Console.WriteLine();


            for (int i = 0; i < randomNumbersArray.Length; i++)
            {
                for (int j = 0; j < randomNumbersArray.Length - 1; j++)
                {

                    if (randomNumbersArray[j] > randomNumbersArray[j + 1]) //das vorzeichen bestimmt wie es geordnet wird
                    {

                        int Savenumber = randomNumbersArray[j];

                        randomNumbersArray[j] = randomNumbersArray[j + 1];

                        randomNumbersArray[j + 1] = Savenumber;

                    }

                }

            }

            return randomNumbersArray;

        }

        public static int[] SelectionSort(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                int min = i;

                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] > array[min])
                    {
                        min = j;

                        int temp = array[i];

                        array[i] = array[min]; //error
                        array[min] = temp;
                    }
                }
            }

            return array;
        }

        public static int[] InsertionSort(int[] array)
        {
            for (int i = 2; i < array.Length; i++)
            {
                int j = i;

                while (j > 0 && array[j - 1] > array[j])
                {
                    int temp = array[j];

                    array[j] = array[j - 1];

                    array[j - 1] = temp;

                       
                    
                    
                    j = j - 1;
                }
            }

            return array;
         }

        public static void PrintArray(int[] array)
        {
            Console.Write("[");

            for (int i = 0; i < array.Length; i++)
            {
                if (i > 0)
                {
                    Console.Write(",");
                }

                Console.Write(array[i]);
            }

            Console.WriteLine("]");
        }
        


    }

    
}

