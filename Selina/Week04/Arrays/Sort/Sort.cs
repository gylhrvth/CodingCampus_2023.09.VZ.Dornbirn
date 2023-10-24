using Selina.Week04.Ausagbe;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week04.Sort
{
    internal class Sort
    {
        public static void Start()
        {
            int size = Week03.Array.ReadNumber("Geben Sie die Größe des Arrays ein:", "Sie müssen eine Zahl eingeben!");
            int[] randomArray = new int[size];

            //Aufgabe 8:
            Ausgabe.Output("Bubblesort mit Zahlen\n", ConsoleColor.DarkRed);
            randomArray = Week03.Array.CreateRandomArray(size, 1, 101);  //macht Array mit random Zahlen von 1 bis 100
            Console.Write("Array ungeordnet:            ");
            Ausgabe.OutputForUser(randomArray);     //Output für User => UNGEORDNET ARRAY

            Console.Write("Array geordnet aufsteigend:  ");
            Ascending(randomArray);
            Ausgabe.OutputForUser(randomArray);     //Output für User => GEORDNET AUFSTEIGEND ARRAY

            Console.Write("Array geordnet absteigend:   ");    //Output für User => GEORDNET ABSTEIGEND ARRAY
            Descending(randomArray);
            Ausgabe.OutputForUser(randomArray);
            Console.WriteLine("\n----------------------------------------------------------");

            //Aufagbe 11:
            Ausgabe.Output("Aufgabe: Selection Sort \n", ConsoleColor.DarkYellow);
            randomArray = Week03.Array.CreateRandomArray(size, 1, 101);  //macht randomArray von 1 bis 100 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ungeordnet: ");
            Ausgabe.OutputForUser(randomArray);
            SelectionSort(randomArray);     //ordnet Array 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("geordnet: ");
            Ausgabe.OutputForUser(randomArray);     //Output für User
            Console.ResetColor();
            Console.WriteLine("\n----------------------------------------------------------");

            //Aufagbe 12:
            Ausgabe.Output("Aufgabe: Insertion Sort \n", ConsoleColor.Cyan);
            randomArray = Week03.Array.CreateRandomArray(size, 1, 101);  //macht randomArray von 1 bis 100 
            InsertionSort(randomArray);  //ordnet Array
            Ausgabe.OutputForUser(randomArray); // Output für User
            Console.WriteLine("\n----------------------------------------------------------");

            //Aufagbe 13:
            Ausgabe.Output("Aufgabe: Gnome Sort \n", ConsoleColor.Magenta);
            randomArray = Week03.Array.CreateRandomArray(size, 1, 101);  //macht randomArray von 1 bis 100 
            GnomeSort(randomArray); //ordnet Array
            Ausgabe.OutputForUser(randomArray); //Output für User
            Console.WriteLine("\n----------------------------------------------------------");

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

        //Aufagbe 11: The Sound of Sorting Algorithm Cheat Sheet
        public static int[] SelectionSort(int[] randomArray)
        {
            for (int i = 0; i < randomArray.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < randomArray.Length; j++)
                {
                    if (randomArray[j] < randomArray[min])
                    {
                        min = j;
                    }
                }
                if (min != randomArray[i])
                {
                    int temp = randomArray[min];
                    randomArray[min] = randomArray[i];
                    randomArray[i] = temp;
                }

            }
            return randomArray;
        }

        //Aufage 12: The Sound of Sorting Algorithm Cheat Sheet
        public static int[] InsertionSort(int[] randomArray)
        {
            for (int i = 1; i < randomArray.Length; i++)
            {
                int temp = randomArray[i];
                int j = i - 1;

                while (j >= 0 && randomArray[j] > temp)
                {
                    randomArray[j + 1] = randomArray[j];
                    j -= 1;
                }
                randomArray[j + 1] = temp;
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
