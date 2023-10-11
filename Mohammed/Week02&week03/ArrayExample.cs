using System;
namespace Mohammed.Week02
{
    public class ArrayExample
    {


        public static void StartArrayExample()
        {
            //printTriangleTopLeft("X ", 7);
            


            // the first exercise and beispiel
            int[] myarr = CreateArrayDesc(15);
            int[] copyArr = myarr; // !!! Vorsicht !!!

            //Console.WriteLine("[{0}]", string.Join(", ", myarr));
            //Console.WriteLine("[{0}]", string.Join(", ", copyArr));

            Console.WriteLine("============");
            //the secend exercise richtig (Kopie)!
            copyArr[0] = 99;
            Console.WriteLine("[{0}]", string.Join(", ", myarr));
            Console.WriteLine("[{0}]", string.Join(", ", copyArr));



            // the secend exercise
            //int[] myarray = numberArray(10);
            //Console.WriteLine("[{0}]", string.Join(", ", myarray));

            // the Secend exercise
            //int[] arr = makeCopy(100);
            //Console.WriteLine("[{0}]", string.Join(", ", arr));

        }

        //das ist beispiel dass mir zeigt der prinzip gleich ist!!
        public static void printTriangleTopLeft(string symbol, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows - i ; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

        //Aufgabe:Number Array 
        public static int[] CreateArray(int size)
        {
          
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = i+1;
            }
            return arr;
        }

        

        //EXERCISE FOR ME!!!!!!!!!
        public static int[] numberArray(int size)
        {
            int[] array = new int[size];

            for (int a = 0; a < array.Length; a++)
            {
                array[a] = a;
            }
            return array;

        }

        //the secend exercise (Kopie):

        public static int[] CreateArrayDesc(int size)
        {
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = size - i;
            }
            return arr; 
        }
        //!!!!!!!!!!!!!!!!!!!!!!!!!
        
    }
}
