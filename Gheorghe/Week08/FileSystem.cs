using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week08
{
    internal class FileSystem
    {
        public static void Start()
        {

            DirectoryInfo directoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory());
            directoryInfo = directoryInfo.Parent.Parent.Parent.Parent;

            Console.WriteLine(directoryInfo.FullName);



            foreach (var directory in directoryInfo.GetDirectories())
            {
                Console.WriteLine("Ordner: {0}", directory.Name);
            }


            // Ausgabe aller Dateien mit Dateigröße
            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                Console.WriteLine("Datei: {0}, Größe: {1}", file.Name, file.Length);
            }

            Console.WriteLine(GetDirectoySize(directoryInfo));
            Console.WriteLine("==================================================================================");

            string rootFolder = "C:\\Users\\DCV\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Gheorghe";
            RecursivelyTraverseFileSystem("", rootFolder);
        }





        public static long GetDirectoySize(DirectoryInfo directoryInfo)
        {
            // Initialisiere die Ordnergröße
            long folderSize = 0;

            // Addiere die Größe aller Dateien im Ordner zur Ordnergröße
            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                folderSize += file.Length;
            }

            // Gib die Ordnergröße zurück
            return folderSize;
        }





        public static void RecursivelyTraverseFileSystem( string prefix,string path)
        {

            // prefix
            prefix = prefix + "    ";

            // Erzeuge einen DirectoryInfo-Objekt für den angegebenen Pfad

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            var dirInfo = directoryInfo.GetFiles();


            // Iteriere durch alle Kinder des Ordners

            foreach (DirectoryInfo childDirectory in directoryInfo.GetDirectories())
            {
                // Wenn das Kind ein Ordner ist, dann rufe die Methode rekursiv für den Ordner auf

                Console.WriteLine(prefix + "├── " + childDirectory.Name + "(Folder) " );
                path = childDirectory.FullName;
                RecursivelyTraverseFileSystem(prefix, path);


            }





            // Iteriere durch alle Dateien im Ordner

            foreach (FileInfo fileInfo in dirInfo)
            {
                // Gib den Dateinamen aus

                Console.WriteLine(prefix + $"└── (Files) {fileInfo.Name} {fileInfo.Length}");
            }

        }

    }


}










//Andere version 
/*
 public static void Start()
 {
     DirectoryInfo directoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory());
     directoryInfo = directoryInfo.Parent.Parent.Parent.Parent;

     // Calculate the total size of all files in the directory
     long totalSize = 0;
     foreach (var subdirectory in directoryInfo.EnumerateDirectories())
     {
         totalSize += GetDirectoySize(subdirectory);
     }

     Console.WriteLine("Total size of all files: {0} bytes", totalSize);
 }

 private static long GetDirectoySize(DirectoryInfo directoryInfo)
 {
     long size = 0;
     foreach (var file in directoryInfo.EnumerateFiles())
     {
         size += file.Length;
     }

     return size; 
                  */



