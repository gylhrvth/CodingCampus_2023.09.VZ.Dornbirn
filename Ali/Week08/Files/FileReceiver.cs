using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week08.Files
{
    public interface FileReceiver
    {
        public void OnFileReceived(int depth, string path);
        public void OnDirectoryReceived(int depth, string path);
    }
}