using Ressources;

namespace Fabian.Week05
{
    public class Hesse
    {
        public static void Start()
        {
            // SearchForWord("Hesse", StringRessources.getHesse());
            // Console.WriteLine(SetWordInTextToUpper("Hesse", StringRessources.getHesse()););
        }

        public static void SearchForWord(String word, String text)
        {
            int count = 0;

            int index = text.IndexOf(word);

            while (index != -1)
            {
                count++;
                Console.WriteLine("the word {0} is in the text at index {1}.", word, index);
                index = text.IndexOf(word, index + 1);
            }

            if(count == 1)
            {
                Console.WriteLine("the word {0} is {1} time in the text.", word, count);
            }
            else
            {
                Console.WriteLine("the word {0} is {1} times in the text.", word, count);
            }

           
        }

        public static String SetWordInTextToUpper(String word, String text)
        {          

            text = text.Replace(word, word.ToUpper());
            
            return text;
        }

    }

}
