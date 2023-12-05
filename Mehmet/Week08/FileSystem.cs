using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week08
{
    internal class FileSystem
    {
        public static void Start() 
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            Console.WriteLine("\n===============Aufgabe_1===============\n");

            Console.WriteLine(currentDirectory);

            Console.WriteLine("\n===============Aufgabe_2===============\n");

            FileInfo fileInfo1 = new FileInfo(currentDirectory);
            Console.WriteLine(fileInfo1.Name);

            string[] children = Directory.GetFiles(currentDirectory);
            long asas = 0;
            foreach (var child in children)
            {
                FileInfo fileInfo = new FileInfo(child);
                Console.WriteLine(fileInfo.Name + " " + fileInfo.Length);
                asas += fileInfo.Length;
            }
            Console.WriteLine($"Gesamt: {asas}Bits");

            Console.WriteLine("\n===============Aufgabe_3===============\n");

            var currentDirectoryInfo1 = new DirectoryInfo(currentDirectory);
            string pojektRootDirectory = currentDirectoryInfo1.Parent.Parent.Parent.FullName;
            printDirectory(pojektRootDirectory, "────");

            Console.WriteLine("\n===============Aufgabe_4===============\n");





        }







        public static void printDirectory(string directoryName, string depth)
        {
            Console.Write("────");
            string[] children = Directory.GetFiles(directoryName);
            foreach (var asa in children)
            {
                Console.Write(depth);
                FileInfo fileInfo1 = new FileInfo(asa);
                Console.WriteLine(fileInfo1.Name); 
            }
            string[] folders = Directory.GetDirectories(directoryName);
            foreach(var child in folders)
            {
                printDirectory(child,depth+ "────");
            }
        }


    }
}
