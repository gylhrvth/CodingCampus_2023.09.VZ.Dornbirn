using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro.Week08.FileWalker
{
    class FileReceiver : IFileProcessor
    {
        public FileReceiver() { }

    }

    
    public override void onFileReceived(int depth, string file)
    {
        Console.WriteLine("  test");
    }
}
