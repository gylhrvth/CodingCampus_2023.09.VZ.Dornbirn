using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week08.Files.Interface
{
    public class Main
    {
        public static void Start()
        {
            string currentPath = Directory.GetCurrentDirectory();
            
            DirectoryInfo directoryInfo = new DirectoryInfo(currentPath).Parent.Parent;

            Console.WriteLine(directoryInfo.Name);

            FileAndCounter FileCounter = new FileAndCounter();
            Traversal(currentPath,0, FileCounter);

            Console.WriteLine("Files: {0}",FileCounter.CounterFile);


            FileAndCounter FolderCounter = new FileAndCounter();
            Traversal(currentPath, 0, FolderCounter);

            Console.WriteLine("Folder: {0}", FolderCounter.CounterFolder);


            PrintTreeReceived printTreeReceived = new PrintTreeReceived();
            Traversal(currentPath, 0, printTreeReceived);
        }

        public static void Traversal(string path,int depth, TraverUsefulInterface fileReceiver)
        {
            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                fileReceiver.OnFileReceived(depth, file);
            }

            string[] dir = Directory.GetDirectories(path);

            foreach (string dir2 in dir)
            {
                fileReceiver.OnDirectoryReceived(depth, dir2);
                Traversal(dir2,depth + 1, fileReceiver);
            }
        }
    }
}
