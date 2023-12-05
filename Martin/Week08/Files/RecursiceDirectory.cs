using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week08.Files
{
    public class RecursiceDirectory
    {
        public static void Start()
        {
            string currentPath = Directory.GetCurrentDirectory(); //gibt den aktuellen path ein

            DirectoryInfo directoryInfo = new DirectoryInfo(currentPath).Parent.Parent.Parent; //gibt info

            Console.WriteLine("Folder: " + directoryInfo.FullName); //drücke den ganzen path aus

            PrintDirectoriesAndFiles(directoryInfo, "   "); 
        }

        public static void PrintDirectoriesAndFiles(DirectoryInfo rootFolder,string prefix)
        {

            FileInfo[] FilesFromRoot = rootFolder.GetFiles(); // bekommt die ganzen files im root

            foreach (var File in FilesFromRoot) //wenne es etwas sich im root gibt geht die foreach schleife los
            {
                Console.WriteLine(prefix + "/File:" + File.Name);
            }

            DirectoryInfo[] directoryInfo = rootFolder.GetDirectories(); // bekommt infos vom rootfolder 

            foreach (DirectoryInfo directory in directoryInfo)
            {
                Console.WriteLine(prefix + "*Folder*: " + directory.Name); //gibt dein order aus und den abstand(prefix)

                PrintDirectoriesAndFiles(directory,prefix + "    "); //jedem neuen ordner soll mehr abstand sein

                Console.WriteLine();
            }
        }
    }
}
