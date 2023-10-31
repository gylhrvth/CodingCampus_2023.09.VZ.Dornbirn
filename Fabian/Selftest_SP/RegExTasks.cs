using System;
using System.Text.RegularExpressions;

namespace Fabian.Selftest_SP
{
    public class RegExTasks
    {
        public static void Start()
        {
            string text = "Heute der 19.10.2021 wird ein sehr guter Tag.Zwar gibt es sowas wie einen Test, den 14 Leute schreiben, aber das ist doch egal!";
            Console.WriteLine(ReplaceText(text));
            Console.WriteLine();

            RegExExamples();
        }
        public static string ReplaceText(string text)
        {
            text = Regex.Replace(text, "[a-c]", "X");
            text = Regex.Replace(text, "[f-z]", "Y");
            text = Regex.Replace(text, "[1-5]", "a");
            text = Regex.Replace(text, "[4-9]", "b");

            return text;
        }
        public static void RegExExamples()
        {
            string regex = "^[a-z]{3,}[1-9][0-9]{2}[A-Z]+$";

            Console.WriteLine(Regex.IsMatch("abc100A", regex));
            Console.WriteLine(Regex.IsMatch("Abc100A", regex));
            Console.WriteLine(Regex.IsMatch("luke010A", regex));
            Console.WriteLine(Regex.IsMatch("test101ABCDE", regex));
            Console.WriteLine(Regex.IsMatch("test1ABCDE", regex));
        }
    }
}
