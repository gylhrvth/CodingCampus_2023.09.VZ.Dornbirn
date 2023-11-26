
namespace Fabian.Week08._09_FilesystemUsefull
{
    public class FilesystemMain
    {
        public static void Start()
        {
            string path = @"C:\Users\Anwender\source\repos\CodingCampus_2023.09.VZ.Dornbirn\Fabian";


            FileAndDirectoryCounter fdCounter = new();
            FileSizeCalculator fs = new FileSizeCalculator();
            FileExtensionCollector feco = new();
            FileExtensionCounter fec = new(".cs");
            FolderSizeCalculator fsc = new();
            FileSystem fsy = new();

            NavigateFileSystem(0, path, new List<IFileReceiver> { fdCounter, fs, feco, fec, fsc});

            Console.WriteLine("Directory count:\n" + fdCounter.GetDirectoryCounter());
            Console.WriteLine("File count:\n" + fdCounter.GetFileCounter());
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Total size:\n" + fs.GetTotalSize() + " bytes");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Total files with .cs:\n" + fec.GetFileCounter());
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Total extensions:\n");
            feco.PrintExtensions();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Folder sizes:\n");
            fsc.PrintFolderSizes();


        }

        public static void NavigateFileSystem(int depth, string path, List<IFileReceiver> frs)
        {
            string[] files = Directory.GetFiles(path);
            string[] directories = Directory.GetDirectories(path);

            foreach(var file in files)
            {
                foreach(var fr in frs)
                    fr.OnFileReceived(depth, file);
            }
            foreach (var directory in directories)
            {
                foreach (var fr in frs)
                    fr.OnDirectoryReceived(depth, directory);

                NavigateFileSystem(depth + 1, directory, frs);
                
            }
        }
    }
}
