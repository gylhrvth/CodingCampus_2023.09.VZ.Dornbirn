namespace Selina.Week08.Filesystem
{
    public class Filesystem
    {
        public static void Start()
        {

            double result = 0;

            // schreibt C:\Users\wpfsebr\source\repos\CodingCampus_2023.09.VZ.Dornbirn\Selina\bin\Debug\net7.0
            Console.ForegroundColor = ConsoleColor.Blue;
            string filesystem = Directory.GetCurrentDirectory();
            Console.WriteLine(filesystem);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            string[] files = Directory.GetFiles(filesystem);
            // FileInfo schreibt: --> Ressources.deps.json / Selina.runtimeconfig.json

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("├── " + fileInfo.FullName);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"│\t└── File: {fileInfo.Name} ist {fileInfo.Length} bytes groß.\n│");
                result += fileInfo.Length;
            }

            Console.WriteLine($"\t\t└── Alle Files sind {result} bytes groß.\n");

            //DirectoryInfo schreibt: C:\Users\wpfsebr\source\repos\CodingCampus_2023.09.VZ.Dornbirn\Selina\bin\Debug
            var dirs = new DirectoryInfo(filesystem);
            string projectDirectory = dirs.Parent.Parent.Parent.FullName;
            Console.WriteLine(projectDirectory);

            string[] directory = Directory.GetDirectories(projectDirectory);
            directory = DescendingLength(directory);

            Console.WriteLine();
            foreach (string file in directory)
            {
                DirectoryInfo info = new DirectoryInfo(file);
                Console.WriteLine(info.Name);
            }
        }
        public static string[] DescendingLength(string[] names)
        {
            for (int i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - i - 1; j++)
                {
                    if (names[j].Length < names[j + 1].Length)
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }

            return names;
        }
    }
}
