using Ressources;

namespace Hassan.Week05;

    public class TextExcs
    {

        public static void Start()
        {
            string text = StringRessources.getHesse();
            string searchString = "Hesse";

            int count = 0;
            int index = text.IndexOf(searchString);
            while (index != -1)
            {
                count++;
                Console.WriteLine("Das Wort 'Hesse' gefunden an Stelle " + index);
                index = text.IndexOf(searchString, index + 1);
            }
            Console.WriteLine("Das Wort 'Hesse' kommt " + count + " Mal im Text vor.");
        }
    }





