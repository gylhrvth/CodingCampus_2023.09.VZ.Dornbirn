using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week08.Filesystem
{
    internal class DateienundOrdner2
    {
        public static void Start()
        {
            //ich rufe meinen aktuellen ordner auf / GetCurrentDirectory() ist eine Methode die schon in C# vorhanden ist
            string currentDirectory = Directory.GetCurrentDirectory();
            

            var currentDirectoryInfo = new DirectoryInfo(currentDirectory);
            

            //get current directory davor wichtig



            //foreach ( var child in children )
            //{
            //    FileInfo fileinfo = new FileInfo(child);

            //    Console.WriteLine("_" +  fileinfo.Name + " " + Math.Round(ConvertToMByte(fileinfo.Length),2) + "mb");
            //}

            string[] children = Directory.GetFiles(currentDirectory);

            //mit dem befehl dateiname.Parent kann ich jeweils immer 1 ebene rauf springen
            string projectRootDirectory = currentDirectoryInfo.Parent.Parent.Parent.FullName;
            Console.WriteLine(projectRootDirectory);




            FilesystemRekursion(projectRootDirectory, "├──");
        }

        


        public static void FilesystemRekursion(string projectRootDirectory, string depth )
        {
            string[] children = Directory.GetFiles(projectRootDirectory);

            foreach (string child in children)
            {
                FileInfo fileInfo = new FileInfo(child);

                Console.WriteLine(depth + fileInfo.Name);
                
            }

            string[] childi = Directory.GetDirectories(projectRootDirectory);

            foreach (string child in childi)
            {
                
                FilesystemRekursion(child,depth + "──");
                
     
            }
            
           
        }


        
    }
}
