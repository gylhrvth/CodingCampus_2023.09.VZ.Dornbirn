using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week08.FileSystemTraversalUseful
{
    internal class Filesystem : IFileReceiver
    {
        public void OnDirectoryReceived(int depth, string path)
        {
            string prefix = new(' ', depth * 5);
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            Console.WriteLine("" + prefix + "├──" + directoryInfo.Name);
        }

        public void OnFileReceived(int depth, string path)
        {
            string prefix = new(' ', depth * 5);
            FileInfo fileInfo = new (path);
            Console.WriteLine("" + prefix + "├──" + fileInfo.Name);
        }
    }
}
