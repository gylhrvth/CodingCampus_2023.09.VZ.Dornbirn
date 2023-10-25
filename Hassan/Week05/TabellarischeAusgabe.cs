using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hassan.Week05
{
    public class TabellarischeAusgabe
    {
        public static void Start()
        {
            string[] firstName = { "Alfons", "Beatrix-Eleonoro", "Cecil", "Daniel", "Elmar" };
            string[] lastName = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
            int[] age = { 40, 78, 5, 18, 81 };
            string[] place = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
            float[] distanceFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };

            PrintTable(firstName, lastName, age, place, distanceFromCapital);

        }
        static void PrintTable(string[] firstNames, string[] lastNames, int[] ages, string[] places, float[] distances)
        {
            // if the length of the highest value is bigger than the length of the name of the column = take the length of the highest value
            // else = take the length of the name of the column
            int firstNameLength = Math.Max(9,GetMaxLengthS(firstNames));
            int lastNameLength = Math.Max(8,GetMaxLengthS(lastNames));
            int ageMaxLength = Math.Max(3,GetMaxLengthI(ages));
            int placeMacLenght = Math.Max(5,GetMaxLengthS(places));
            int distanceMaxLenghth = Math.Max(21,GetMaxLengthF(distances));

            int totalLength = firstNameLength + lastNameLength + ageMaxLength + placeMacLenght + distanceMaxLenghth + 12; //12 for the seperators
            string line = new string('-', totalLength);

            //printtabel
            Console.WriteLine(line);
            Console.WriteLine($"Firstname  {new string(' ', firstNameLength - 9)} | Lastname{new string(' ', lastNameLength - 8)} | Age{new string(' ', ageMaxLength - 3)} | Place{new string(' ', placeMacLenght - 5)} | Distance from Capital");
            Console.WriteLine(line);
            for (int i = 0; i < firstNames.Length; i++)
            {
                Console.WriteLine($"{firstNames[i]}{new string(' ', firstNameLength - firstNames[i].Length)} | {lastNames[i]}{new string(' ', lastNameLength - lastNames[i].Length)} | {ages[i]}{new string(' ', ageMaxLength - ages[i].ToString().Length)} | {places[i]}{new string(' ', placeMacLenght - places[i].Length)} | {distances[i]}");

            }

        }

        public static int GetMaxLengthS(String[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > max)
                {
                    max = arr[i].Length;
                }
            }
            return max;
        }


        public static int GetMaxLengthI(int[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].ToString().Length > max)
                {
                    max = arr[i].ToString().Length;
                }
            }
            return max;
        }

        public static int GetMaxLengthF(float[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].ToString().Length > max)
                {
                    max = arr[i].ToString().Length;
                }
            }
            return max;
        }

    }
}
