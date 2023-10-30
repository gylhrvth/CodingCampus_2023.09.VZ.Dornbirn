using Ressources;
using System.Text;
using System.Text.RegularExpressions;
using static Fabian.Week02.ConsoleInput;
using static Fabian.Week05.StringTasksToEmail;

namespace Fabian.Week05
{
    public class StringTasks
    {
        public static void Start()
        {
            //Console.WriteLine(ReplaceAll("Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!", "wird", "war und ist"));
            //ReplaceAll2("Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!");
            //ReplaceAll3("749813247132984712039487123049871204398712039487");
            //Console.WriteLine(LongestCommonSubstring());

            //String[] words = WordSplit("Heute wird ein guter Tag! Heute wird der beste Tag überhaupt! Heute wird ein spitzen super Tag!", "Tag");
            //Console.WriteLine(string.Join("\n", words));
            //Console.WriteLine("longest common substring: " + LongestCommonSubstring());

            //String[] words2 = WordSplitAndSort("Heute wird ein guter Tag! Heute wird der beste Tag überhaupt! Heute wird ein spitzen super Tag!");
            //Console.WriteLine("[{0}]", string.Join(" ", words2));

            //Console.WriteLine(WordAnalysisLongestWord(StringRessources.getHesse(), StringRessources.getText()));
            //Console.WriteLine(WordAnalysisShortestWord(StringRessources.getHesse(), StringRessources.getText()));

            //String[] words3 = WordAnalysisAlphabeticallyUnique(StringRessources.getHesse(), StringRessources.getText());
            //Console.WriteLine("[{0}]", string.Join(", ", words3));

            //Console.WriteLine("factorial = " + RecursiveFactorial(10));

            Console.WriteLine("Permutations: \n" + Permutation("ABCD"));
        }

        public static String ReplaceAll(String text, String oldValue, String newValue)
        {
            text = text.Replace(oldValue, newValue);

            return text;
        }
        public static void ReplaceAll2(String text)
        {
            String text1 = Regex.Replace(text, "[a-z]", "");
            Console.WriteLine(text1);

            String text2 = Regex.Replace(text, "[A-Z]", "");
            Console.WriteLine("\n" + text2);

            String text3 = text.Replace(" ", "");
            Console.WriteLine("\n" + text3);

            String text4 = text.Replace("!", "");
            Console.WriteLine("\n" + text4);
        }
        public static void ReplaceAll3(String text)
        {
            String text1 = Regex.Replace(text, "[0-9]", "");
            Console.WriteLine(text1);

            String text2 = Regex.Replace(text, "[1-9]", "");
            Console.WriteLine("\n" + text2);

            String text3 = Regex.Replace(text, "[2-4]", "");
            Console.WriteLine("\n" + text3);

            String text4 = Regex.Replace(text, "[1-36-9]", "");
            Console.WriteLine("\n" + text4);
        }
        public static String LongestCommonSubstring(String text1 = "", String text2 = "")
        {
            String longerStr;
            String shorterStr;

            if (text1 == "")
            {
                text1 = ReadString("Enter text 1: ", "^[a-zA-Z ]+$");
            }
            if (text2 == "")
            {
                text2 = ReadString("Enter text 2: ", "^[a-zA-Z ]+$");
            }

            if (text1.Length > text2.Length)
            {
                longerStr = text1;
                shorterStr = text2;
            }
            else
            {
                longerStr = text2;
                shorterStr = text1;
            }

            int maxLength = 0;
            string longestSub = "";


            for (int i = 0; i < shorterStr.Length; i++)
            {
                for (int j = i + 1; j <= shorterStr.Length; j++)
                {
                    String subString = shorterStr.Substring(i, j - i);

                    if (longerStr.Contains(subString) && subString.Length > maxLength)
                    {
                        maxLength = subString.Length;
                        longestSub = subString;
                    }
                }
            }

            return longestSub;

        }
        public static String[] WordSplit(String text, String seperator)
        {
            String[] words = text.Split(seperator);
            StringBuilder sb = new();

            foreach (string word in words)
            {
                sb.AppendLine(word);
            }
            String[] result = sb.ToString().Split(seperator);

            return result;
        }
        public static String[] WordSplitAndSort(String text)
        {
            String[] words = text.Split();
            StringBuilder sb = new();

            words = BubbleSortStringAlphabeticallyASC(words);

            foreach (string word in words)
            {
                sb.Append(word);
                sb.Append(", ");
            }
            String[] result = sb.ToString().Split();

            return result;
        }
        public static String WordAnalysisShortestWord(String text1, String text2)
        {
            String text = text1 + " " + text2;

            text = text.Replace(',', ' ');
            text = text.Replace('\n', ' ');
            text = text.Replace('.', ' ');
            text = text.Replace('-', ' ');

            string[] words = text.Split(' ');

            String min = words[0];

            foreach (string word in words)
            {
                if (word.Length < min.Length)
                {
                    min = word;
                }
            }

            return min;
        }
        public static String WordAnalysisLongestWord(String text1, String text2)
        {
            String text = text1 + " " + text2;

            text = text.Replace(',', ' ');
            text = text.Replace('\n', ' ');
            text = text.Replace('.', ' ');
            text = text.Replace('-', ' ');

            string[] words = text.Split(' ');

            String max = words[0];

            foreach (string word in words)
            {
                if (word.Length > max.Length)
                {
                    max = word;
                }
            }

            return max;
        }
        public static String[] WordAnalysisAlphabetically(String text1, String text2)
        {
            String text = text1 + " " + text2;

            text = text.Replace(',', ' ');
            text = text.Replace('\n', ' ');
            text = text.Replace('.', ' ');
            text = text.Replace('-', ' ');

            string[] words = text.Split();

            words = BubbleSortAlphabetically(words, true);

            return words;
        }
        public static String[] WordAnalysisAlphabeticallyUnique(String text1, String text2)
        {
            String text = text1 + " " + text2;

            text = text.Replace(',', ' ');
            text = text.Replace('\n', ' ');
            text = text.Replace('.', ' ');
            text = text.Replace('-', ' ');

            string[] words = text.Split();
            string[] sorted = new string[words.Length];

            int i = 0;
            foreach (string word in words)
            {
                if (!sorted.Contains(word))
                {
                    sorted[i++] = word;
                }
            }

            sorted = BubbleSortAlphabetically(sorted, true);

            return sorted;
        }
        public static int RecursiveFactorial(int n)
        {
            if (n == 1) return 1;
            return n * RecursiveFactorial(n - 1);
        }
        public static String Permutation(String text)
        {
            return text;            
        }
    }
}
