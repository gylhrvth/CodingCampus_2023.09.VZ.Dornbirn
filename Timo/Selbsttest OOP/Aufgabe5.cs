﻿using System.IO;
 
namespace Timo.Selbsttest_OOP
{
    public class Aufgabe5
    {
        public static void Start()
        {
            //Pfad = C:\Users\aau27722\source\Repos\CodingCampus_2023.09.VZ.Dornbirn\Timo
            //PrintBiggestFile(BiggestFile(ReadUserInput()));
        }

       


        public static string ReadUserInput()
        {
            while (true)
            {
                Console.WriteLine("Bitte geben Sie den zu überprüfenden Pfad ein: ");
                string path = Console.ReadLine();
                if (File.Exists(path) || Directory.Exists(path))
                {
                    Console.WriteLine(".");
                    return path;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Could not find '{0}'", path);
                    Console.ResetColor();
                }
            }
        }
        public static string BiggestFile(string path, long maxLen = 0, string pfad = "")
        {   
                string[] files = Directory.GetFiles(path);
                string[] directories = Directory.GetDirectories(path);
                string PathOfBiggestFile = pfad;
                long maxLength = maxLen;
                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    if (fileInfo.Length > maxLength)
                    {
                        PathOfBiggestFile = fileInfo.FullName;
                        maxLength = fileInfo.Length;
                    }
                }

                foreach (string directory in directories)
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(directory);
                    PathOfBiggestFile = BiggestFile(directoryInfo.FullName, maxLength, PathOfBiggestFile);
                }
                return PathOfBiggestFile;
        }
        public static void PrintBiggestFile(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            Console.WriteLine(fileInfo.Name + " " + fileInfo.Length);
        }
    }
}