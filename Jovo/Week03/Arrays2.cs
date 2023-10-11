
using System.Reflection.Metadata.Ecma335;

namespace Jovo.Week93
{
    internal class Arrays2 { 


        public static Random Random = new Random();


        
        public static void Start()
        {
            
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
            Console.WriteLine("[{0}]", string.Join(" ~~~ ", arr2));

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


             Console.WriteLine("Random Number Array");
             int[] arr4 = RandomNumberArray(2);

             Console.WriteLine("[{0}]", string.Join(", ", arr4));
             PrintArrayWithFori(arr4);
             PrintArrayWithForeach(arr4);


             PrintSecondFifthTenth(arr4);



           


            Console.WriteLine("Example3 Random:");
            int[] arr5 = RandomArray(10);
            Console.WriteLine("[{0}]", string.Join(", ", arr));
            Console.WriteLine();

            int count = RandomCount1(arr5);
            Console.WriteLine("Es sind " + count + " Zahlen über 30");
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

            int[] num2 = new int[size];
            for (int j = 0; j < num2.Length; j++)
            {

                num2[j] = size - j;

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
        
        //Start Random NumberArray


        public static int[] RandomNumberArray(int size)
        {
            int[] arraynew = new int[size];
            for (int i = 0; i < arraynew.Length; ++i)
            {
                arraynew[i] = Random.Next(101);
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

        //ende Random NumberArray 
        
       

        public static int[] RandomArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Random.Next(101);

            }
            return arr;

        }


        static void CrazyRange()
        {

            for (int i = 0; i < 10; i++)
            {
                int[] arr5 = {Random.Next(-50, 50) };

                Console.WriteLine(String.Join(", ", arr5));

            }

        }



        public static int RandomCount1(int[] arr)
        {
            int count = 0;
            foreach (int i in arr)
            {
                if (i > 30)
                {
                    count++;
                }
            }
            return count;
        }


    }
}
