using Ressources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hassan.Week05
{
    public class StringManipulation
    {
        public static void Start()
        {
            

            Console.WriteLine("Willkommen zum Reverseprogramm!!!111");

            string eingabe = Console.ReadLine();

            string umgedreht = RandomizeString(eingabe);

            Console.WriteLine(">>> " + umgedreht);



           // string text = StringRessources.getText();
           // CountAndPrintCharacters(text);



           
        }

        static string ReverseString(string text)
        {
            char[] charArray = text.ToCharArray();
            int length = charArray.Length;

            for (int i = 0; i < length; i++)
            {
                char temp = charArray[i];
                charArray[i] = charArray[length - i - 1];
                charArray[length - i - 1] = temp;
            }
            //Array.Reverse

            return new string(charArray);
        }

        static string RandomizeString(string text)
        {
            // Den String in ein Char-Array aufsplitten
            char[] charArray = text.ToCharArray();

            // Zufällige Anordnung des Char-Arrays
            Random rand = new Random();

            for (int i =0; i < charArray.Length; i++)
            {
                int j = rand.Next(i + 1);
                char temp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = temp;
            }

            // Das zufällige Char-Array in einen String umwandeln
            return new string(charArray);
        }

        static void CountAndPrintCharacters(string text)
        {
            int[] charCount = new int[256];

            foreach (char c in text)
            {
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9'))
                {
                    charCount[c]++;
                }
            }

            for (int i = 0; i < charCount.Length; i++)
            {
                if (charCount[i] > 0)
                {
                    Console.WriteLine($"{(char)i}: {charCount[i]}");
                }
            }
        }

    }
}
