using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week08
{
    public interface FileReceiver
    {
        public void OnFileReceived(int depth, string path);
        public void OnDirectoryReceived(int depth, string path);
    }
}
