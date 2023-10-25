using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week05
{
    internal class DataTableExample
    {
        public static void Start()
        {
            String[] firstName = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
            String[] lastName = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
            int[] age = { 40, 78, 5, 18, 81 };
            String[] place = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
            float[] distanceFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };

            
                         

        }
        public static void SortDatenTabelle(int rows, int columns)
        {
            string[][] result = new string[5][];
            for(int i = 0; i < result.Length; i++)
            {
                result[i] = new string[columns];
                
            }
        }
        public static int AddColumn(string[][] table, int columns, string headline, string[] values)
        {

        } 
        
  
    }
}
