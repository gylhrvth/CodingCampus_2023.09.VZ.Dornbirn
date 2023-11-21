using System.Drawing;

namespace Selina.Week06.Test
{
    public class Array1
    {
        public static void Start()
        {
            int[] arr = new int[] { 0, 1, 23, 5, 12, 4, 4, 2, 5, 2, 10 };
            int[] arr2 = new int[] { 123, 19471, 1, 4, 15715, 15, 1, 5, 15, 1, -10, -100 };
            int[] arr3 = new int[] { 478199, 7812973, 12387123, 12, 3, 123, 12, 3, 1, 3, 1, 3, 1, 8, 9, 15, 1, 5, 1, 5, 1, 5, 15, 1, 5, 0 };

            Output("1", ConsoleColor.Magenta);
            PrintFirstAndLast(arr, arr2, arr3);

            Output("2", ConsoleColor.Magenta);
            int min1 = Min(arr);
            int min2 = Min(arr2);
            int min3 = Min(arr3);
            Console.WriteLine($"Min arr = {min1} \nMin arr2 = {min2} \nMin arr3 = {min3}");
            int max1 = Max(arr);
            int max2 = Max(arr2);
            int max3 = Max(arr3);
            Console.WriteLine($"\nMax arr = {max1} \nMax arr2 = {max2}\nMax arr3 = {max3}");
            double avg1 = Avg(arr);
            double avg2 = Avg(arr2);
            double avg3 = Avg(arr3);
            Console.WriteLine($"\nAvg arr = {avg1:f2} \nAvg arr2 = {avg2:f2} \nAvg arr3 = {avg3:f2}");

            Output("3", ConsoleColor.Magenta);
            int size = ReadNumber("Wie lange sollte dein Array sein? ", "Sie müssen eine Zahl eingeben! ");
            int [] newAray = FillArray(size);
            PrintArray(newAray);

            Output("4", ConsoleColor.Magenta);
            int [] randomArray = CreateRandomArray(0, 100, 5);
            Ascending(randomArray);
            Descending(randomArray);
            PrintArray(randomArray);



        }

        //Noch nicht fertig!!!!
        public static void PrintFirstAndLast(int[] arr, int[] arr2, int[] arr3)
        {

            Console.WriteLine($"{arr[0]} ");
            Console.WriteLine($"{arr2[0]} {arr2.Length}");
            Console.WriteLine($"{arr3[0]} {arr3.Length}");
        }
        public static int Min(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        public static int Max(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        public static int Summe(int[] randomArraySum)
        {
            int sum = 0;
            for (int i = 0; i < randomArraySum.Length; i++)
            {
                sum += randomArraySum[i];
            }
            return sum;
        }
        public static double Avg(int[] arr)
        {
            int sum = Summe(arr);
            double avg = (double)sum / arr.Length;
            return avg;
        }
        public static int[] FillArray(int size)
        {
            int[] newArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = i + 1;
            }
            return newArray;
        }
        public static int ReadNumber(string prompt, string onError)
        {
            Console.Write(prompt);
            while (true)
            {
                try
                {
                    int ourNumber = Convert.ToInt32(Console.ReadLine());
                    return ourNumber;
                }
                catch (Exception exc)
                {
                    Console.Error.WriteLine(onError);
                }
            }
        }
        public static int[] CreateRandomArray(int from, int to, int size)
        {
            Random rand = new Random();
            int[] randomArray = new int[size];
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rand.Next(from, to);
            }
            return randomArray;
        }
        public static void Ascending(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        public static void Descending(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        public static void PrintArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(" " + i);
            }
        }
        public static string Output(string output, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"\n\nAufgabe: {output}");
            Console.ResetColor();

            return output;
        }


    }
}
