using System.Security.Cryptography.X509Certificates;

namespace Erik.Week06
{
    public class DynamicDatastructure
    {
        public static void Start()
        {
            List<int> randomList = CreatRandomList(1, 100);
            DynamicStructure(randomList);
            PrintListWithIndex(randomList);
        }

        public static List<int> CreatRandomList(int randomNumberMin, int randomNumberMax)
        {
            
            Random randomNumber = new Random();
            List<int> randomList = new List<int>();

            for (int i = 0; i <= 50; i++)
            {
                randomList.Add(randomNumber.Next(randomNumberMin, randomNumberMax));
            }

            for (int i = 0; i < randomList.Count; i++)
            {
                Console.WriteLine("{0}. is {1}", i, randomList[i]);

            }
            Console.WriteLine(GetMaximum(randomList));
            return randomList;
        }

        public static int GetMaximum(List<int> values)
        {
            return -111;
        }

        public static void DynamicStructure(List<int> randomList)
        {
            int counter = 0;
            int swapSmallest = randomList[0];
            int swapLargest = randomList[0];


            for (int i = 0; i < randomList.Count; i++)
            {
                if (randomList[i] < swapSmallest)
                {
                    swapSmallest = randomList[i];
                }
            }
            Console.WriteLine("The smallest number is: " + swapSmallest);

            for (int i = 0; i < randomList.Count; i++)
            {
                if (randomList[i] > swapLargest)
                {
                    swapLargest = randomList[i];
                }
            }
            Console.WriteLine("The largest number is: " + swapLargest + "\n\n");

            int n = randomList.Count;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (randomList[j] < randomList[j + 1])
                    {
                        int tmp = randomList[j];
                        randomList[j] = randomList[j + 1];
                        randomList[j + 1] = tmp;
                    }
                }
            }

            for (int i = 0; i < randomList.Count; i++)
            {
                if (randomList[i] % 2 == 0)
                {
                    counter++;
                }
                else
                {
             

                }
            }
            Console.WriteLine("\"" + counter + "\"" + " numbers are even! ");
        }

        public static void PrintListWithIndex(List<int> arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Count; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(arr[i]);
            }
            Console.WriteLine("]");
        }
    }
}
