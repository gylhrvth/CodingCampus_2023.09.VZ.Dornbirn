using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week05
{
    internal class DataTabular
    {
        public static void Start()
        {
            String[] firstName = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
            String[] lastName = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
            int[] age = { 40, 78, 5, 18, 81 };
            String[] place = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
            float[] distanceFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("| FirstName       | LastName     | Age | Place          | Distance   |");
            Console.WriteLine("----------------------------------------------------------------------");
            for (int i = 0; i < firstName.Length; i++)
            {
                Console.WriteLine($"| {firstName[i], -15} | {lastName[i] ,-12} | {age[i], -3} | {place[i], -14} | {distanceFromCapital[i], -10} |");
            }

            Console.WriteLine("----------------------------------------------------------------------");
        }
    }
}

