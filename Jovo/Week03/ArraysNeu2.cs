
using System.Runtime.CompilerServices;

namespace Jovo.Week03
{
    internal class ArraysNeu2
    {



        // Aufruf neue random zahl(kleines random ist nur der name)
        public static Random random = new Random();


        public static void Start()
        {
            
            Console.WriteLine("Increase");
            int[] arr = NumberArrayIncrease(10);
            //Ausgabe mit foreach
            foreach (int element in arr)
            {
                Console.Write(element + ", ");
            }
            //Ausgabe ohne foreach
            Console.WriteLine();
            Console.WriteLine("[{0}]", string.Join(", ", arr));
            Console.WriteLine("=====================================");




            Console.WriteLine("Decrease");
            int[] arr2 = NumberArrayDecrease(10);
            //Ausgabe mit foreach
            foreach(int element in arr2)
            {
                Console.Write(element + ", ");
            }
            //Ausgabe ohne foreach
            Console.WriteLine();
            Console.WriteLine("[{0}]", string.Join(", ", arr2));
            Console.WriteLine("=====================================");





            Console.WriteLine("MakeACopy");
            int[] arr3 = MakeACopy(arr);
            //Ausgabe mit foreach
            foreach (int element in arr3)
            {
                Console.Write(element + ", ");
            }
            //Ausgabe ohne foreach

            Console.WriteLine();
            Console.WriteLine("[{0}]", string.Join(", ", arr3));
            Console.WriteLine("=====================================");




            Console.WriteLine("RandomNumberArray");
            int[] arr4R = RandomNumberArray(100);
            //Ausgabe mit foreach
            foreach(int element in arr4R)
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine();
            //Ausgabe ohne foreach
            Console.WriteLine("Ausgabe2 RandomNumberArray");
            Console.WriteLine("[{0}]", string.Join(", ", arr4R));
            Console.WriteLine("===================================");



            Console.WriteLine("RandomNumberArrayCrazyRange");
            int[] arr5C = RandomNumberArrayCrazyRange(10,-50, 50);
            //Ausgabe mit foreach
            foreach (int element in arr5C)
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine();
            //Ausgabe ohne foreach
            Console.WriteLine("Asugabe2 RandomNumberArrayCrazyRange");
            Console.WriteLine("[{0}]", string.Join(", ", arr5C));
            Console.WriteLine("===================================");



            Console.WriteLine("RandomNumberArrayZählen");
            int[] arr6 = RandomNumberArrayZählen(1, 100);
            //Ausgabe mit foreach
            foreach (int element in arr6)
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine();
            //Ausgabe ohne foreach
            Console.WriteLine("Ausgabe2 RandomNumberArrayZählen");
            Console.WriteLine("[{0}]", string.Join(", ", arr6));
            Console.WriteLine("===============================");




            Console.WriteLine("RandomNumberArrayMinMaxAvg");
            int[] arr7 = new int[] { 10, 20, };

            int Min = ArrayMin(arr7);
            int Max = ArrayMax(arr7);
            double Avg = ArrayAvg(arr7);
            Console.WriteLine("[{0}]", string.Join(", ", arr7));
            Console.WriteLine("Min = {0} Max = {1} Avg = {2}", Min, Max, Avg);
            Console.WriteLine("==============================");

        }



        public static int[] NumberArrayIncrease(int size)
        {

            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {

                arr[i] = i + 1;
            }

            return arr;
        }

        public static int[] NumberArrayDecrease(int size)
        {
            int[] arr2 = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr2[i] = size - i;

            }
            return arr2;
        }




        public static int[] MakeACopy(int[] original)
        {
            int[] copy = new int[original.Length];

            for (int i = 0; i < copy.Length; i++)
            {
                copy[i] = original[i];
            }

            return copy;
        }




        public static int[] RandomNumberArray(int size)
        {
            int[] arr4R = new int[size];
            for(int i = 0; i < arr4R.Length; i++)
            {
                arr4R[i] = random.Next(size);
            }
            return arr4R;

        }




        public static int[] RandomNumberArrayCrazyRange(int size, int min, int max)
        {
            int[] arr5C = new int[max];
            for (int i = 0; i < arr5C.Length; i++)
            {
                arr5C[i] = random.Next(min, max);
            }

            return arr5C;


        }


        public static int[] RandomNumberArrayZählen(int min, int max)
        {
            int[] arr6 = new int[max];
            for (int i = 0; i < arr6.Length; i++)
            {
                arr6[i] = random.Next(min, max);

            }

            return arr6;
        }

        
        public static int ArrayMax(int[] arr7)
        {
            
            int Max = Int32.MinValue;
            foreach(int element in arr7)
            {
                if(element > Max) 
                {
                    Max = element;
                }

            }
            return Max;

        }

        public static int ArrayMin(int[] arr7)
        {
            
            int Min = Int32.MaxValue;
            foreach(int element in arr7)
            {
                if (element < Min)
                {
                    Min = element;
                }
            }
            return Min;
        }
        public static double ArrayAvg(int[] arr7)
        {
            
            double Avg = 0;
            double Summe = 0;
            foreach(double element in arr7)
            {
                Summe += element;
            }
            Avg = Summe / arr7.Length;
            return Avg;

        }
    }
}
