namespace DarioLuis.Week08
{
    public class Filesystem_traversal
    {
        public static void Main()
        {
            string startPath = @"C:\Users\daae\source\repos\CodingCampus_2023.09.VZ.Dornbirn\DarioLuis";
            NavigateFileSystem(startPath, 0);
        }

        static void NavigateFileSystem(string path, int indentationLevel)
        {
            try
            {
                // Ausgabe des aktuellen Verzeichnisses oder der Datei mit Einrückung entsprechend der Rekursionsebene
                Console.WriteLine($"{new string(' ', indentationLevel * 4)} ├──{Path.GetFileName(path)}");

                // Überprüfen, ob es sich um ein Verzeichnis handelt
                if (Directory.Exists(path))
                {
                    // Rekursiv durch alle Kinder dieses Ordners navigieren
                    string[] subDirectories = Directory.GetDirectories(path);
                    foreach (string subDirectory in subDirectories)
                    {
                        NavigateFileSystem(subDirectory, indentationLevel + 1);
                    }

                    // Rekursiv durch alle Dateien dieses Ordners navigieren
                    string[] files = Directory.GetFiles(path);
                    foreach (string file in files)
                    {
                        NavigateFileSystem(file, indentationLevel + 1);
                    }
                }
            }
            catch (Exception ex)
            {
                // Fehlerbehandlung, falls beim Zugriff auf das Dateisystem ein Fehler auftritt
                Console.WriteLine($"Fehler beim Navigieren: {ex.Message}");
            }
        }
    }

}

