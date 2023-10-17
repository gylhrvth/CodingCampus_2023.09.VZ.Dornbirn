namespace Selina.Week03
{
    using System;
    using System.Linq;
    using static System.Runtime.InteropServices.JavaScript.JSType;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.ConstrainedExecution;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Diagnostics.Metrics;
    using System.Reflection.Emit;
    using System.Windows;
    using Microsoft.Win32.SafeHandles;


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

            Console.WriteLine("\n\nJeder Zweiter Wert:");   //Gibt jeden zweiten Wert von dem Array aus
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
            int[,] randomArray2D= CreateRandomArray2D(size,0, 101);     //macht Array2D mit random Zahlen von 0 bis 100
            OutputForUser2D(randomArray2D);     //Output für User
            Console.WriteLine();
            Summe2D(randomArray2D); //Output Summe für User
            Console.WriteLine("\n----------------------------------------------------------");

            //Aufagbe 10:
            Output("Aufgabe: Pascal Dreieck\n", ConsoleColor.DarkCyan);
            int [][] trinangel= GeneratePascalTriangle(size);
            PrintPascalTriangle(trinangel);
            Console.WriteLine("\n----------------------------------------------------------");

            //Aufagbe 11:
            Output("Aufgabe: Selection Sort \n", ConsoleColor.DarkYellow);
            randomArray = CreateRandomArray(size, 1, 101);  //macht randomArray von 1 bis 100 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ungeordnet: "); 
            OutputForUser(randomArray);
            SelectionSort(randomArray);     //ordnet Array 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("geordnet: "); 
            OutputForUser(randomArray);     //Output für User
            Console.ResetColor();
            Console.WriteLine("\n----------------------------------------------------------");

            //Aufagbe 12:
            Output("Aufgabe: Insertion Sort \n", ConsoleColor.Cyan);
            randomArray = CreateRandomArray(size, 1, 101);  //macht randomArray von 1 bis 100 
            InsertionSort(randomArray);  //ordnet Array
            OutputForUser(randomArray); // Output für User
            Console.WriteLine("\n----------------------------------------------------------");

            //Aufagbe 13:
            Output("Aufgabe: Gnome Sort \n", ConsoleColor.Magenta);
            randomArray = CreateRandomArray(size, 1, 101);  //macht randomArray von 1 bis 100 
            GnomeSort(randomArray); //ordnet Array
            OutputForUser(randomArray); //Output für User
            Console.WriteLine("\n----------------------------------------------------------");

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
            Console.ResetColor();

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
        public static void OutputForUser2D(int[][] randomArray)
        {
            for (int row = 0; row < randomArray.GetLength(0); row++)
            {
                for (int col = 0; col < randomArray.GetLength(1); col++)
                {
                    Console.Write($"{randomArray[row][col],-4}   ");
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

        //Aufagbe 8: Bubblesort mit Zahlen
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

        //Aufgabe 9: Bubblesort mit Zahlen
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
          
                Console.WriteLine($"Summe der Reihe {count}:\x1B[4m{sum}\x1B[0m");
                sum = 0;
                count++;
            }
            return sum;
        }

        //Aufagbe 10: Aufgabe: Pascal Dreieck --> funktioniert noch nicht
        public static int[][] GeneratePascalTriangle(int size)
        {
            int[][] triangle = new int[size][];

            for (int i = 0; i < size; i++)
            {
                triangle[i] = new int[i + 1];
                triangle[i][0] = 1;

                for (int j = 1; j < i; j++)
                {
                    triangle[i][j] = 1;
                }
            }
         
            return triangle;
        }

        public static void PrintPascalTriangle(int[][] triangle)
        {
            foreach (var row in triangle)
            {
                foreach (var number in row)
                {
                    Console.Write(number + " ");
                }
            }
        }

        //Aufagbe 11: The Sound of Sorting Algorithm Cheat Sheet
        public static int[] SelectionSort(int[] randomArray)
        {
            for(int i=0; i < randomArray.Length -1 ; i++)
            {
                int min = i;
                for(int j = i + 1; j < randomArray.Length; j++)
                {
                    if (randomArray[j] < randomArray[min])
                    {
                        min = j;
                        int temp = randomArray[min];
                        randomArray[min] = randomArray[i];
                        randomArray[i] = temp;
                    }
                }
            }
            return randomArray;
        }

        //Aufage 12: The Sound of Sorting Algorithm Cheat Sheet
        public static int[] InsertionSort(int[] randomArray)
        {
            for(int i= 1; i < randomArray.Length;i++)
            {
                int temp = randomArray[i];
                int j = i - 1;

                while (j >= 0 && randomArray[j] > temp)
                {
                    randomArray[j+1] = randomArray[j];
                    j -= 1;
                }
                randomArray[j+1]= temp; 
            }


            return randomArray;
        }

        //Aufagbe 13: The Sound of Sorting Algorithm Cheat Sheet
        public static int[] GnomeSort(int[] randomArray)
        {
            int index = 0;
            while (index < randomArray.Length)
            {
                if (index == 0 || randomArray[index] >= randomArray[index - 1])
                {
                    index++;
                }
                else
                {
                    int temp = 0;
                    temp = randomArray[index];
                    randomArray[index] = randomArray[index - 1];
                    randomArray[index - 1] = temp;
                    index--;
                }
            }
            return randomArray;
        }
    }
}



