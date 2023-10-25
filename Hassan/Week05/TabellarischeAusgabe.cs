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
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-5}|{3,-20}|{4,-20}|", "Vorname", "Nachname", "Alter", "Ort", "Entfernung von Wien (km)");
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            for (int i = 0; i < firstNames.Length; i++)
            {
                Console.WriteLine("|{0,-20}|{1,-20}|{2,-5}|{3,-20}|{4,-20}|", firstNames[i], lastNames[i], ages[i], places[i], distances[i]);
            }

            Console.WriteLine("----------------------------------------------------------------------------------------------");
        }

    }
}
