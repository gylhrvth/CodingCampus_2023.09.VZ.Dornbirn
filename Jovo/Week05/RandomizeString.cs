using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week05
{
    internal class RandomizeString
    {
        public static Random rand = new Random();
        public static void Start()
        {

            Console.Write("Gebe hier deinen Text ein:");


            string text = Console.ReadLine();
            Console.WriteLine(RandomizeString1(text));


        }

        public static string RandomizeString1(string text)
        {
            char[] arr = text.ToCharArray();
            
            for ( int i = 0; i < arr.Length; i++ )
            {
                int posA = rand.Next(arr.Length);
                int posB = rand.Next(arr.Length);
                char temp = arr[posA];
                arr[posA] = arr[posB];
                arr[posB] = temp;
            }
            return new string(arr);

        }
    }
}
