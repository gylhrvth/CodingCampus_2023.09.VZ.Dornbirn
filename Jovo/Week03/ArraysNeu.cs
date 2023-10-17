
using System.Reflection.Metadata.Ecma335;

namespace Jovo.Week03
{
    internal class ArraysNeu
    {

        public static Random rand = new Random();

        public static void Start()
        {

            Console.WriteLine("Increase");
            int[] original = Array(10);
            foreach (int element in original)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine("=========================");



            Console.WriteLine("Decrease");
            int[] originalR = ArrayR(10);
            foreach (int element in originalR)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine("=========================");



            Console.WriteLine("Copy");
            int[] copy = MakeACopy(original);
            foreach (int element in copy)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine("=========================");


            Console.WriteLine("OriginalVerändert");
            original[4] = 34;
            original[2] = 71;
            foreach (int element in original)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine();


            Console.WriteLine("RandomNumberArray");
            int[] arr = RandomNumberArray(10);
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine("=========================");


            Console.WriteLine("RandomNumberArray2");
            int[] randArr = RandomNumberArray2(10);
            Console.WriteLine("[{0}]", string.Join(", ", randArr));


            Console.WriteLine("RandomNumberArray jeden 2ten");
            for (int i = 0; i < randArr.Length; i += 2)
            {
                Console.Write(randArr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("=========================");
            Console.WriteLine(" 2: index = " + randArr[1]);
            Console.WriteLine(" 5: index = " + randArr[4]);
            Console.WriteLine("10: index = " + randArr[9]);
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine();


            Console.WriteLine("RandomNumberArrayCrazyRange");
            int[] CrazyArr = RandomNumberArrayCrazyRange(10, -50, 50);
            foreach (int element in CrazyArr)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine("=========================");


            Console.WriteLine("RandomNumberArrayZählen");
            int Count30 = RandomNumberArrayZählen(CrazyArr);
            Console.WriteLine("[{0}]", string.Join(", ", CrazyArr));


            Console.WriteLine("Zahlen über 30: " + Count30);
            Console.WriteLine("=========================");


            Console.WriteLine("RandomNumberArraySumme");
            int Summe = RandomNumberArraySumme(randArr);
            Console.WriteLine("[{0}]", string.Join(", ", randArr));
            Console.WriteLine("Summe = " + Summe);
            Console.WriteLine("=========================");


            Console.WriteLine("RandomNumberArrayMinMaxAvg");

            randArr = new int[] { 2, 3 };

            int Min = ArrayMin(randArr);
            int Max = ArrayMax(randArr);
            double Avg = ArrayAvg(randArr);
            Console.WriteLine("[{0}]", string.Join(", ", randArr));
            Console.WriteLine("Min = {0} Max = {1} Avg = {2}", Min, Max, Avg);
            Console.WriteLine("=========================");


            Console.WriteLine("BubbleSortAscending");
            Console.WriteLine();
            //int[] newArr = RandomNumberArrayCrazyRange(100, 0, 100); so neue array angeben
            int[] array = SortArrayAscending(arr); //warum kann ich keine Zahl eingeben
            Console.WriteLine("=========================");


            Console.WriteLine("BubbleSortDescending");
            Console.WriteLine();
            int[] array2 = SortArraysDescending(arr);
            Console.WriteLine("======================");

            int[] randArrNew = RandomNumberArray(10);

        
        }


        public static int[] Array(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            return arr;
        }


        public static int[] ArrayR(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = size - i;
            }
            return arr;
        }


        public static int[] MakeACopy(int[] original)
        {
            int[] copy = new int[original.Length];
            for (int i = 0; i < original.Length; i++)
            {
                copy[i] = original[i];
            }
            return copy;
        }


        public static int[] RandomNumberArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100);
            }
            return arr;
        }


        public static int[] RandomNumberArray2(int size)
        {
            int[] arr2 = new int[size];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rand.Next(100);
            }
            return arr2;
        }


        public static int[] RandomNumberArrayCrazyRange(int size, int num1, int num2)
        {
            int[] crazyArr = new int[size];
            for (int i = 0; i < crazyArr.Length; i++)
            {
                crazyArr[i] = rand.Next(num1, num2);
            }
            return crazyArr;
        }


        public static int RandomNumberArrayZählen(int[] arr)
        {
            int Count30 = 0;
            foreach (int element in arr)
            {
                if (element > 30)
                {
                    Count30++;
                }
            }
            return Count30;
        }


        public static int RandomNumberArraySumme(int[] arr)
        {
            int Summe = 0;
            foreach (int element in arr)
            {
                Summe += element;
            }
            return Summe;
        }


        public static double ArrayAvg(int[] arr)
        {
            double Avg = 0;
            double Summe = 0;
            foreach (double element in arr)
            {
                Summe += element;
            }
            Avg = Summe / arr.Length;
            return Avg;
        }


        public static int ArrayMax(int[] arr)
        {
            int Max = Int32.MinValue;
            foreach (int element in arr)
            {
                if (element > Max)
                {
                    Max = element;
                }
            }
            return Max;
        }


        public static int ArrayMin(int[] arr)
        {
            int Min = Int32.MaxValue;
            foreach (int element in arr)
            {
                if (element < Min)
                {
                    Min = element;
                }
            }
            return Min;
        }





        public static int[] SortArrayAscending(int[] array)
        {
            int length = array.Length;

            int temp = array[0];

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];

                        array[j + 1] = array[j];

                        array[j] = temp;
                    }
                    //jeder Schritt wird ausgegeben
                    Console.WriteLine(String.Join(", ", array));
                }
            }

            return array;

        }



        public static int[] SortArraysDescending(int[] array2)
        {
            int length = array2.Length;

            int temp = array2[0];

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    if (array2[j + 1] > array2[j])
                    {
                        temp = array2[j + 1];

                        array2[j + 1] = array2[j];

                        array2[j] = temp;
                    }
                    //jeder Schritt wird ausgegeben
                    Console.WriteLine(String.Join(", ", array2));
                }
            }
            return array2;


        }







    }
}
