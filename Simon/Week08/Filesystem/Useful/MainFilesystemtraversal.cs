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
            string path = "C:\\Users\\aau21982\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Simon\\Week01";
            CountFilesFolders countFilesFolders = new();
            SizeFiles sizeFiles = new SizeFiles();
            CountFileEnding countFileEnding = new("cs");
            //string current = Directory.GetCurrentDirectory();
            //Console.WriteLine(current);

            FileTraversal(path, 0, countFilesFolders);
            Console.WriteLine($"Filecount: {countFilesFolders.Count}");
            Console.WriteLine($"Foldercount: {countFilesFolders.Count}");
            FileTraversal(path, 0, sizeFiles);
            Console.WriteLine($"SummFilesize: {sizeFiles.Size}");
            FileTraversal(path, 0, countFileEnding);
            Console.WriteLine($"Files ending on cs: {countFileEnding.Count}");
        }



        public static void FileTraversal(string path, int depth, IFileReceiver fr)
        {

            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                fr.OnFileRecived(depth, file);
            }

               
      
            string[] directories = Directory.GetDirectories(path);
            foreach (string dir in directories)
            {        
                FileTraversal(dir, depth + 1, fr);
            }
        }




    }
}
