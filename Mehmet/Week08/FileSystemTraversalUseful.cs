using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week08
{
    public abstract class FileSystemTraversalUseful
    {
        public abstract void OnFileReceived(int depth, string path);
        public abstract void OnDirectoryReceived(int depth, string path);
    }
}
