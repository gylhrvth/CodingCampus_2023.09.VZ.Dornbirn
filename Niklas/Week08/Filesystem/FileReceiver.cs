using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week08.Filesystem
{
    public interface FileReceiver
    {
        public void OnFileReceived(int depth, string path);

        public void OnDirectoryReceived(int depth, string path);
    }
}
