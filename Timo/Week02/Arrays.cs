using System;

namespace Timo.Week02
{
    public class Arrays
    {
        public static void Start()
        {
            //Aufgabe1.1: Number Array Aufwärts
            Console.WriteLine("\nAufgabe1.1: Number Array");
            int[] arrUp = CreateArrayUp(15);
            for (int i = 0; i < arrUp.Length; ++i)
            {
                Console.WriteLine("{0}. = {1}", i, arrUp[i]);
            }

            //Aufgabe1.2: Number Array Abwärts
            Console.WriteLine("\nAufgabe1.2: Number Array");
            int[] arrDown = CreateArrayDown(19);
            for (int i = 0; i < arrDown.Length; ++i)
            {
                Console.WriteLine("{0}. = {1}", i, arrDown[i]);
            }


            //Aufgabe2
            //Console.WriteLine("\nAufgabe2: Kopie");
            //makeACopy(arrUp);


            //Aufgabe3.1 Random foreach
            Console.WriteLine("\nAufgabe3.1: Random Number Array");
            int[]arr= Random(5, 0, 100);

            //Aufgabe3.1 Random fori

        }


        //Aufgabe1.1: Number Array Aufwärts
        public static int[] CreateArrayUp(int size)
        {
            int[] arrUp = new int[size];
            for (int i = 0; i < arrUp.Length; i++)
            {
                arrUp[i] = i + 1;
            }
            return arrUp;
        }


        //Aufgabe1.2: Number Array Abwärts
        public static int[] CreateArrayDown(int size)
        {
            int[] arrDown = new int[size];
            int a = arrDown.Length;
            for (int i = 0; i < arrDown.Length; i++)
            {
                arrDown[i] = a;
                a--;
            }

            return arrDown;
        }

    }


    /*//Aufgabe2: Kopie
    public static int[] makeACopy(int[] original)
    {
        for (int i = 0; i < original.Length; i++)
        {
            Console.WriteLine(original[i]);
        }
        return original;
    }
    */


    //Aufgabe3.1 Random foreach
    public static int[] Random(int i, int min, int max)
    {
        Random random = new Random();

        int[] arr = new int[i];
        foreach (int number in arr)
        {
            int randomNumber = random.Next(min, max);
            arr[number] = randomNumber;
            Console.WriteLine($"{arr[number]} ");
        }
        return arr;
    }
}

