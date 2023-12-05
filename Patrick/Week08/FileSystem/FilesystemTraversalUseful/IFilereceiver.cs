using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.FileSystem.FilesystemTraversalUseful
{
    public interface IFilereceiver
    {
        void OnFileReceived(int depth, string rootFolder);
        void OnDirectoryReceived(int depth, string rootFolder);

    }
}
