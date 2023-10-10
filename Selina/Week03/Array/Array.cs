namespace Selina.Week03
{
    using System;
    using System.Linq;

    internal class Array
    {
        public static Random rand = new Random();


        public static void Start()
        {
            // Aufagbe 1:
            Output("Number Array");

            Console.WriteLine("Geben Sie die Größe des Arrays ein:");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] resultArray = CreateArray(size);
            int[] resultArray2 = CreateArray2(size);
   
            Console.WriteLine("\nDas Array ist:");
            foreach (int num in resultArray2)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            foreach (int num in resultArray)
            {
                Console.Write(num + " ");
            }

            // Aufagbe 2:
            Output("Aufgabe: Kopie");
            int[] copyArray = MakeCopy(resultArray);
            MakeCopy(resultArray);
            Console.WriteLine(string.Join(",", copyArray));

            // Aufagbe 3:
            Output("Random Number Array");
            int[] randomArray = RandomNumberArray(10, 0, 100, false);

            Console.WriteLine("\nJeder Zweiter Wert:");
            for (int i = 1; i < randomArray.Length; i = i + 2)
            {
                Console.Write("[{0}] ", string.Join(", ", randomArray[i]));
            }

            foreach (int num in randomArray)
            {
                Console.Write("[{0}] ", string.Join(", ", num));
            }

            Console.WriteLine("\n\nZweite Wert, Fünfte Wert und Zehnte Wert:");
            Console.WriteLine($"Array 2: {randomArray[1]} \nArray 5: {randomArray[4]}\nArray 10: {randomArray[9]}");

            //Aufagbe 4:
            Output("Random Number Array Crazy Range");

            RandomNumberArray(10, -50, 50, false);
            foreach (int num in randomArray)
            {
                Console.Write("[{0}] ", string.Join(", ", num));
            }

            //Aufagbe 5:
            Output("Random Number Array Zählen");

            RandomNumberArray(10, 1, 100, true);
            foreach (int num in randomArray)
            {
                Console.Write("[{0}] ", string.Join(", ", num));
            }




            //Aufagbe 6:
            Output("Random Number Array Summe");
         


            int[] randomArraySum = RandomNumberArray(10, 1, 100, false);
            bool first = true;
            foreach (int num in randomArraySum)
            {
                if (!first)
                {
                    Console.Write(" + ");
                }
                Console.Write(num);
                first = false;
            }
            Console.WriteLine(" = " + Summe(randomArraySum));


            //Aufgabe 7:
            Output("Random Number Array Summe");


            RandomNumberArray(10, 1, 100, false);
            RandomNumberArrayMin(randomArray);


            foreach (int num in randomArray)
            {
                Console.Write(num + " ");
            }

        }

        public static int[] RandomNumberArray(int size, int random, int random1, bool countNumbers)
        {
            int count = 0;
            int[] randomArray = new int[size];
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rand.Next(random, random1);
                if (randomArray[i] > 30)
                {
                    count++;
                }
            }
            if (countNumbers == true)
            {
                OutputCount(count);
            }
            return randomArray;
        }
        public static void OutputCount(int count)
        {
            Console.WriteLine($"{count} Zahlen sind über 30");
        }

        public static string Output(string output)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nAufgabe: {output}");
            Console.ForegroundColor = ConsoleColor.White;

            return output;
        }

        // Aufgabe 1:
        public static int[] CreateArray2(int size)
        {

            int[] newArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                newArray[i] = size - i;
            }

            return newArray;

        }
        public static int[] CreateArray(int size)
        {
            int[] newArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                newArray[i] = i + 1;
            }

            return newArray;
        }

        //Aufagbe 2:
        public static int[] MakeCopy(int[] resultArray)
        {
            int[] copyArray = new int[resultArray.Length];

            for (int i = 0; i < resultArray.Length; i++)
            {
                copyArray[i] = resultArray[i];
            }

            return copyArray;
        }

        //Aufagbe 6:
        public static int Summe(int[] randomArraySum)
        {
            int sum = 0;
            for (int i = 0; i < randomArraySum.Length; i++)
            {
                sum += randomArraySum[i];
            }
            return sum;
        }


        public static int[] RandomNumberArrayMin(int[] randomArray1)
        {
            int min = randomArray1.Min();
            int max = randomArray1.Max();

            Console.WriteLine("Kleinster Wert: " + min);
            Console.WriteLine("Groesster Wert: " + max);

            return randomArray1;
        }

    }
}
