namespace Gheorghe.Week03
{
    internal class Arrays03
    {
        public static Random rand = new Random();
        private static int avarage;
        private static int avaragea;

        public static void Start()
        {
            /*

            // ARRAY Print
            int[] original = Array(10);
            Console.WriteLine("===================   ");
            Console.WriteLine("Array Print");
            foreach (int element in original)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine("==================");



            //Arry Copy 
            int[] copy = MakeaACopy(original);
            Console.WriteLine("Array Copy");
            foreach (int element in copy)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            //Änderung original

            original[3] = 200;
            Console.WriteLine("==================");
            Console.WriteLine("Änderung original");
            foreach (int element in original)
            {
                Console.Write(element + " ");

            }
            Console.WriteLine();



            // Änderung von Copy
            copy[2] = 100;
            Console.WriteLine("======================");
            Console.WriteLine("Änderung Copy");
            foreach (int element in copy)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            */

            int[] arr = NumberArray(7);
            int[] cp = MakeaACopy(arr);
            //Console.WriteLine("[{0}]", string.Join(", ", arr));
            PrintArray(arr);
            Console.WriteLine("Random Arry original");
            Console.WriteLine("=======================");

            PrintArray(cp);
            Console.WriteLine("Copy von Array");


            Console.WriteLine("=================================");
            PrintArray(arr);
            arr[0] = 999;
            PrintArray(cp);
            Console.WriteLine("Änderung von Array");



            Console.WriteLine("==================================");
            Console.WriteLine("CrazyRangeArray");
            int[] crazyRange = CrazyRangeArray(10);
            PrintArray(crazyRange);

            Console.WriteLine("==========================================================================");
            Console.WriteLine("NumbersArray");
            int[] numbersarray = NumberArray(100);
            PrintArray(numbersarray);
            Console.WriteLine("==========================================================================");

            int[] arrayszahl = NummerArray(10);
            PrintNummerArray(arrayszahl);
            Console.WriteLine("Numbers bigger than 30: " + CountNumbersBigger30(arrayszahl));
            Console.WriteLine("==========================================================================");


            int[] arraysumme = Getmyarray(2);
            PrintvonSumme(arraysumme);
            Console.WriteLine("Summe von Array ist: " + SummeArray(arraysumme));
            Console.WriteLine("==========================================================================");

            int[] minarray = Numarator(10);
            Printminarry(minarray);
            Console.WriteLine("Minimum von Array ist: " + Minimumrechnen(minarray));
            Console.WriteLine("==========================================================================");

            int[] maxarray = Numarator2(10);
            Printmaximarray(maxarray);
            Console.WriteLine("Maximum von Array ist: " + Maximumrechnen(maxarray));
            Console.WriteLine("===========================================================================");

            int[] avaragearray = Mynumarator(2);
            Printavaragearry(avaragearray);
            Console.WriteLine("Avarge von Array ist: " + Avaragerechner(avaragearray));
            Console.WriteLine("============================================================================");




        }



        public static int[] Array(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr.Length;
            }
            return arr;
        }
        public static int[] MakeaACopy(int[] original)
        {
            int[] copy = new int[original.Length];
            for (int i = 0; i < copy.Length; i++)
            {
                copy[i] = original[i];
            }
            return copy;
        }




        public static int[] NumberArray(int size)
        {
            int[] randoms = new int[size];
            for (int i = 0; i < randoms.Length; i++)
            {
                randoms[i] = rand.Next(0, 101);
            }
            return randoms;
        }
        public static void PrintArray(int[] arr)
        {
            Console.Write("[");
            bool first = true;
            foreach (int value in arr)
            {
                if (!first)
                {
                    Console.Write(", ");
                }
                Console.Write(value);
                first = false;
            }
            Console.WriteLine("]");
        }




        public static int[] CrazyRangeArray(int size)
        {
            int[] range = new int[size];
            for (int i = 0; i < range.Length; i++)
            {
                range[i] = rand.Next(-50, 50);
            }
            return range;
        }
        public static void PrintCrazyRangeArry(int[] range)
        {
            foreach (int element in range)

            {
                Console.Write(element);
                Console.Write(" , ");
            }
        }






        public static int[] NummerArray(int size)
        {
            int[] Ziffer = new int[size];
            for (int i = 0; i < size; i++)
            {
                Ziffer[i] = rand.Next(1, 100);
            }
            return Ziffer;
        }
        public static void PrintNummerArray(int[] Ziffer)
        {
            foreach (int element in Ziffer)
            {
                Console.Write(element);
                Console.Write(", ");
            }
        }

        public static int CountNumbersBigger30(int[] arr)
        {
            int numbersBiggerThan30 = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 30)
                {
                    numbersBiggerThan30++;
                }
            }
            return numbersBiggerThan30;
        }


        public static int[] Getmyarray(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 100);
            }
            return array;
        }
        public static void PrintvonSumme(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element);
                Console.Write(", ");
            }
        }
        public static int SummeArray(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }


        public static int[] Numarator(int size)
        {
            int[] numarator = new int[size];
            for (int i = 0; i < numarator.Length; i++)
            {
                numarator[i] = rand.Next(1, 100);
            }
            return numarator;
        }

        public static void Printminarry(int[] numarator)
        {
            foreach (int element in numarator)
            {
                Console.Write(element);
                Console.Write(" , ");
            }

        }
        public static int Minimumrechnen(int[] numarator)
        {
            int min = Int32.MaxValue;
            for (int i = 0; i < numarator.Length; i++)
            {
                if (numarator[i] < min)
                {
                    min = numarator[i];
                }

            }
            return min;
        }


        public static int[] Numarator2(int size)
        {
            int[] numarator2 = new int[size];
            for (int i = 0; i < numarator2.Length; i++)
            {
                numarator2[i] = rand.Next(1, 100);
            }
            return numarator2;
        }

        public static void Printmaximarray(int[] numarator2)
        {
            foreach (int element in numarator2)
            {
                Console.Write(element);
                Console.Write(" , ");
            }
        }

        public static int Maximumrechnen(int[] numartor2)
        {
            int max = Int32.MinValue;
            for (int i = 0; i < numartor2.Length; i++)
            {
                if ((numartor2[i] > max))
                {
                    max = numartor2[i];
                }
            }
            return max;
        }


        public static int[] Mynumarator(int size)
        {
            int[] mynumarator = new int[size];
            for (int i = 0; i < mynumarator.Length; i++)
            {
                mynumarator[i] = rand.Next(1, 100);

            }
            return mynumarator;
        }

        public static void Printavaragearry(int[] mynumarator)
        {
            foreach (int element in mynumarator)
            {
                Console.Write(element);
                Console.Write(" , ");
            }
        }


        public static int Avaragerechner(int[] mynumarator)
        {
            int sume = 0;
            for (int i = 0; i < mynumarator.Length; i++)
            {
                sume += mynumarator[i];
                avarage = sume / mynumarator.Length;
            }
            return avarage;
        }

    }
}














/*  public static void Start()
  {
   createArraysIncrease(10);
   createArraysDecrease(15);
}

public static int[] createArraysIncrease(int size)
{
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
 array[i] = i;
 Console.WriteLine(array[i]);

}
return array;
}


public static int[] createArraysDecrease(int size)
{
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
 array[i] = size - i;
 Console.WriteLine(array[i]);

}
return array;
}


} */






