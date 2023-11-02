using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Michael.Week02
{
    internal class StringExercises
    {

        public static Random rnd = new Random();


        public static String[] names = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };


        public static void Start()
        {
            var watchNames = new System.Diagnostics.Stopwatch();
            var watchNumbers = new System.Diagnostics.Stopwatch();


            for (int i = 500; i < 10000; i += 100)
            {
                string[] words = RandomWords(i, 100, 200);
                int[] numbers = Arrays.crazyArray(i, 100, 200);

                watchNames.Start();
                words = sortNames(words, true, false);
                watchNames.Stop();

                watchNumbers.Start();
                Arrays.bubbleSort2(numbers);
                watchNumbers.Stop();

                Console.WriteLine($"{i,10}: {watchNames.ElapsedMilliseconds, 10}ms {watchNumbers.ElapsedMilliseconds,10}ms {watchNames.ElapsedMilliseconds/ watchNumbers.ElapsedMilliseconds, 5}");
            }
        }


        public static string RandomWord(int length)
        {
            char[] word = new char[length];

            for (int i = 0; i < length; i++)
            {
                word[i] = (char)rnd.Next(33, 123);
            }

            return String.Join("", word);
        }


        public static string[] RandomWords(int amount, int minLength, int maxLength)
        {
            string[] words = new string[amount];

            for (int i = 0; i < amount; i++)
            {
                words[i] = RandomWord(rnd.Next(minLength, maxLength));
            }

            return words;
        }


        public static char[] makeACopyAltChar(char[] original)
        {
            char[] myArray = new char[original.Length];

            for (int i = 0; i < original.Length; i++)
            {
                myArray[i] = original[i];
            }
            return myArray;
        }


        public static void printCharArray(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }


        public static string[] sortNames(string[] toSort, bool lexi = false, bool descending = false) 
        {
            if (lexi)
            {
                if (descending)
                {
                    return sortLexiDescending(toSort);
                }
                else
                {
                    return sortLexiAscending(toSort);
                }
            }
            else
            {
                if (descending)
                {
                    return sortLengthDescending(toSort);
                }
                else
                {
                    return sortLengthAscending(toSort);
                }
            }
        }


        public static string[] sortLengthAscending(string[] toSort)
        {
            string[] sortedArray = new string[toSort.Length];

            sortedArray = toSort;
            bool hadToSwap = true;
            string first = " ";

            while (hadToSwap)
            {
                hadToSwap = false;

                for (int i = 0; i < toSort.Length - 1; i++)
                {
                    if (sortedArray[i].Length > sortedArray[i + 1].Length)
                    {
                        first = sortedArray[i];
                        sortedArray[i] = sortedArray[i + 1];
                        sortedArray[i + 1] = first;
                        hadToSwap = true;
                    }
                }
            }
            return sortedArray;
        }


        public static string[] sortLengthDescending(string[] toSort)
        {
            string[] sortedArray = new string[toSort.Length];

            sortedArray = toSort;
            bool hadToSwap = true;
            string first = " ";

            while (hadToSwap)
            {
                hadToSwap = false;

                for (int i = 0; i < toSort.Length - 1; i++)
                {
                    if (sortedArray[i].Length < sortedArray[i + 1].Length)
                    {
                        first = sortedArray[i];
                        sortedArray[i] = sortedArray[i + 1];
                        sortedArray[i + 1] = first;
                        hadToSwap = true;
                    }
                }
            }
            return sortedArray;
        }


        public static string[] sortLexiAscending(string[] toSort, int index = 0)
        {
            string[] sortedArray = new string[toSort.Length];

            sortedArray = toSort;
            bool hadToSwap = true;
            string first = " ";

            while (hadToSwap)
            {
                hadToSwap = false;

                for (int i = 0; i < toSort.Length - 1; i++)
                {
                    if (index >= sortedArray[i].Length)
                    {
                        Console.WriteLine("not all names are long enough for this index, sorry");
                        return sortedArray;
                    }
                    try
                    {
                        if (sortedArray[i].Substring(index).CompareTo(sortedArray[i + 1].Substring(index)) > 0)
                        {
                            first = sortedArray[i];
                            sortedArray[i] = sortedArray[i + 1];
                            sortedArray[i + 1] = first;
                            hadToSwap = true;
                        }
                    }
                    catch 
                    {
                        Console.WriteLine("not all names are long enough for this index, sorry. we won't continue sorting.");
                        return sortedArray;
                    }

                }
            }
            return sortedArray;
        }


        public static string[] sortLexiDescending(string[] toSort)
        {
            string[] sortedArray = new string[toSort.Length];

            sortedArray = toSort;
            bool hadToSwap = true;
            string first = " ";

            while (hadToSwap)
            {
                hadToSwap = false;

                for (int i = 0; i < toSort.Length - 1; i++)
                {
                    if (sortedArray[i].CompareTo(sortedArray[i + 1]) < 0)
                    {
                        first = sortedArray[i];
                        sortedArray[i] = sortedArray[i + 1];
                        sortedArray[i + 1] = first;
                        hadToSwap = true;
                    }
                }
            }
            return sortedArray;
        }


        public static void switchChar(char[] array, int index1, int index2)
        {
            char temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        
        public static string reverseUserString()
        {
            string userInput = "";

            while (true)
            {
                Console.WriteLine("what string do you want reversed?");
                try
                {
                    userInput = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(userInput))
                    {
                        Console.WriteLine("please actually enter something");
                    }
                    else
                    {
                        Console.WriteLine("ty for your input");
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("weird input, let's try again");
                }
            }

            char[] userInputArray = userInput.ToArray();
            char[] userInputArrayTemp = makeACopyAltChar(userInputArray);

            for (int i = 0; i < userInputArray.Length; i++)
            {
                userInputArray[i] = userInputArrayTemp[userInputArray.Length - i - 1];
            }

            printCharArray(userInputArray);
            return String.Join("", userInputArray);

        }
          

        public static string randomizeUserString()
        {
            string userInput = "";

            while (true)
            {
                Console.WriteLine("what string do you want shuffled?");
                try
                {
                    userInput = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(userInput))
                    {
                        Console.WriteLine("please actually enter something");
                    }
                    else
                    {
                        Console.WriteLine("ty for your input");
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("weird input, let's try again");
                }
            }

            char[] userInputArray = userInput.ToArray();

            for (int i = 0; i < userInputArray.Length; i++)
            {
                switchChar(userInputArray, i, rnd.Next(i, userInputArray.Length));
            }

            printCharArray(userInputArray);
            return String.Join("", userInputArray);

        }


        public static void CountLetters()
        {
            int[] lettersAmount = new int[400];
            Console.WriteLine("enter a string");
            char[] stringArray = Console.ReadLine().ToArray();


            for (int i = 0; i < lettersAmount.Length; i++)
            {
                lettersAmount[i] = 0;
            }


            foreach (char c in stringArray)
            {
                lettersAmount[c]++;
            }


            for (int i = 0; i < lettersAmount.Length; i++)
            {
                if (lettersAmount[i] != 0)
                {
                    Console.WriteLine((char)i + ":  " + lettersAmount[i]);
                }

            }
        }


        public static void DataTable()
        {
            String[] firstName = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
            String[] lastName = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
            int[] age = { 40, 78, 5, 18, 81 };
            String[] place = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
            float[] distanceFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };

            Console.WriteLine($"{"first name", 20}|{"last name", 20}|{"age",4}|{"place",20}|{"distance from capital",20}");
            Console.WriteLine("--------------------|--------------------|----|--------------------|---------------------");

            for (int line = 0; line < firstName.Length; line++)
            {
                Console.WriteLine($"{firstName[line],20}|{lastName[line],20}|{age[line],4}|{place[line],20}|{distanceFromCapital[line],20}");
            }
        }


        public static bool EmailMatching(string email)
        {
            string regex = "^[a-zA-Z][a-zA-Z0-9]+[.]?[a-zA-Z0-9]*@[a-zA-Z0-9]+[.][a-zA-Z0-9]{2,3}$";

            System.Text.RegularExpressions.Match m = System.Text.RegularExpressions.Regex.Match(email, regex);

            return m.Success;
        }


        public static int countAmountOf(string text, string word, int discarded = 0)
        {
            int index = text.ToLower().IndexOf(word.ToLower());
            discarded += index;

            if (index == -1) 
            {
                return 0;
            }
            else
            {
                Console.Write(index + discarded + ", ");
                return 1 + countAmountOf(text.Substring(index + 1), word, discarded);
            }
        }


        public static int countAmountOfShort(string text, string word)
        {
            return text.ToLower().Split(word.ToLower()).Length - 1;
        }


        public static string makeUpperCase(string text, string word)
        {
            return text.ToLower().Replace(word.ToLower(), word.ToUpper());
        }


        public static void replaceExercises()
        {
            string string1 = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
            string string2 = "749813247132984712039487123049871204398712039487";

            Console.WriteLine(string1.Replace("wird","war und ist") + "\n");

            string workable = string1;
            for (int i = 97; i < 123; i++)
            {
                workable = workable.Replace("" + (char)i, "");
            }
            Console.WriteLine(workable);

            workable = string1;
            for (int i = 65; i < 91; i++)
            {
                workable = workable.Replace("" + (char)i, "");
            }
            Console.WriteLine(workable);

            workable = string2;
            for (int i = 0; i < 10; i++)
            {
                workable = workable.Replace("" + i, "");
            }
            Console.WriteLine(workable);

            workable = string2;
            for (int i = 1; i < 10; i++)
            {
                workable = workable.Replace("" + i, "");
            }
            Console.WriteLine(workable);

            workable = string2;
            for (int i = 2; i < 5; i++)
            {
                workable = workable.Replace("" + i, "");
            }
            Console.WriteLine(workable);

            workable = string2;
            for (int i = 1; i < 4; i++)
            {
                workable = workable.Replace("" + i, "");
            }
            for (int i = 6; i < 10; i++)
            {
                workable = workable.Replace("" + i, "");
            }
            Console.WriteLine(workable);
        }


        public static string longestCommonWord(string string1, string string2)
        {
            char[] seperators = { '.', '!', '?', ',', ';', ' '};
            string[] words1 = string1.Split(seperators);
            string[] words2 = string2.Split(seperators);

            string currentMax = "";

            foreach(string word in words1)
            {
                if (word.Length > currentMax.Length && words2.Contains(word))
                {
                    currentMax = word;
                }
            }
            return currentMax;
        }

        
        public static string longestCommonSubstring(string string1, string string2)
        {
            int currentMaxIndex = -1;
            int currentMaxLength = 0;

            for (int i = 0; i < string1.Length; i++)
            {
                for (int j = 0; j < string2.Length; j++)
                {
                    if (string1[i] == string2[j])
                    {
                        int remainingLength = Math.Min(string1.Substring(i).Length, string2.Substring(j).Length);

                        for (int k = 1; k < remainingLength; k++)
                        {
                            if (string1[i + k] != string2[j + k] || k == remainingLength - 1)
                            {
                                if (k > currentMaxLength)
                                {
                                    currentMaxLength = k;
                                    currentMaxIndex = i;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            if (currentMaxIndex == -1)
            {
                return "";
            }
            else
            {
                Console.WriteLine(currentMaxLength);
                Console.WriteLine(currentMaxIndex);
                return string1.Substring(currentMaxIndex, currentMaxLength);
            }
            
        }

        
        public static string[] wordSplit(string text, string seperator)
        {
            int index = text.IndexOf(seperator);

            //end of recursion
            if (index == -1)
            {
                return new string[] { text };
            } 

            //create recursive split half and full return array
            string[] secondHalf = wordSplit(text.Substring(index + seperator.Length), seperator);
            string[] returnStrings = new string[secondHalf.Length + 1];

            //add new element and old elements to full return string
            returnStrings[0] = text.Substring(0, index);

            for (int i = 0; i < secondHalf.Length; i++)
            {
                returnStrings[i + 1] = secondHalf[i];
            }

            return returnStrings;
        }


        public static string insertAtIndex(string word, char insert, int index)
        {
            char[] wordCharacters = new char[word.Length + 1];

            for (int i = 0; i < index; i++)
            {
                wordCharacters[i] = word[i];
            }

            wordCharacters[index] = insert;

            for (int i = index + 1; i < wordCharacters.Length; i++)
            {
                wordCharacters[i] = word[i - 1];
            }

            return new string(wordCharacters);
        }


        public static string[] permutate(string input)
        {
            if (input.Length == 1)
            {
                return new string[] { input };
            }

            string[] rightHalf = permutate(input.Substring(1));
            string[] returnString = new string[(rightHalf[0].Length + 1) * rightHalf.Length];

            for (int i = 0; i < rightHalf.Length; i++)
            {
                for (int j = 0; j <= rightHalf[i].Length; j++)
                {
                    returnString[j * rightHalf.Length + i] = insertAtIndex(rightHalf[i], input[0], j);
                }
            }

            return returnString;

        }


    }
}
