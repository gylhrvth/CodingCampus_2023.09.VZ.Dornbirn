using System;
using System.IO;

// Interface für den Dateiempfänger
public interface IFileReceiver
{
    void OnFileReceived(int depth, string path);
    void OnDirectoryReceived(int depth, string path);
}

// Klasse, um die Anzahl der Dateien und Ordner zu zählen
public class FileAndFolderCounter : IFileReceiver
{
    private int fileCount;
    private int folderCount;

    public void OnFileReceived(int depth, string path)
    {
        fileCount++;
    }

    public void OnDirectoryReceived(int depth, string path)
    {
        folderCount++;
    }

    public void PrintCount()
    {
        Console.WriteLine($"Anzahl der Dateien: {fileCount}");
        Console.WriteLine($"Anzahl der Ordner: {folderCount}");
    }
}

// Klasse, um die Größe aller Dateien zu berechnen
public class FileSizeCalculator : IFileReceiver
{
    private long totalSize;

    public void OnFileReceived(int depth, string path)
    {
        FileInfo fileInfo = new FileInfo(path);
        totalSize += fileInfo.Length;
    }

    public void OnDirectoryReceived(int depth, string path)
    {
        // Ignoriere Ordner für diese Aufgabe
    }

    public void PrintTotalSize()
    {
        Console.WriteLine($"Gesamtgröße aller Dateien: {totalSize} Bytes");
    }
}

// Klasse, um das Dateisystem auszugeben
public class FileSystemPrinter : IFileReceiver
{
    public void OnFileReceived(int depth, string path)
    {
        Console.WriteLine($"Datei gefunden auf Ebene {depth}: {path}");
    }

    public void OnDirectoryReceived(int depth, string path)
    {
        Console.WriteLine($"Ordner gefunden auf Ebene {depth}: {path}");
    }
}

// Klasse, um die Anzahl der Dateien mit einer bestimmten Endung zu zählen
public class FileExtensionCounter : IFileReceiver
{
    private string targetExtension;
    private int fileCount;

    public FileExtensionCounter(string targetExtension)
    {
        this.targetExtension = targetExtension;
    }

    public void OnFileReceived(int depth, string path)
    {
        if (Path.GetExtension(path).Equals(targetExtension, StringComparison.OrdinalIgnoreCase))
        {
            fileCount++;
        }
    }

    public void OnDirectoryReceived(int depth, string path)
    {
        // Ignoriere Ordner für diese Aufgabe
    }

    public void PrintFileCount()
    {
        Console.WriteLine($"Anzahl der Dateien mit der Erweiterung '{targetExtension}': {fileCount}");
    }
}

// Hauptmethode zum Navigieren durch das Dateisystem
public class FileSystemNavigator
{
    public static void NavigateFileSystem(string path, IFileReceiver fileReceiver, int depth = 0)
    {
        // Verarbeite den aktuellen Ordner
        fileReceiver.OnDirectoryReceived(depth, path);

        try
        {
            // Durchlaufe Dateien
            foreach (string file in Directory.GetFiles(path))
            {
                fileReceiver.OnFileReceived(depth + 1, file);
            }

            // Durchlaufe Unterordner
            foreach (string directory in Directory.GetDirectories(path))
            {
                NavigateFileSystem(directory, fileReceiver, depth + 1);
            }
        }
        catch (UnauthorizedAccessException)
        {
            // Kein Zugriff auf bestimmte Ordner, kann ignoriert werden
        }
    }

    public static void Start()
    {
        // Beispielaufrufe
        string basePath = @"C:\Users\daae\source\repos\CodingCampus_2023.09.VZ.Dornbirn\DarioLuis";

        FileAndFolderCounter counter = new FileAndFolderCounter();
        NavigateFileSystem(basePath, counter);
        counter.PrintCount();

        FileSizeCalculator sizeCalculator = new FileSizeCalculator();
        NavigateFileSystem(basePath, sizeCalculator);
        sizeCalculator.PrintTotalSize();

        //FileSystemPrinter fileSystemPrinter = new FileSystemPrinter();
        //NavigateFileSystem(basePath, fileSystemPrinter);

        //FileExtensionCounter extensionCounter = new FileExtensionCounter(".txt");
        //NavigateFileSystem(basePath, extensionCounter);
        //extensionCounter.PrintFileCount();
    }
}

