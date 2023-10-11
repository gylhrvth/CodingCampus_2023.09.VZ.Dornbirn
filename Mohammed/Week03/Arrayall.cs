using System;
namespace Mohammed.Week03
{
    public class Arrayall
    {

        // this belongs to a random exercise.
        public static Random rand = new Random();

        public static void startArrayall()
        {

            /*
            //ab hier gehört erste und zweite aufgabe..
            //Console.WriteLine("orginal");
            int[] orginal = Array(10);

            foreach (int element in orginal)
            {
                //Console.Write(element + ", ");
            }


            //Console.WriteLine();
            //Console.WriteLine("---------------");

            //Console.WriteLine("Copy");
            int[] copy = MakeAcopy(orginal);
            foreach (int element in copy)
            {
                //Console.Write(element + ", ");
            }

            //Console.WriteLine();

            //Console.WriteLine("---------------");
            //Console.WriteLine(" change orginal");
            orginal[9] = 200;
            foreach (int element in orginal)
            {
               // Console.Write(element + " ");
            }
            //Console.WriteLine();

            //Console.WriteLine("..............");
            //Console.WriteLine("change copy");
            foreach (int element in copy)
            {
                //Console.Write(element + " ");
            }
            //Console.WriteLine();


            //gehört Random exercise
            //Random Number Array
            int[] RandomArr = RandomNumber(10);


            //Console.WriteLine("[{0}]", string.Join(", ", RandomArr));

            foreach (int element in RandomArr)
            {
                Console.Write(element + " ");
            }

            */


            Console.WriteLine("Crazy Array");
            int[] RandomArrb = RandomCrazy(15);

            Console.WriteLine("[{0}]", string.Join(", ", RandomArrb));

            int count30 = RandomCount(RandomArrb);
            Console.WriteLine("Es sind " + count30 + " zaheln über 30!");


           
           
        }






        //-------------------------------------

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
            foreach(int element in arr)
            {
                if(element > 30)
                {
                    count++;
                }

            }
            return count;
           
        }
    }


}

