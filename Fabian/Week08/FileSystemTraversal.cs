using System.Diagnostics.CodeAnalysis;

namespace Fabian.Week08
{
    public class FileSystemTraversal
    {
        public static void Start()
        {
            string path = @"C:\Users\Anwender\source\repos\CodingCampus_2023.09.VZ.Dornbirn\Fabian";
            NavigateDirectory(path, "");
        }

        public static void NavigateDirectory(string path, string prefix)
        {
            string[] files = Directory.GetFiles(path);
            string[] directories = Directory.GetDirectories(path);

            foreach (string file in files)
            {
                if (file == files.Last())
                    Console.WriteLine($"{prefix}└── {Path.GetFileName(file)}");
                else
                    Console.WriteLine($"{prefix}├── {Path.GetFileName(file)}");
            }

            foreach (string directory in directories)
            {
                if (directory == directories.Last())
                {
                    Console.WriteLine($"{prefix}└── {Path.GetFileName(directory)}");
                    NavigateDirectory(directory, $"{prefix}    ");
                }
                else
                {
                    Console.WriteLine($"{prefix}├── {Path.GetFileName(directory)}");
                    NavigateDirectory(directory, $"{prefix}|   ");
                }
            }
        }
    }
}

