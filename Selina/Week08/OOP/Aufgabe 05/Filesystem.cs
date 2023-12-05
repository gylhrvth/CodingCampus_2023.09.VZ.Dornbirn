using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week08.OOP.Aufgabe_05
{
    public class Filesystem
    {
        public static void Start()
        {
            Console.WriteLine("Bitte geben Sie einen Dateipfad ein: ");
            string path = Console.ReadLine();
            Console.WriteLine();

            if (Directory.Exists(path))
            {
                FileInfo biggestFile = FindBiggestFile(path);

                List<FileInfo> largestFiles = new List<FileInfo>();
                FindFiveBigFiles(path,largestFiles);

                if (biggestFile != null)
                {
                    Console.WriteLine($"\nDie größte Datei von {path} \n ist: {biggestFile.Name} mit {biggestFile.Length} bytes");
                }
                else if (biggestFile == null)
                {
                    Console.WriteLine($"Dieses Verzeichnis {path} ist leer oder ist nicht vorhanden!.");
                }
            }
            else
            {
                Console.WriteLine("Dieser Pfad gibt es nicht.");
            }
        }

        public static FileInfo FindBiggestFile(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);

            if (directory.GetFiles().Length == 0)
            {
                return null;
            }

            FileInfo biggestFile = null;
            long maxSizeOfFile = 0;

            foreach (FileInfo file in directory.GetFiles())
            {
                if (file.Length > maxSizeOfFile)
                {
                    maxSizeOfFile = file.Length;
                    biggestFile = file;
                }
            }

            return biggestFile;

        }
        public static List<FileInfo> FindFiveBigFiles(string path,List<FileInfo> largestFiles)
        {
            DirectoryInfo directory = new DirectoryInfo(path);

            if (directory.GetFiles().Length == 0)
            {
                return null;
            }

            FileInfo biggestFile = null;
            long maxSizeOfFile = 0;

            foreach (FileInfo file in directory.GetFiles())
            {
                if (file.Length > maxSizeOfFile)
                {
                    maxSizeOfFile = file.Length;
                    biggestFile = file;
                    largestFiles.Add(biggestFile);
                }
            }
            return largestFiles;
        }
    }
}
