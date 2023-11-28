using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.FileSystem.FilesystemTraversalUseful
{
    internal class FindAndCountFile : IFilereceiver
    {
        private Dictionary<string, int> _FileExtensionsCount = new Dictionary<string, int>();

        public Dictionary<string, int> FileExtensionsCount
        {
            get => _FileExtensionsCount;
        }

        public void OnFileReceived(int depth, string path)
        {
            string extension = Path.GetExtension(path)?.ToLowerInvariant();
            if (!string.IsNullOrEmpty(extension))
            {
                if (_FileExtensionsCount.ContainsKey(extension))
                {
                    _FileExtensionsCount[extension]++;
                }
                else
                {
                    _FileExtensionsCount[extension] = 1;
                }
            }
        }

        public void OnDirectoryReceived(int depth, string path)
        {

        }

    }
}
