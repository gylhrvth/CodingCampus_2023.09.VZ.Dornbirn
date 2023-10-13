namespace Selina.Week03
{
    using System;
    using System.Linq;
    using static System.Runtime.InteropServices.JavaScript.JSType;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.ConstrainedExecution;
    using System.Collections.Generic;
    using System.Drawing;

    internal class Array
    {
        public static Random rand = new Random();
        public static void Start()
        {
            // Aufagbe 1:
            Output("Number Array\n", ConsoleColor.Red);
            int size = ReadNumber("Geben Sie die Größe des Arrays ein:", "Sie müssen eine Zahl eingeben!");     //Input User wir in size gespeichert
            int[] randomArray = new int[size];

            int[] resultArray1 = CreateArray1(size);    //Input User wird in einem Array gespeichert und geordnet ausgegeben 
            int[] resultArray2 = CreateArray2(size);

            Console.WriteLine("\nDas Array ist:");  //Output für den User
            OutputForUser(resultArray1);
            OutputForUser(resultArray2);
            Console.WriteLine("\n----------------------------------------------------------");


            // Aufagbe 2:
            Output("Kopie", ConsoleColor.Yellow);
            int[] copyArray = MakeCopy(resultArray1);       //resultArray1 wird kopiert und in copyArray gespeichert
            MakeCopy(resultArray1);
            OutputForUser(copyArray);   //Output für den User
            Console.WriteLine("\n----------------------------------------------------------");


            // Aufagbe 3:
            Output("Random Number Array", ConsoleColor.Green);
            randomArray = CreateRandomArray(size, 0, 101);  //macht Array mit random Zahlen von 0 bis 100
            OutputForUser(randomArray);     //Output für User

            Console.WriteLine("\n\nJeder Zweiter Wert:");   //Gibt jeden zeiten Wert von dem Array aus
            for (int i = 1; i < randomArray.Length; i += 2)
            {
                Console.Write("[{0}] ", string.Join(", ", randomArray[i]));
            }

            Console.WriteLine("\n\nZweite Wert, Fünfte Wert und Zehnte Wert:");     //Gibt den 2, 5 und den 10 Wert eines Arrays aus
            if(randomArray.Length >= 1) 
            {
                Console.Write($"Array 2  : [{randomArray[1]}]");
            }
            if (randomArray.Length >= 5) 
            {
                Console.WriteLine($"\nArray 5  : [{randomArray[4]}]");
            }
            if(randomArray.Length >= 9)
            {
                Console.WriteLine($"Array 10  : [{randomArray[9]}]");
            }
            else
            {
                Console.WriteLine();
            }
            Console.WriteLine("\n----------------------------------------------------------");


            //Aufagbe 4:
            Output("Random Number Array Crazy Range", ConsoleColor.Blue);
            randomArray = CreateRandomArray(size, -50, 51);     //macht Array mit random Zahlen von -50 bis 50
            OutputForUser(randomArray);     //Output für User
            Console.WriteLine("\n----------------------------------------------------------");


            //Aufagbe 5:
            Output("Random Number Array Zählen\n", ConsoleColor.Magenta);
            randomArray = CreateRandomArray(size, 1, 101);  //macht Array mit random Zahlen von 1 bis 100
            int count = CountOver30(randomArray);
            Console.WriteLine($"{count} Werte sind über 30");
            OutputForUser(randomArray);     //Output für User
            Console.WriteLine("\n----------------------------------------------------------");


            //Aufagbe 6:
            Output("Random Number Array Summe", ConsoleColor.DarkBlue);
            int[] randomArraySum = CreateRandomArray(size, 1, 101);     //macht Array mit random Zahlen von 1 bis 100
            
            bool first = true;
            Console.Write("\n[ ");
            foreach (int num in randomArraySum)     //Output für User
            {
                if (!first)
                {
                    Console.Write(" + ");
                }
                Console.Write(num);
                first = false;
            }
            Console.Write(" ]");
            Console.WriteLine(" = " + Summe(randomArraySum));   //Output Summe für User
            Console.WriteLine("----------------------------------------------------------");


            //Aufgabe 7:
            Output("Random Number Array Min / Max / Avg\n", ConsoleColor.Cyan);

            randomArray = CreateRandomArray(size, 1, 101);  //macht Array mit random Zahlen von 1 bis 100
            int min= RandomNumberArrayMin(randomArray);     //RandomNumberArrayMin gibt das Min von Array
            int max = RandomNumberArrayMax(randomArray);    //RandomNumberArrayMax gibt das Max von Array
            double avg= RandomNumberArrayAvg(randomArray);  //RandomNumberArrayAvg gibt das Avg von Array
            OutputForUser(randomArray);
            Console.Write($"Das Min ist = [{min}]\nDas Max ist = [{max}]\nDer Avg ist = [{avg}]"); //Output for User
            Console.WriteLine("\n----------------------------------------------------------");


            //Aufgabe 8:
            Output("Bubblesort mit Zahlen\n", ConsoleColor.DarkRed);
            randomArray = CreateRandomArray(size, 1, 101);  //macht Array mit random Zahlen von 1 bis 100
            Console.Write("Array ungeordnet:            ");
            OutputForUser(randomArray);     //Output für User => UNGEORDNET ARRAY
         
            Console.Write("Array geordnet aufsteigend:  ");
            Ascending(randomArray);
            OutputForUser(randomArray);     //Output für User => GEORDNET AUFSTEIGEND ARRAY
          
            Console.Write("Array geordnet absteigend:   ");    //Output für User => GEORDNET ABSTEIGEND ARRAY
            Descending(randomArray);
            OutputForUser(randomArray);
            Console.WriteLine("\n----------------------------------------------------------");

            //Aufagbe 9:
            Output("Aufgabe: 2D-Array\n", ConsoleColor.DarkMagenta);
            int[,] randomArray2D= CreateRandomArray2D(size,0, 101);
            OutputForUser2D(randomArray2D);
            Console.WriteLine();
            Summe2D(randomArray2D);


        }

        //User Input:
        public static int ReadNumber(string prompt, string onError)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    int ourNumber = Convert.ToInt32(Console.ReadLine());
                    return ourNumber;
                }
                catch (Exception exc)
                {
                    Console.Error.WriteLine(onError);
                }
            }
        }
        //Random Number:
        public static int[] CreateRandomArray(int size, int from, int to)
        {
            int[] randomArray = new int[size];
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rand.Next(from, to);
            }
            return randomArray;
        }
        public static int[, ] CreateRandomArray2D(int size, int from, int to)
        {
            int[,] randomArray = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    randomArray[i, j] = rand.Next(from, to); 
                }
            }
            return randomArray;


            //andere Variante:

            //public static int[][] CreateRandom2DArray2(int height, int width)
            //{
            //    int[][] arr = new int[height][];

            //    for(int row=0; row<height; row++)
            //    {
            //        arr[row] = new int[width];
            //    }

            //    for(int row=0; row<arr.Length;row++)
            //    {
            //        for(int col = 0; col < arr[row].Length; col++) {
            //            arr[row][col] = 123;
            //        }
            //    }
            //    return arr;
            //}
        }
        public static int CountOver30(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 30)
                {
                    count++;
                }
            }
            return count;
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
            Console.Write("[");
            foreach (int num in randomArray)
            {
                if (!first)
                {
                    Console.Write(", ");
                }
                Console.Write(num);
                first = false;
            }
            Console.WriteLine("]");
        }
        public static void OutputForUser2D(int[,] randomArray)
        {
            for (int row = 0; row < randomArray.GetLength(0); row++)
            {
                for (int col = 0; col < randomArray.GetLength(1); col++)
                {
                    Console.Write($"{randomArray[row, col],-4}   ");
                }
                Console.WriteLine();
            }
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
        public static int[] CreateArray1(int size)
        {
            int[] newArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = i + 1;
            }
            return newArray;
        }

        //Aufagbe 2: KOPIE
        public static int[] MakeCopy(int[] original)
        {
            int[] copyArray = new int[original.Length];
            for (int i = 0; i < original.Length; i++)
            {
                copyArray[i] = original[i];
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
            int min = randomArray[0];
            for (int i = 1; i < randomArray.Length; i++)
            {
                if (randomArray[i] < min)
                {
                    min = randomArray[i];
                }
            }
            return min;
        }
        public static int RandomNumberArrayMax(int[] randomArray)
        {
            int max = randomArray[0];
            for (int i = 1; i < randomArray.Length; i++)
            {
                if (randomArray[i] > max)
                {
                    max = randomArray[i];
                }
            }

            return max;
        }
        public static double RandomNumberArrayAvg(int[] randomArray)
        {
            double avg = 0.0;
            int sum = Summe(randomArray);
            avg= (double)sum/randomArray.Length;
            return avg;
        }

        //Aufagbe 8:
        public static void Ascending(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        public static void Descending(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        //Aufgabe 9:
        public static int Summe2D(int[,] randomArray)
        {
            int sum = 0;
            int count = 0;
            
            for (int row = 0; row < randomArray.GetLength(0); row++)
            {
                for (int col = 0; col < randomArray.GetLength(1); col++)
                {
                    sum = sum + randomArray[row, col];
                }
                Console.WriteLine($"Summe der Reihe {count}: {sum}");
                sum = 0;
                count++;
            }
            return sum;
            
        }
    }
}
