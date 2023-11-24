using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week08.Filesystem
{
    public class PrintFileTreeReceiver : FileReceiver
    {
        public PrintFileTreeReceiver()
        {
        }

        public void OnFileReceived(int depth, string path)
        {
            printIndention(depth);
            Console.WriteLine(new FileInfo(path).Name);
        }

        public void OnDirectoryReceived(int depth, string path)
        {
            printIndention(depth);
            Console.WriteLine(new DirectoryInfo(path).Name);
        }

        public void printIndention(int depth)
        {
            for (int i = 0; i < depth; i++)
            {
                Console.Write("  ");
            }
        }
    }
}
