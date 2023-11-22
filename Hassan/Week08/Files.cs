using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hassan.Week08
{
    public class Files
    {
        public static void Start()
        {
            string directoryPath = "C:\\Users\\DCV\\Source\\Repos\\CodingCampus_2023.09.VZ.Dornbirn\\Hassan\\Week08";

            //Alle datein auslisten (Aufgabe1) ohne sortieren
            ListFilesRecursively(new DirectoryInfo(directoryPath));
            

            // Datein zählen und die gesamt Größe berechnen (Aufgabe2)
            PrintFileCountAndSum(directoryPath);

        }


        static void ListFilesRecursively(DirectoryInfo root)
        {
            Console.WriteLine($"Directory: {root.Name}/");

            // Anzeigen der Dateien im aktuellen Verzeichnis
            FileInfo[] files = root.GetFiles();
            foreach (FileInfo file in files)
            {
                Console.WriteLine($"    |--------File: {file.Name}");
            }

            // Rekursiver Aufruf für Unterverzeichnisse
            DirectoryInfo[] subDirectories = root.GetDirectories();
            foreach (DirectoryInfo subDirectory in subDirectories)
            {
                ListFilesRecursively(subDirectory);
            }
        }

        static void PrintFileCountAndSum(string directoryPath)
        {
            DirectoryInfo directory = new DirectoryInfo(directoryPath);

            int numFiles = 0;
            long fileSumLength = 0;

            FileInfo[] fileList = directory.GetFiles();
            foreach (FileInfo file in fileList)
            {
                
                numFiles++;
                fileSumLength += file.Length;

            }

            Console.WriteLine($"Anzahl der Dateien im Verzeichnis: {numFiles}");
            Console.WriteLine($"Summe der Größe der Dateien: {fileSumLength} bytes");
        }


    }
}
