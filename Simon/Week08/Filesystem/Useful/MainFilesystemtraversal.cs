using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week08.Filesystem.Useful
{
    public class MainFilesystemtraversal
    {
        public static void Start()
        {
<<<<<<< HEAD
            string path = "C:\\Users\\aau21982\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Simon\\Week01";
            CountFilesFolders countFilesFolders = new();
            SizeFiles sizeFiles = new SizeFiles();
            CountFileEnding countFileEnding = new("cs");
=======
>>>>>>> 9f87552f42c4104cfae8cf02fca03992d0b643d4


<<<<<<< HEAD
            //string current = Directory.GetCurrentDirectory();
            //Console.WriteLine(current);

            FileTraversal(path, 0, countFilesFolders);
            Console.WriteLine($"Filecount: {countFilesFolders.FileCount}");
            Console.WriteLine($"Foldercount: {countFilesFolders.FolderCount}");
            FileTraversal(path, 0, sizeFiles);
            Console.WriteLine($"SummFilesize: {sizeFiles.Size}");
            FileTraversal(path, 0, countFileEnding);
            Console.WriteLine($"Files ending on cs: {countFileEnding.Count}");
=======
>>>>>>> 9f87552f42c4104cfae8cf02fca03992d0b643d4
        }



        public static void FileTraversal(string path)
        {
            
            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
<<<<<<< HEAD
                fr.OnFileReceived(depth, file);
            }
=======
                IFileReceiver.OnfileRecived(0, path);
>>>>>>> 9f87552f42c4104cfae8cf02fca03992d0b643d4



            }
            string[] directories = Directory.GetDirectories(path);
            foreach (string dir in directories)
            {
                
                
                FileTraversal(dir);
            }
        }




    }
}
