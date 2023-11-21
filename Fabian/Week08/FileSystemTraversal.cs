using System.IO;

namespace Fabian.Week08
{
    public class FileSystemTraversal
    {
        public static void Start()
        {
            string path = "C:\\Users\\fakr\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Fabian";
            NavigateDirectory(path, 0);
        }

        public static void NavigateDirectory(string path, int indentationLevel)
        {
            string indentation = new string(' ', indentationLevel * 4);
            string[] files = Directory.GetFiles(path);
            string[] directories = Directory.GetDirectories(path);

            foreach (string file in files)
            {
                Console.WriteLine($"{indentation}├── {Path.GetFileName(file)}");
            }

            foreach (string directory in directories)
            {
                Console.WriteLine($"{indentation}├── {Path.GetFileName(directory)}");
                NavigateDirectory(directory, indentationLevel + 1);
            }
        }
    }
}
