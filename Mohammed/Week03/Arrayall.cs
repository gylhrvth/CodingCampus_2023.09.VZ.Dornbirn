using System.Runtime.Intrinsics.X86;

namespace Mohammed.Week03
{
    public class Arrayall
    {

        // this belongs to a random exercise.
        public static Random rand = new Random();

        public static void startArrayall()
        {


            //ab hier gehört erste und zweite aufgabe..// Mehtoden aufrufen printArray
            Console.WriteLine("orginal");
            int[] orginal = Array(10);
            //PrintMyArray(orginal);
            //Console.WriteLine("[{0}]", string.Join(", ", orginal));


            /*foreach (int element in orginal)
            {
                Console.Write(element + ", ");
            }*/


            Console.WriteLine();
            Console.WriteLine("---------------");

            Console.WriteLine("Copy");
            int[] copy = MakeAcopy(orginal);
            foreach (int element in copy)
            {
                Console.Write(element + ", ");
            }

            Console.WriteLine("");

            Console.WriteLine("---------------");
            Console.WriteLine(" change orginal");
            orginal[3] = 200;
            foreach (int element in orginal)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            Console.WriteLine("----------------");
            Console.WriteLine("change copy");
            foreach (int element in copy)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();



            int[] array = Array(31);
            int[] array1 = Array(49);
            int[] array2 = Array(3);
            int[] array3 = Array(51);
            int[] array4 = Array(41);



            foreach (int element in copy)
            {
                Console.Write(element + " ");
            }



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("RandomNumber");
            int[] random = RandomNumber(10);
            foreach (int element in random)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Crazy Array");
            int[] randomNumber = RandomCrazy(100);
            Console.WriteLine("[{0, 7}]", string.Join(", ", randomNumber));
            Console.WriteLine("----------------");
            Console.WriteLine("[{0}]", string.Join(", ", randomNumber));
            Console.WriteLine("count 30");

            int count30 = RandomCount(randomNumber);

            Console.WriteLine("Es sind " + count30 + " zaheln über 30!");
            Console.WriteLine("-------------------------");

            int summeOfArray = Sum(randomNumber);
            Console.WriteLine("summe {0}", summeOfArray); //da muss ich noch schauen, dass ich nochmnal probiere,,



            Console.WriteLine("Avarge: {0}", Avarage(randomNumber));

            Console.WriteLine("Min : {0}", Min(randomNumber));

            Console.WriteLine("max {0}", Max(randomNumber));

            Console.WriteLine("===========================================");

            //Aufgabe (bubble)sort

           // Max(randomNumber);


            Console.WriteLine("Bubblesort");
            int[] bubbleArray = RandomNumber(10);
            PrintMyArray(random);
            PrintMyArray(bubbleArray);
            PrintMyArray(Bubblesort(bubbleArray));



        }






        //-------------------------------------


        //print an array

        public static void PrintMyArray(int[] inputArray)
        {
            
            foreach (int element in inputArray)
            {

                Console.Write(element + " ");


            }
        }
        //erste aufgabe

        public static int[] Array(int size)
        {
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            return arr;


        }

        // zweite aufgabe
        public static int[] MakeAcopy(int[] orginal)
        {
            int[] copy = new int[orginal.Length];

            for (int i = 0; i < orginal.Length; i++)
            {
                copy[i] = orginal[i];
            }
            return copy;



        }


        //dritte Aufgabe RandomNumber Array
        public static int[] RandomNumber(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100);
            }
            return arr;
        }


        //vierte Aufgabe RandomNumber Array Crazy
        public static int[] RandomCrazy(int size)
        {
            int[] arr2 = new int[size];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rand.Next(-50, 50);
            }
            return arr2;
        }


        //fünfte Aufgabe RandomNumber Array Zählen
        public static int RandomCount(int[] arr)
        {
            int count = 0;
            foreach (int element in arr)
            {
                if (element > 30)
                {
                    count++;
                }

            }
            return count;

        }


        public static int Sum(int[] array)
        {
            int Sum = 0;

            foreach (int value in array)
            {
                Sum += value;
            }
            return Sum;
        }

        // die aufgaben bis Max gehören zusammen
        public static double Avarage(int[] arr)
        {
            if (arr.Length == 0)
            {
                return 0;
            }
            return Sum(arr) / (double)arr.Length;

        }


        public static int Min(int[] arr)
        {
            int min = int.MaxValue;

            foreach (int value in arr)
            {
                if (value < min)
                {
                    min = value;
                }
            }

            return min;
        }

        public static int Max(int[] arr)
        {
            int max = int.MinValue;

            foreach (int value in arr)
            {
                if (value > max)
                {
                    max = value;
                }

            }

            return max;

        }
        //erldigt

        // -> Bubblesort mit Zahlen:




        public static int[] Bubblesort(int[] arr)
        {

            int temp;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                        //PrintMyArray(array);
                    }
                }
            }
            return arr;

        }
    }
}