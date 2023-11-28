using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week08.Files.Interface
{
    public interface TraverUsefulInterface
    {
        void OnFileReceived(int depth, string path);
        void OnDirectoryReceived(int depth, string path);
    }
}
