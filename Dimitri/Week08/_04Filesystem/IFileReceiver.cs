using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week08._04Filesystem
{
    interface IFileReceiver
    {
        void OnFileReceived(int depth, string path);
        void OnDirectoryReceived(int depth, string path);
    }
}
