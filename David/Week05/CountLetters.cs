using System;
using Ressources;
namespace David.Week05
{
	public class CountLetters
	{
		public static void Start()
		{

            // Text zu charArr
            // new Arr
            // schleife zählen


            string marie = StringRessources.getText();
            Console.WriteLine("This is the text of Marie Curie....");

            int[] count = CountLetter(marie);
            PrintResult(count);

        }


        public static int[] CountLetter(string text)
        {
            int[] count = new int[char.MaxValue];
            for (int i = 0;  i < text.Length;  i++)
            {
                char c = text[i];
                ++count[c];
            }
         
            return count;
        }
        
        public static void PrintResult(int[] count)
        {
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0)
                {
                    char c = (char)i;
                    Console.WriteLine(c + " " + count[i]);
                }
            }
        }

        
    }
}



