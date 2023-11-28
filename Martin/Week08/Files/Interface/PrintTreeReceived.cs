using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week08.Files.Interface
{
    public class PrintTreeReceived : TraverUsefulInterface
    {

        public void OnFileReceived(int depth, string path)
        {
            print(depth);
            Console.WriteLine(new FileInfo(path).Name);
        }
        public void OnDirectoryReceived(int depth, string path)
        {
            print(depth);
            Console.WriteLine(new DirectoryInfo(path).Name);
        }

        public void print(int depth)
        {
            for(int i = 0; i < depth; i++)
            {
                Console.Write("   ");
            }
        }
    }
}
