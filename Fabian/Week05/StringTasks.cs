using Ressources;
using System.Globalization;
using System.Runtime.ExceptionServices;
using static Fabian.Week02.ConsoleInput;

namespace Fabian.Week05
{
    public class StringTasks
    {
        public static void Start()
        {
            String[] names = new String[] {
                "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo",
                "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren"
            };
            //Console.WriteLine("[{0}]", string.Join(", ", BubbleSortIndex(names, 2, true)));

            // PrintCountedChars(StringRessources.getText());

            
        }

        public static String[] MakeACopy(String[] array)
        {
            String[] copy = new String[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                copy[i] = array[i]; 
            }

            return copy;
        }


        public static String[] BubbleSortStringLengthASC(String[] arr)
        {
            String[] sorted = MakeACopy(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (sorted[j].Length > sorted[j + 1].Length)
                    {
                        (sorted[j], sorted[j + 1]) = (sorted[j + 1], sorted[j]);
                    }
                }
            }
            return sorted;
        }
        public static String[] BubbleSortStringLengthDESC(String[] arr)
        {
            String[] sorted = MakeACopy(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (sorted[j].Length < sorted[j + 1].Length)
                    {
                        (sorted[j], sorted[j + 1]) = (sorted[j + 1], sorted[j]);
                    }
                }
            }
            return sorted;
        }      
        public static String[] BubbleSortStringAlphabeticallyASC(String[] arr)
        {
            String[] sorted = MakeACopy(arr);

            for (int i = 0; i < sorted.Length; i++)
            {
                for (int j = 0; j < sorted.Length - i - 1; j++)
                {
                    if (string.Compare(sorted[j], sorted[j + 1], CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace) > 0 )
                    {
                        (sorted[j], sorted[j + 1]) = (sorted[j + 1], sorted[j]);
                    }
                }
            }
            return sorted;
        }
        public static String[] BubbleSortStringAlphabeticallyDESC(String[] arr)
        {
            String[] sorted = MakeACopy(arr);

            for (int i = 0; i < sorted.Length; i++)
            {
                for (int j = 0; j < sorted.Length - i - 1; j++)
                {
                    if (string.Compare(sorted[j], sorted[j + 1], CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace) < 0)
                    {
                        (sorted[j], sorted[j + 1]) = (sorted[j + 1], sorted[j]);
                    }
                }
            }
            return sorted;
        }
        public static String[] BubbleSortLength(String[] arr, bool asc)
        {
            if (asc)
            {
                return BubbleSortStringLengthASC(arr);
            }
            else
            {
                return BubbleSortStringLengthDESC(arr);
            }
           
        }
        public static String[] BubbleSortAlphabetically(String[] arr, bool asc)
        {
            if (asc)
            {
                return BubbleSortStringAlphabeticallyASC(arr);
            }
            else
            {
                return BubbleSortStringAlphabeticallyDESC(arr);
            }
            
        }
        public static String[] BubbleSortIndex(String[] arr, int index, bool asc)
        {
            String[] sorted = MakeACopy(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
  
                    if (index >= sorted[j + 1].Length)
                    {
                        Console.WriteLine("The index was too high!");
                        return sorted;
                    }

                    char char1 = sorted[j][index];
                    char char2 = sorted[j + 1][index];

                    if (asc && string.Compare(char1.ToString(), char2.ToString(), CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace) > 0 || !asc && string.Compare(char1.ToString(), char2.ToString(), CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace) < 0)
                    {
                        (sorted[j], sorted[j + 1]) = (sorted[j + 1], sorted[j]);
                    }
                }
            }
            return sorted;
        }


        public static String ReverseWord()
        {
            String text = ReadString(">>>");
            char[] textToChars = text.ToCharArray();
            char[] charArray = new char[textToChars.Length];

            for (int i = 0; i < textToChars.Length; i++)
            {
                charArray[i] = textToChars[textToChars.Length - 1 - i];
            }
            String reverse = new String(charArray);

            return reverse;
        }
        public static String RandomizeWord()
        {
            Random random = new Random();

            String text = ReadString(">>>");
            char[] textToChars = text.ToCharArray();

            for (int i = 0; i < textToChars.Length; i++)
            {
                int index = random.Next(i, textToChars.Length);

                (textToChars[i], textToChars[index]) = (textToChars[index], textToChars[i]);
            }

            String randomize = new String(textToChars);

            return randomize;
        }
        public static void PrintCountedChars(String text)
        {
            int[] chars = new int[300];

            foreach (char c in text)
            {
                if((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9'))
                {
                    chars[c]++;
                }
            }
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] > 0)
                {
                    Console.WriteLine($"{(char)i} : {chars[i]}");
                }

            }
        }

        
    }
}
