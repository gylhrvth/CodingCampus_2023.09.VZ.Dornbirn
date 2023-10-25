using System;


namespace Erik.Week05
{
    public class PointOutAWord
    {
        public static void Start()
        {
            PointOut("Hesse");
        }
        public static void PointOut(String wordToPointOut)
        {
            String randomText = Ressources.StringRessources.getHesse();
            String printWord = randomText.Replace(wordToPointOut,wordToPointOut.ToUpper());
            Console.WriteLine(printWord);
        }
    }
}
