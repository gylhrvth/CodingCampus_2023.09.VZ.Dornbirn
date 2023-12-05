namespace Selina.Week08.Filesystem
{
    public class Filesystem_traversal 
    {
        public static void Start()
        {
            string filesystem = Directory.GetCurrentDirectory();
            Console.WriteLine(filesystem);

            DirectoryInfo projectDirectory = new DirectoryInfo(filesystem).Parent.Parent.Parent;
            Console.WriteLine(projectDirectory);

            GetFiles(projectDirectory);

        }
        public static void GetFiles(DirectoryInfo projectDirectory)
        {
            FileInfo[] fileInfo = projectDirectory.GetFiles();

            DirectoryInfo[] subfolders = projectDirectory.GetDirectories();

            foreach (DirectoryInfo subfolder in subfolders)
            {
                Console.WriteLine($"├── {subfolder.Name}");
                GetFiles(subfolder);
            }

            foreach (FileInfo file in fileInfo)
            {
                Console.WriteLine($"│\t└── {file.Name}");
            }
        }
    }
}



