namespace DarioLuis.Week08
{
    public class Datein_und_Ordner
    {
        public static void Start()
        {
            Ordner();
            Aufgab2();
        }
        public static void Ordner()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string[] children = Directory.GetFiles(currentDirectory);

            var currentDirectoryInfo = new DirectoryInfo(currentDirectory);
            string projectRootDirectory = currentDirectoryInfo.Parent.Parent.Parent.Parent.FullName;


            Console.Write("Project Digital Campus Directory: ");

            //Path
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(projectRootDirectory);
            Console.ForegroundColor = ConsoleColor.White;

            string[] directoryChildren = Directory.GetDirectories(projectRootDirectory);
            string[] directoryChildrenFiles = Directory.GetFiles(projectRootDirectory);

            foreach (var directory in directoryChildren)
            {
                FileInfo fileInfo = new FileInfo(directory);
                DirectoryInfo info = new DirectoryInfo(directory);
                if (Directory.Exists(info.FullName))
                {
                    Console.WriteLine(info.Name);
                }
            }

            //Ausgabe
            foreach (var directory in directoryChildrenFiles)
            {
                FileInfo fileInfo = new FileInfo(directory);
                DirectoryInfo info = new DirectoryInfo(directory);
                if (File.Exists(fileInfo.FullName))
                {
                    Console.Write(fileInfo.Name + " hat insgesamt ");
                    if (Math.Round(ConvertToKB(fileInfo.Length)) >= 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(Math.Round(ConvertToKB(fileInfo.Length)));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("KB");


                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(Math.Round(ConvertToKB(fileInfo.Length)));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("KB");
                    }
                }
            }
        }
        public static float ConvertToKB(long sizeInByte)
        {
            return sizeInByte / 1024.0f;
        }

        public static void Aufgab2() 
        {
            // Den Weg definieren und eine Variable zuweisen
            string directoryPath = @"C:\Users\daae\source\repos\CodingCampus_2023.09.VZ.Dornbirn";


            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);

            //Ausgabe
            if (directoryInfo.Exists)
            {

                long directorySize = GetDirectorySize(directoryInfo);


                Console.Write($"Größe vom Ordner: '{directoryPath}': ");
                if (directorySize >= 30)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{FormatBytes(directorySize)}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        //Heraus finden wie groß der Ordner ist
        static long GetDirectorySize(DirectoryInfo directory)
        {
            long size = 0;


            foreach (var file in directory.GetFiles())
            {
                size += file.Length;
            }


            foreach (var subdirectory in directory.GetDirectories())
            {
                size += GetDirectorySize(subdirectory);
            }

            return size;
        }

        //Welche Einheit es haben soll

        static string FormatBytes(long bytes)
        {
            string[] sizeSuffixes = { "B", "KB", "MB", "GB", "TB" };
            int i = 0;

            while (bytes >= 1024 && i < sizeSuffixes.Length - 1)
            {
                bytes /= 1024;
                i++;
            }

            return $"{bytes} {sizeSuffixes[i]}";
        }
        
    }
}


