using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week08._04Filesystem
{
    public class FileTraversal : IFileReceiver
    {
        public void OnFileReceived(int depth, string path)
        {
            FileInfo file = new FileInfo(path);
            Console.ForegroundColor = ConsoleColor.Red;
            PrintIntendation(depth);
            Console.WriteLine(file.Name);
            Console.ResetColor();
        }
        public void OnDirectoryReceived(int depth, string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            Console.ForegroundColor = ConsoleColor.Green;
            PrintIntendation(depth);
            Console.WriteLine(dir.Name);
            Console.ResetColor();
        }

        public void PrintIntendation(int depth)
        {
            for(int i = 0; i < depth; i++)
            {
                Console.Write("  ");
            }
        }
    }
}
