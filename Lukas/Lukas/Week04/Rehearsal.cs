using System;
namespace Lukas.Week04
{
    public class Rehearsal
    {
        public Rehearsal()
        {
        }

        public static void Start()
        {
            Console.WriteLine("3 + 2 + 1=" + Sum(3));
            Console.WriteLine("10 + ... + 1=" + Sum(10));

            Console.WriteLine("3 + 2 + 1=" + SumRec(100));
            Console.WriteLine("10 + ... + 1=" + SumRec(10));

            int[] data = new int[] { 10, 20, 5, 3, 8, 1, 0 };

            Console.WriteLine("Recursive sum of array: " + Sum(data));


            printDirectory("/Users/lukasaichbauer/Projects/", "");
            Console.WriteLine("FINISHED");
        }

        static long processed = 0;

        static void printDirectory(String directory, String indents)
        {
            try
            {
                foreach (var file in Directory.GetFiles(directory))
                {
                    //FileInfo f = new FileInfo(file);

                    //Console.WriteLine(indents + f.Name + " " + f.Length);
                    processed++;
                }
                foreach (var file in Directory.GetDirectories(directory))
                {
                    if(file == directory)
                    {
                        Console.WriteLine("ERRROR");
                    }
                    //DirectoryInfo f = new DirectoryInfo(file);
                    //Console.WriteLine(indents + f.Name);
                    printDirectory(file, indents + "->");
                    processed++;
                }
                if(processed % 10000 == 0)
                {
                    Console.WriteLine("Processed: " + processed);
                }
            } catch(Exception exc)
            {
                //Console.WriteLine(indents + directory);
            }
        }

        static int Sum(int number)
        {
            int sum = 0;
            for (int i = 0; i <= number; i++)
            {
                sum += i;
            }
            return sum;
        }

        static int SumRec(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            return number + SumRec(number - 1);
        }

        static int Sum(int[] array)
        {
            return Sum(array, 0);
        }

        static int Sum(int[] array, int index)
        {
            if(index == array.Length)
            {
                return 0;
            }
            return array[index] + Sum(array, index + 1);
        }
    }
}

