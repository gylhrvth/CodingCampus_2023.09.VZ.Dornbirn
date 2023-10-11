namespace Selina.Week03
{
    using System;
    using System.Linq;
    using static System.Runtime.InteropServices.JavaScript.JSType;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.ConstrainedExecution;
    using System.Collections.Generic;

    internal class Array
    {
        public static Random rand = new Random();
        public static void Start()
        {
            // Aufagbe 1:
            Output("Number Array\n", ConsoleColor.Red);
            Console.WriteLine("Geben Sie die Größe des Arrays ein:");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] resultArray = CreateArray(size);
            int[] resultArray2 = CreateArray2(size);

            Console.Write("\nDas Array ist:");
            OutputForUser(resultArray);
            OutputForUser(resultArray2);
            Console.WriteLine("\n----------------------------------------------------------");

            // Aufagbe 2:
            Output("Kopie", ConsoleColor.Yellow);
            int[] copyArray = MakeCopy(resultArray);
            MakeCopy(resultArray);
            OutputForUser(copyArray);
            Console.WriteLine("\n----------------------------------------------------------");

            // Aufagbe 3:
            Output("Random Number Array", ConsoleColor.Green);
            int[] randomArray = RandomNumberArray(10, 0, 100, false);
            OutputForUser(randomArray);

            Console.WriteLine("\n\nJeder Zweiter Wert:");
            for (int i = 1; i < randomArray.Length; i += 2)
            {
                Console.Write("[{0}] ", string.Join(", ", randomArray[i]));
            }
            Console.WriteLine("\n\nZweite Wert, Fünfte Wert und Zehnte Wert:");
            Console.Write($"Array 2  : [{randomArray[1],5}] \nArray 5  : [{randomArray[4],5}]\nArray 10 : [{randomArray[9],5}]");
            Console.WriteLine("\n----------------------------------------------------------");

            //Aufagbe 4:
            Output("Random Number Array Crazy Range", ConsoleColor.Blue);
            RandomNumberArray(10, -50, 50, false);
            OutputForUser(randomArray);
            Console.WriteLine("\n----------------------------------------------------------");

            //Aufagbe 5:
            Output("Random Number Array Zählen\n", ConsoleColor.Magenta);
            RandomNumberArray(10, 1, 100, true);
            OutputForUser(randomArray);
            Console.WriteLine("\n----------------------------------------------------------");

            //Aufagbe 6:
            Output("Random Number Array Summe", ConsoleColor.DarkBlue);
            int[] randomArraySum = RandomNumberArray(10, 1, 100, false);
            bool first = true;
            Console.Write("\n[ ");
            foreach (int num in randomArraySum)
            {
                if (!first)
                {
                    Console.Write(" + ");
                }
                Console.Write(num);
                first = false;
            }
            Console.Write(" ]");
            Console.WriteLine(" = " + Summe(randomArraySum));
            Console.WriteLine("----------------------------------------------------------");

            //Aufgabe 7:
            Output("Random Number Array Min / Max / Avg\n", ConsoleColor.Cyan);
            RandomNumberArray(10, 1, 100, false);
            int min= RandomNumberArrayMin(randomArray);
            int max = RandomNumberArrayMax(randomArray);
            int avg= RandomNumberArrayAvg(randomArray); 
            Console.Write($"Das Min ist = [{min}]\nDas Max ist = [{max}]\nDer Avg ist = [{avg}]");
            Console.WriteLine("\n----------------------------------------------------------");

            //Aufgabe 8:
            Output("Bubblesort mit Zahlen\n", ConsoleColor.DarkRed);
            RandomNumberArray(10, 1, 100, false);
            Console.Write("Array ungeordnet:");
            OutputForUser(randomArray);
            Console.WriteLine("\n");

            Console.Write("Array geordnet aufsteigend:");
            Ascending(randomArray);
            OutputForUser(randomArray);
            Console.WriteLine("\n");

            Console.Write("Array geordnet absteigend:");
            Descending(randomArray);
            OutputForUser(randomArray);
            Console.WriteLine("\n----------------------------------------------------------");
        }

        //Random Number:
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
                Console.Write($"{count} Zahlen sind über 30");
            }
            return randomArray;
        }
   
        //Output Aufgabe mit Farbe
        public static string Output(string output, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"\n\nAufgabe: {output}");
            Console.ForegroundColor = ConsoleColor.White;

            return output;
        }

        //OutputForUser: das Ergebnis der jeweiligen Aufagben 
        public static void OutputForUser(int[] randomArray)
        {
            bool first = true;
            Console.Write("\n[ ");
            foreach (int num in randomArray)
            {
                if (!first)
                {
                    Console.Write(", ");
                }
                Console.Write(num);
                first = false;
            }
            Console.Write(" ]");
        }
    
        // Aufgabe 1: Number Array
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

        //Aufagbe 2: KOPIE
        public static int[] MakeCopy(int[] resultArray)
        {
            int[] copyArray = new int[resultArray.Length];
            for (int i = 0; i < resultArray.Length; i++)
            {
                copyArray[i] = resultArray[i];
            }
            return copyArray;
        }

        //Aufagbe 6: Random Number Array Summe
        public static int Summe(int[] randomArraySum)
        {
            int sum = 0;
            for (int i = 0; i < randomArraySum.Length; i++)
            {
                sum += randomArraySum[i];
            }
            return sum;
        }

        //Aufagbe 7: Random Number Array Min/Max/Avg
        public static int RandomNumberArrayMin(int[] randomArray)
        {
            int min = randomArray.Min();
            return min;
        }
        public static int RandomNumberArrayMax(int[] randomArray)
        {
            int max = randomArray.Max();
            return max;
        }
        public static int RandomNumberArrayAvg(int[] randomArray)
        {
            int avg = 0;
            int sum = Summe(randomArray);
            avg= sum/randomArray.Length;
            return avg;
        }

        //Aufagbe 8:
        public static int[] Ascending(int[] randomArray)
        {
            int a;
            for (int i = 1; i < randomArray.Length; i++)
            {
                for (int y = 0; y < (randomArray.Length - i); y++)
                {
                    if (randomArray[y] > randomArray[y + 1])
                    {
                        a = randomArray[y];
                        randomArray[y] = randomArray[y + 1];
                        randomArray[y + 1] = a;
                    }
                }
            }
            return randomArray;
        }
        public static int[] Descending(int[] randomArray)
        {
            int a;
            for (int i = 1; i < randomArray.Length; i++)
            {
                for (int y = 0; y < (randomArray.Length - i); y++)
                {
                    if (randomArray[y] < randomArray[y + 1])
                    {
                        a = randomArray[y];
                        randomArray[y] = randomArray[y + 1];
                        randomArray[y + 1] = a;
                    }
                }
            }
            return randomArray;
        }


    }
}
