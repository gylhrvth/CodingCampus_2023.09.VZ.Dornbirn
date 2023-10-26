using System;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using static System.Net.Mime.MediaTypeNames;

namespace Erik.Week05
{
    public class SearchingForWord
    {
        public static void Start()
        {
            SearchForWord("Hesse");
        }

        public static void SearchForWord(String wordToSearch)
        {
            String randomText = Ressources.StringRessources.getHesse();
            int wordCounter = 0;
            int index = randomText.IndexOf(wordToSearch);


            while (index != -1)
            {
                wordCounter++;
                Console.Write("Word counter: " + wordCounter + "\n>>>at the position: " + index + "\n" + "");
                index = randomText.IndexOf(wordToSearch, index + 1);
            }
            if (wordCounter == 0)
            {
                Console.WriteLine("No word found!");
            }
        }
    }
}
