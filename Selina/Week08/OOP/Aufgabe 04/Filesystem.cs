namespace Selina.Week08.OOP.Aufgabe_04
{
    public class Filesystem
    {
        public static void Start()
        {
            Console.WriteLine("Bitte geben Sie einen Dateipfad ein: ");
            string path = Console.ReadLine();

            if (Directory.Exists(path))
            {
                FileInfo biggestFile = FindBiggestFile(path);

                if (biggestFile != null)
                {
                    Console.WriteLine($"Die größte Datei {path} ist:\n {biggestFile.Name} mit {biggestFile.Length} bytes");
                }
                else if (biggestFile == null)
                {
                    Console.WriteLine($"Dieses Verzeichnis {path} ist leer oder ist nicht vorhanden!.");
                }
            }
            else
            {
                Console.WriteLine("Dieser Pfad gibt es nicht.");
            }
        }

        public static FileInfo FindBiggestFile(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);

            if (directory.GetFiles().Length == 0)
            {
                return null;
            }

            FileInfo biggestFile = null;
            long maxSizeOfFile = 0;

            foreach (FileInfo file in directory.GetFiles())
            {
                if (file.Length > maxSizeOfFile)
                {
                    maxSizeOfFile = file.Length;
                    biggestFile = file;
                }
            }

            return biggestFile;

        }
    }
}
