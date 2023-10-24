using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Hassan.Week03.rehearsal;

namespace Hassan.Week04
{
    public class MergeSort
    {
        public static void Start()
        {


            int[] unsortierterArray = GenerateRandomArray(10);       
            Console.WriteLine("Unsortierter Array:");
            foreach (int num in unsortierterArray)
            {
                Console.Write(num + " ");
            }


            MergSort(unsortierterArray, 0, unsortierterArray.Length - 1);


            Console.WriteLine();
            Console.WriteLine("===============");



            Console.WriteLine("Sortierter Array:");
            foreach (int num in unsortierterArray)
            {
                Console.Write(num + " ");
            }

           float num4 = ReadFloat("gib zahl ");
            Console.WriteLine(num4);

        }

        static void MergSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                // Rekursiv MergeSort auf der linken und rechten Hälfte anwenden
                MergSort(arr, left, mid);
                MergSort(arr, mid + 1, right);

                // Zusammenführen der sortierten Hälften
                Merge(arr, left, mid, right);
            }
        }


        static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            // Kopieren der Daten in temporäre Arrays
            for (int i = 0; i < n1; i++)
                leftArray[i] = arr[left + i];
            for (int j = 0; j < n2; j++)
                rightArray[j] = arr[mid + 1 + j];

            int k = left;
            int l = 0;
            int r = 0;

            // Zusammenführen der beiden Hälften
            while (l < n1 && r < n2)
            {
                if (leftArray[l] <= rightArray[r])
                {
                    arr[k] = leftArray[l];
                    l++;
                }
                else
                {
                    arr[k] = rightArray[r];
                    r++;
                }
                k++;
            }

            // Restliche Elemente in den temporären Arrays, falls vorhanden
            while (l < n1)
            {
                arr[k] = leftArray[l];
                l++;
                k++;
            }
            while (r < n2)
            {
                arr[k] = rightArray[r];
                r++;
                k++;
            }
        }
        public static float ReadFloat(string msg)
        {
            while (true)
            {
                try
                {
                    Console.Write(msg);
                    string input = Console.ReadLine();
                    float myNumber = Convert.ToSingle(input);
                    return myNumber;
                }
                catch
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte gib eine Fließkommazahl ein.");
                }
            }
            
        }


    }
}
