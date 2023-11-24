using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week09.Filesystem.Filesystem_Traversl_Useful
{
    class FileReceiver : Itraversal
    {
        private int filesCounter = 0;
        private int directorysCounter = 0;
        public static void Start()
        {
            string path = "C:\\Users\\DCV\\source\\repos";

            int[] filesAndFolder = CountFilesAndFolder(path);
            Console.WriteLine($"Folders: {filesAndFolder[0]} ");
            Console.WriteLine($"Files: {filesAndFolder[1]} ");
            Console.WriteLine($"{filesAndFolder[2]}bytes");
        }

        public void OneFileReceived(int depth, string path)
        {


        }

        public void OneDirectoryReceived(int depth, string path)
        {


        }

        private static int[] CountFilesAndFolder(string path)
        {
            string[] subFolderPathList = Directory.GetDirectories(path);
            string[] filesOfFolderList = Directory.GetFiles(path);
            int[] folderAndFiles = new int[3];
            folderAndFiles[0] = 0; //folder
            folderAndFiles[1] = 0; //file
            folderAndFiles[2] = 0; //MB


            foreach (string dirElements in subFolderPathList)
            {
                folderAndFiles[0]++;
                int[] result = CountFilesAndFolder(dirElements);
                folderAndFiles[1] += result[1];
                folderAndFiles[0] += result[0];
                folderAndFiles[2] += result[2];
            }
            foreach (string files in filesOfFolderList)
            {
                FileInfo fileInfo = new FileInfo(files);
                folderAndFiles[2] += (int)fileInfo.Length;
                folderAndFiles[1]++;
            }
            return folderAndFiles;
        }
    }
}
