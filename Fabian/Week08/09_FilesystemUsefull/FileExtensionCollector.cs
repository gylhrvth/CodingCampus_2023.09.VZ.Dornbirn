
namespace Fabian.Week08._09_FilesystemUsefull
{
    public class FileExtensionCollector : IFileReceiver
    {
        private Dictionary<string, int> _Extensions = new Dictionary<string, int>();
        public void OnDirectoryReceived(int depth, string path) { }

        public void OnFileReceived(int depth, string path)
        {
            string extension = Path.GetExtension(path);

            if (extension != "")
            {
                if (_Extensions.ContainsKey(extension))
                    _Extensions[extension]++;
                else
                    _Extensions[extension] = 1;
            }
        }
        public void PrintExtensions()
        {
            foreach (var kvp in _Extensions)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }
        }
    }
}
