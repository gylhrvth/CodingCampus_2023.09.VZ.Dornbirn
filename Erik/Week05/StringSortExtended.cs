using System;

namespace Erik.Week05
{
    public class StringSortExtended
    {
        public static void StartStringSortExtended()
        {
            string[] names = Week05.StringSort.UnsortedNames();
            SortNamesAlgo(names, false);
            Console.WriteLine("Names ascending:\n[{0}]", string.Join(", ", names));
        }

        public static void SortNamesAlgo(String[] names, bool compareison)
        {
            int n = names.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    int length1 = names[j].Length;
                    int length2 = names[j + 1].Length;

                    if (length1 > length2 && compareison)
                    {
                        String tmp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = tmp;
                    }
                    else if (length1 < length2 && !compareison)
                    {
                        String tmp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = tmp;
                    }
                }
            }
        }

    }

}
