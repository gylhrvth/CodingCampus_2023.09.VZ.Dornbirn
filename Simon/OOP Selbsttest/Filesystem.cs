using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.OOP_Selbsttest
{
    public class Filesystem
    {
        public static void Start()
        {
            GetbiggestFile(GetPath());

            PrintBiggestFile(GetbiggestFile1(GetPath(), 0, ""));
        }

        public static string GetPath()
        {
            Console.WriteLine("Input your Path:");
            while (true)
            {
                try
                {
                    string userinput = Console.ReadLine();
                    if (File.Exists(userinput) || Directory.Exists(userinput))
                    {
                        return userinput;
                    }
                    else
                    {
                        Console.WriteLine("Please input a valid Path!");
                    }
                }
                catch
                {
                    Console.WriteLine("Please input a valid Path!");
                }
            }
        }

        public static void GetbiggestFile(string path)
        {
            string[] files = Directory.GetFiles(path);
            long biggestfile = 0;
            string namebiggestfile = null;
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                long filesize = fileInfo.Length;
                if (filesize > biggestfile)
                {
                    namebiggestfile = fileInfo.Name;
                    biggestfile = filesize;
                }
            }
            Console.WriteLine("The largest File is: " + namebiggestfile + " with a Size of " + biggestfile + " bites");
        }

        public static void PrintBiggestFile(string filename)
        {
            FileInfo fileInfo = new FileInfo(filename);
            Console.WriteLine("The largest File is: " + fileInfo.Name + " with a Size of " + fileInfo.Length + " bites");
        }


        public static string GetbiggestFile1(string path, long startingvalue, string name)
        {
            string[] files = Directory.GetFiles(path);
            long biggestfile = startingvalue;
            string namebiggestfile = name;
            string[] directories = Directory.GetDirectories(path);
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                long filesize = fileInfo.Length;
                if (filesize > biggestfile)
                {
                    namebiggestfile = fileInfo.Name;
                    biggestfile = filesize;
                }
            }
            foreach (string directory in directories)
            {
                DirectoryInfo directionaryInfo = new DirectoryInfo(directory);
                namebiggestfile = GetbiggestFile1(directionaryInfo.FullName, biggestfile, namebiggestfile);
            }

            return namebiggestfile;
        }
    }
}
