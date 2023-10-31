using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Hassan.Week03.rehearsal;

namespace Hassan.Week06
{
    public class Datenklasse
    {
        private int minIndex;
        private int maxIndex;
        private double avgindex;


        public static void Start()
        {
            int[] randArr = GenerateRandomArray(10);


            PrintArray(randArr);
            Console.WriteLine();




            Datenklasse daten = new Datenklasse(randArr);
            Console.WriteLine(daten.ToString());


        }

        public Datenklasse(int[] arr)
        {
            minIndex = MinIndex(arr);
            maxIndex = MaxIndex(arr);
            avgindex = AvgIndex(arr);
      
        }



        public int MinIndex(int[] arr)
        {
            minIndex = GetArrayMin(arr);
            return minIndex; 
        }

        public int MaxIndex(int[] arr)
        {
            maxIndex = GetArrayMax(arr);
            return maxIndex; 
        }

        public double AvgIndex(int[] arr)
        {
            avgindex = GetArrayAvg(arr);
            return avgindex; 
        }

        public override string ToString()
        {
            return $"Kleinstes Element: {minIndex}, Größtes Element: {maxIndex}, Durchschnitt: {avgindex}";
        }

    }
}
