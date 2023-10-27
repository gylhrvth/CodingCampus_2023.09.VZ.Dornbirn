using System;
using Ressources;

namespace Erik.Week05
{
    public class SearchingForWord
    {
        public static void Start()
        {
            String randomText = StringRessources.getHesse();
            SearchForWord(randomText, "Hesse");
        }
        
        public static void SearchForWord(String text, String wordToSearch)
        {

            int wordCounter = 0;
            int index = text.IndexOf(wordToSearch);

            while (index != -1)
            {
                wordCounter++;
                Console.Write("Word counter: " + wordCounter + "\n>>>at the position: " + index + "\n" + "");
                index = text.IndexOf(wordToSearch, index + 1);
            }
            if (wordCounter == 0)
            {
                Console.WriteLine("No word was found!");
            }
        }
    }
}
