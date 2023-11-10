using System.Text.RegularExpressions;

namespace Niklas.Week07.Selbsttest
{
    internal class RegexTask
    {
        public static void Start()
        {
            string text = "Heute der 19.10.2021 wird ein sehr guter Tag. Zwar gibt es sowas wie einen Test, den 14 Leute schreiben, aber das ist doch egal!";

            Regex(text);
            Console.WriteLine();
            //Regex2();
        }
        public static void Regex(string text)
        {
            Regex regex1 = new Regex("[a-c]");
            Regex regex2 = new Regex("[f-z]");
            Regex regex3 = new Regex("[1-5]");
            Regex regex4 = new Regex("[4-9]");
            string text1 = (regex1.Replace(text, "X"));
            string text2 = (regex2.Replace(text1, "Y"));
            string text3 = (regex3.Replace(text2, "a"));
            Console.WriteLine(regex4.Replace(text3, "b"));
        }
        public static void Regex2()
        {
            string regex = "";
            Console.WriteLine(System.Text.RegularExpressions.Regex.IsMatch("abc100A", regex));
            Console.WriteLine(System.Text.RegularExpressions.Regex.IsMatch("Abc100A", regex));
            Console.WriteLine(System.Text.RegularExpressions.Regex.IsMatch("luke010A", regex));
            Console.WriteLine(System.Text.RegularExpressions.Regex.IsMatch("test101ABCDE", regex));
            Console.WriteLine(System.Text.RegularExpressions.Regex.IsMatch("test1ABCDE", regex));
        }
    }
}
