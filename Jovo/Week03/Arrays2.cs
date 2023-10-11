
using System.Reflection.Metadata.Ecma335;

namespace Jovo.Week93
{
    internal class Arrays2 { 


        public static Random rand = new Random();


        
        public static void Start()
        {
            /*
            Console.WriteLine("Aufgabe Number Increase");
            int[] arr = NumberArrayIncrease(10);
            foreach (int element in arr)
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("===================");

            


            Console.WriteLine("Aufgabe Number Decrease");
            int[] arr2 = NumberArrayDecrease(10);
            foreach (int element in arr2)
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("=================");

            Console.WriteLine("Aufgabe MakeACopy");
            int[] arr3 = MakeACopy(arr);
            foreach (int element in arr3)
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("===============");


            Console.WriteLine("Änderungen");
            arr[3] = 31;
            foreach (int element in arr)
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("===============");




            Console.WriteLine("Copy nach Änderungen");
            foreach (int element in arr2)
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("===============");





            Console.WriteLine("Random Number Array");
            RandomNumberArray(100);
            
            Console.WriteLine();
            Console.WriteLine("===============");
            */

            Console.WriteLine("Random Number Array");
            int[] arr = RandomNumberArray(2);

            Console.WriteLine("[{0}]", string.Join(", ", arr));
            PrintArrayWithFori(arr);
            PrintArrayWithForeach(arr);


            PrintSecondFifthTenth(arr);

        }





       

        public static int[] NumberArrayIncrease(int size)
        {
            int[] num1 = new int[size];
            

            for (int i = 0; i < num1.Length; i++)
            {
                num1[i] = i;
                
            }
           

            return num1;
        }


        public static int[] NumberArrayDecrease(int size)
        {
            int[] num2= new int[10];

            for (int j = 0; j < num2.Length; j++)
            {

                num2[j] = j;

            }
            return num2;


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
            int[] arraynew = new int[size];
            for (int i = 0; i < arraynew.Length; ++i)
            {
                arraynew[i] = rand.Next(101);
            }
            return arraynew;
        }




        public static void PrintSecondFifthTenth(int[] arr)
        {
            PrintXth(arr, 1);
            PrintXth(arr, 4);
            PrintXth(arr, 9);
        }

        public static void PrintXth(int[] arr, int pos)
        {
            if (pos >= 0 && arr.Length > pos)
            {
                Console.WriteLine(arr[pos]);
            }
            else
            {
                Console.WriteLine("N/A");
            }


        }



        public static void PrintArrayWithForeach(int[] arr)
        {
            bool firstValue = true;
            Console.Write("[");
            foreach (int value in arr)
            {
                if (!firstValue)
                {
                    Console.Write(", ");
                }
                Console.Write(value);
                firstValue = false;
            }
            Console.WriteLine("]");
        }

        public static void PrintArrayWithFori(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
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
