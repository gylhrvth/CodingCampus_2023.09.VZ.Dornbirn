using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabienne.Week05
{
    internal class AbAufgabeData //String ykyk
    {
        public static void Start()
        {
            String[] firstName = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
            String[] lastName = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
            int[] age = { 40, 78, 5, 18, 81 };
            String[] place = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
            float[] distanceFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };

            DataTabelle(firstName, lastName, age, place, distanceFromCapital);
        }

        public static void DataTabelle(String[] firstName, String[] lastName, int[] age, String[] place, float[] distanceFromCapital)
        {


            Console.WriteLine("____________________________________________________________");
            
            for (int i = 0; i < firstName.Length; i++)
            {
                //Console.WriteLine(firstName[i] + " " + lastName[i] + " " + age[i] + " " + place[i] + " " + distanceFromCapital[i]);

                Console.WriteLine("{0} | {1} | {2} | {3} | {4} |", firstName[i], lastName[i], age[i], place[i], distanceFromCapital[i]);
                Console.WriteLine("____________________________________________________________");


            }

        }
        public static int GetMaxLenght(String[] MaxLength)
        {
            int max = 0;

            for (int i = 0; i > MaxLength.Length; i++)
            {

            }
            return 0;
        }
    }
}
