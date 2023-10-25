using System;
using Timo.Week03;

namespace Timo.Week05;

public class DataTable
{
    public static void Start()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        string[] firstName = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
        string[] lastName = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
        int[] age = { 40, 78, 5, 18, 81 };
        string[] place = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
        float[] distanceFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };
        string[] origin = { "Austria", "Cuba", "Columbien", "Nigeria", "Hungary" };
        
        int columns = 6;
        bool[] isAlignedLeft = new bool[columns];
        string[][] table = Create2DStringArray(1 + firstName.Length, columns);
        AddColumn(table, isAlignedLeft, 0, "First name", firstName);
        AddColumn(table, isAlignedLeft, 1, "Last name", lastName);
        AddColumn(table, isAlignedLeft, 2, "Age", age);
        AddColumn(table, isAlignedLeft, 3, "Place", place);
        AddColumn(table, isAlignedLeft, 4, "Distance", distanceFromCapital);
        AddColumn(table, isAlignedLeft, 5, "Origin", origin);

        int totalMaxLength = Arrays.ArraySum(MaxLenghtPerColumn(table))+4*columns+1;

        PrintTable(table, isAlignedLeft, totalMaxLength);
    }

    public static int[] MaxLenghtPerColumn(string[][] table)
    {
        int[] maxWidth = new int[table[0].Length];

        for (int i = 0; i < table.Length; i++)
        {
            for (int j = 0; j < table[i].Length; j++)
            {
                if (table[i][j].Length > maxWidth[j])
                {
                    maxWidth[j] = table[i][j].Length;
                }
            }
        }
        return maxWidth;
    }

    public static void PrintTable(string[][] table, bool[] alignLeft, int totalMaxLength)
    {
        string tableTopLine = new string('_', totalMaxLength);
        string tableTopUnderLine = new string('\u203E', totalMaxLength);
        string tableLine = new string('-', totalMaxLength);

        Console.WriteLine(tableTopLine);
        int[] widthPerColum = MaxLenghtPerColumn(table);
        //Console.WriteLine(string.Join(", ", widthPerColum));

        for (int i = 0; i < table.Length; i++)
        {
            for (int j = 0; j < table[i].Length; j++)
            {
                int width = widthPerColum[j];
                if (alignLeft[j])
                {
                    width *= -1;
                }
                string formatString = string.Format("|| {{0,{0}}} ", width);
                Console.Write(formatString, table[i][j]);
            }
            Console.WriteLine("|");
            if (i == 0)
            {
                Console.WriteLine(tableTopUnderLine);
            }
            else
            {
                Console.WriteLine(tableLine);
            }
        }
    }

    public static string[][] Create2DStringArray(int rows, int columns)
    {
        string[][] result = new string[rows][];
        for (int i = 0; i < result.Length; ++i)
        {
            result[i] = new string[columns];
        }
        return result;
    }

    public static void AddColumn(string[][] table, bool[] alignLeft, int column, string headline, string[] values)
    {
        table[0][column] = headline;
        alignLeft[column] = true;
        for (int i = 0; i < values.Length; ++i)
        {
            table[1 + i][column] = values[i];
        }
    }

    public static void AddColumn(string[][] table, bool[] alignLeft, int column, string headline, int[] values)
    {
        table[0][column] = headline;
        alignLeft[column] = false;
        for (int i = 0; i < values.Length; ++i)
        {
            table[1 + i][column] = string.Format("{0}", values[i]);
        }
    }

    public static void AddColumn(string[][] table, bool[] alignLeft, int column, string headline, float[] values)
    {
        table[0][column] = headline;
        alignLeft[column] = false;
        for (int i = 0; i < values.Length; ++i)
        {
            table[1 + i][column] = string.Format("{0:N1}", values[i]);
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Timo.Week05
//{
//    internal class DataTable
//    {
//        public static void Start()
//        {
//            String[] firstNames = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
//            String[] lastNames = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
//            int[] ages = { 40, 78, 5, 18, 81 };
//            String[] places = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
//            float[] distancesFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };

//            PrintTable(firstNames, lastNames, ages, places, distancesFromCapital);
//        }

//        public static void PrintTable(string[] firstNames, string[] lastNames, int[] ages, string[] places, float[] distacesFromCapital)
//        {

//            string[] tableTopLength = { "First name", "Last name", "Age", "Place", "Distances from capital" };

//            int firstNameMax = Math.Max(tableTopLength[0].Length, GetMaxLength(firstNames));
//            int lastNameMax = Math.Max(tableTopLength[1].Length, GetMaxLength(lastNames));
//            int ageMax = Math.Max(tableTopLength[2].Length, GetMaxLength(ages));
//            int placeMax = Math.Max(tableTopLength[3].Length, GetMaxLength(places));
//            int distanceMax = Math.Max(tableTopLength[0].Length, GetMaxLength(distacesFromCapital));

//            int totalMaxLength = firstNameMax + lastNameMax + ageMax + placeMax + distanceMax + 11;
//            Console.WriteLine(totalMaxLength);

//            string tableTopLine = new string('_', totalMaxLength);
//            string tableLine = new string('-', totalMaxLength);

//            Console.WriteLine(tableTopLine);
//            Console.WriteLine("| " + "First name" + " | " + "Last name" + " | " + "Age" + " | " + "Place" + " | " + "Distances from capital" + " |");
//            Console.WriteLine(tableTopLine);
//            for (int i = 0; i < firstNames.Length; i++)
//            {
//                Console.WriteLine("| " + firstNames[i] + " | " + lastNames[i] + " | " + ages[i] + " | " + places[i] + " | " + distacesFromCapital[i] + " |\n" + tableLine);
//            }

//        }

//        public static int GetMaxLength(String[] arr)
//        {
//            int max = 0;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i].Length > max)
//                {
//                    max = arr[i].Length;
//                }
//            }
//            return max;
//        }

//        public static int GetMaxLength(int[] arr)
//        {
//            int max = 0;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i].ToString().Length > max)
//                {
//                    max = arr[i].ToString().Length;
//                }
//            }
//            return max;
//        }

//        public static int GetMaxLength(float[] arr)
//        {
//            int max = 0;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i].ToString().Length > max)
//                {
//                    max = arr[i].ToString().Length;
//                }
//            }
//            return max;
//        }
//    }
//}
