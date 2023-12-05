using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week08.Filesystem
{
    public interface FileReceiver
    {
        void OnFileReceived(int depth, string path);
        void OnDirectoryReceived(int depth, string path);
    }
}
