using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro.Week08.FileWalker
{
    internal interface IFileProcessor
    {
        void onFileReceived(int depth, File file);
    }
}
