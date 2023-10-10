using System;

namespace Selina.Week03
{
    internal class Array
    {
        public static void Start()
        {
            // Aufagbe 1:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nAufgabe: Number Array");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Geben Sie die Größe des Arrays ein:");
                int size = Convert.ToInt32(Console.ReadLine());

                int[] resultArray = CreateArray(size);
                int[] resultArray2 = CreateArray2(size);
                int[] copyArray = MakeCopy(resultArray);

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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\nAufgabe: KOPIE");
                Console.ForegroundColor = ConsoleColor.White;

                MakeCopy(resultArray);
                Console.WriteLine(string.Join(",", copyArray));

            // Aufagbe 3:
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("\n\nAufgabe: Random Number Array");
                Console.ForegroundColor = ConsoleColor.White;

                Random random = new Random();
                int[] randomArray = new int[10];
                RandomNumberArray(random, randomArray);
            
                foreach (int num in randomArray)
                {
                    Console.Write("[{0}] ", string.Join(", ", num));
                }

                Console.WriteLine("\n\nZweite Wert, Fünfte Wert und Zehnte Wert:");
                Console.WriteLine($"Array 2: {randomArray[1]} \nArray 5: {randomArray[4]}\nArray 10: {randomArray[9]}");


                Console.WriteLine("\nJeder Zweiter Wert:");
                GetNumberArray2(randomArray);

            //Aufagbe 4:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\nAufgabe: Number Array Crazy Range");
                Console.ForegroundColor = ConsoleColor.White;

                Random randomCrazy = new Random();
                int[] randomArrayCrazy = new int[10];
                RandomArrayCrazyRange(randomCrazy, randomArrayCrazy);

                foreach(int num in randomArrayCrazy)
                {
                    Console.Write("[{0}] ", string.Join(", ", num));
                }

            //Aufagbe 5:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\nAufgabe: Number Array Crazy Range");
                Console.ForegroundColor = ConsoleColor.White;
             
                Random randomCount = new Random();
                int[] randomArrayCount = new int[10];
                RandomArrayCount(randomCount, randomArrayCount);

                foreach (int num in randomArrayCount)
                {
                    Console.Write("[{0}] ", string.Join(", ", num));
                }


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

        // Aufgabe 3:
            public static int[] RandomNumberArray(Random random, int[] randomArray)
            {
                for (int i = 0; i < randomArray.Length; i++)
                {
                    randomArray[i] = random.Next(100);
                }
                return randomArray;
            }
            public static int[] GetNumberArray2(int[] randomArray)
            {
                for(int i = 1;i < randomArray.Length;i= i+2)
                {
                    Console.Write("[{0}] ", string.Join(", ", randomArray[i]));
                }
                return randomArray;
            }
      
        // Aufgabe 4:
            public static int[] RandomArrayCrazyRange(Random randomCrazy, int [] randomArrayCrazy)
            {
                for (int i = 0; i < randomArrayCrazy.Length; i++)
                {
                    randomArrayCrazy[i] = randomCrazy.Next(-50,50);
                }
                return randomArrayCrazy;
            }

        //Aufagbe 5:
            public static int[] RandomArrayCount(Random randomCount, int[] randomArrayCount) 
            {
                for (int i = 0; i < randomArrayCount.Length; i++)
                {
                    randomArrayCount[i] = randomCount.Next(1, 100);
                }

                return randomArrayCount;
            }

    }
}
