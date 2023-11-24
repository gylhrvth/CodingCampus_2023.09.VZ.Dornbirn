namespace Gheorghe.Week03
{
    internal class Testen3
    {
        public static Random Random = new Random();
        public static void Start()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Increase Array:");
            int[] original = CreatArray(10);
            foreach (int i in original)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("====================================");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Deacrese Array2 :");
            int[] arr = CreatArray2(10);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("======================================");


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Copy von Array");
            int[] copy = CreatArray(10);
            foreach (int i in copy)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("=======================================");


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Random number von array:");
            int[] arrayrandom = RandomNumber(100);
            foreach (int i in arrayrandom)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("======================================================");



            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Array Crazy Range:");
            int[] crazyrange = CrazyRange(10);
            foreach (int i in crazyrange)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("===========================================================");



            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Random number array zählen:");
            int[] contnumm = NumberCount(CreatArray(10));
            foreach (int i in contnumm)
            {
                Console.Write(i + Random.Next(1, 100) + " ");
            }
            Console.WriteLine();
            Console.WriteLine("===============================================================");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Summe Array Zufall generiert:");
            int[] summearr = RandomSummeArray(CreatArray(10));
            foreach (int i in summearr)
            {
                Console.Write(i + Random.Next(1, 100) + " ");
            }
            Console.WriteLine();
            Console.WriteLine("===============================================================");


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Array Generator:");
            int[] arrgenerator = ArrayGenerator(CreatArray(10));
            foreach (int i in arrgenerator)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();




        }

        public static int[] CreatArray(int size)
        {
            int[] Array = new int[size];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = Random.Next(0, 20);
                Array[i] = i + 1;
            }
            return Array;
        }



        public static int[] CreatArray2(int size)
        {
            int[] Array = new int[size];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = Random.Next(0, 20);
                Array[i] = size - i;
            }
            return Array;
        }



        public static int[] MakeCopy(int[] original)
        {
            int[] MakeCopy = new int[original.Length];
            for (int i = 0; i < MakeCopy.Length; i++)
            {
                MakeCopy[i] = original[i];
            }
            return MakeCopy;
        }



        public static int[] RandomNumber(int size)
        {
            int[] Array = new int[size];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = Random.Next(100);

            }
            return Array;
        }

        public static int[] CrazyRange(int size)
        {
            int[] Array = new int[size];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = Random.Next(-50, 50);
                Array[i] += size;

            }

            return Array;
        }



        static int[] NumberCount(int[] array)
        {
            int count30 = 0;
            for (int i = 0; i > 30; i++)
            {
                array[i] = Random.Next(1, 100);
                array[i] += 1;
                if (i < 30)
                {
                    count30++;
                }

            }
            return array;
        }

        public static int[] RandomSummeArray(int[] array)
        {

            int[] summearray = new int[array.Length];
            for (int i = 0; i < summearray.Length; i++)

            {
                array[i] = Random.Next(1, 100);
                array[i] += 1;

            }
            return summearray;

        }

        public static int[] ArrayGenerator(int[] array)
        {
            int[] arrGenerator = new int[array.Length];
            for (int i = 0; array[i] < arrGenerator.Length; i++)
            {
                arrGenerator[i] = Random.Next(1, 100);
                arrGenerator[i] += 1;
            }
            return arrGenerator;

        }

        public static void Printminarry(int[] arrayGenerator)
        {
            foreach (int element in arrayGenerator)
            {
                Console.Write(element);
                Console.Write(" , ");
            }

        }
        public static int MinArray(int[] array)
        {
            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }

            }
            return min;

        }

    }
}



