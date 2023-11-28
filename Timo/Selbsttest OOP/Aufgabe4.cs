using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Selbsttest_OOP
{
    public class Aufgabe4
    {
        public static void Start()
        {
            string path = "C:\\Users\\aau27722\\source\\Repos\\CodingCampus_2023.09.VZ.Dornbirn\\Timoo";
            Console.WriteLine("Größte Datei im Verzeichns '{0}':", path);
            PrintBiggestFile(BiggestFile(path));
        }
        public static string BiggestFile(string path)
        {
            try
            {
                string[] files = Directory.GetFiles(path);
                string PathOfBiggestFile = "";
                double maxLength = 0;
                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    if (fileInfo.Length > maxLength)
                    {
                        PathOfBiggestFile = file;
                        maxLength = fileInfo.Length;
                    }
                }
                return PathOfBiggestFile;
            }
            catch (Exception e)
            {
                return (e.Message);
            }
        }
        public static void PrintBiggestFile(string path)
        {
            if (File.Exists(path))
            {
                FileInfo fileInfo = new FileInfo(path);
                Console.WriteLine(fileInfo.Name);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(path);
                Console.ResetColor();
            }
        }
    }
}
