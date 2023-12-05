using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week08.Files
{
    public class FileSystem
    {
        public FileSystem()
        {

        }
        public static void Start()
        {
            string name = "C:\\Users\\DCV\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Ali\\Week02";
             
            Console.WriteLine(name);

            DirectoryInfo rootFolder = new DirectoryInfo(name).Parent;

            Console.WriteLine(rootFolder);

            PrintDirectoryandFiles(rootFolder, "-----");
        }


        public static void PrintDirectoryandFiles(DirectoryInfo rootFolder,string prefix)
        {
            FileInfo[] files = rootFolder.GetFiles();

            foreach (FileInfo file in files)
            {
                Console.WriteLine(prefix + " File: " + file.Name);
            }

            DirectoryInfo[] subfolders = rootFolder.GetDirectories();

            foreach (DirectoryInfo folder in subfolders)
            {
                Console.WriteLine(prefix + " Ordner: " + folder.Name);

                PrintDirectoryandFiles(folder, prefix + "-----");
            }
        }






        
    }
}
