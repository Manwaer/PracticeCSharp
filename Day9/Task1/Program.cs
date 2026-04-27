using Task1;

class Program
{
    static void Main()
    {
        string myDir = "/home/admin/Документы/GitHub/PracticeCSharp/Day9/Task1";
        string fileName = "potravnoy.mo";
        string filePath = Path.Combine(myDir, fileName);
            
        FileManager fm = new FileManager();
        FileInfoProvider fp = new FileInfoProvider();

        fm.CreateAndWrite(filePath, "че и сюда писать что то нужно? эх...");
        fm.ReadAndPrint(filePath);

        fp.DisplayFileInfo(filePath);
        fp.CheckPermissions(filePath);

        string copyPath = filePath + ".copy";
        fm.CopyFile(filePath, copyPath);
        fp.CompareFilesBySize(filePath, copyPath);

        fm.RenameFile(copyPath, "potravnoy_new.io");

        Console.WriteLine("\nВсе файлы в директории:");
        string[] allFiles = Directory.GetFiles(myDir);
        foreach (var f in allFiles) Console.WriteLine(Path.GetFileName(f));

        fm.SetReadOnly(filePath, true);
        try { fm.CreateAndWrite(filePath, "Новые данные"); }
        catch (Exception ex) { Console.WriteLine($"Блокировка сработала: {ex.Message}"); }
        fm.SetReadOnly(filePath, false);

        fm.DeleteFilesByPattern(myDir, "*.mo");
        fm.DeleteFile("potravnoy_new.io");
    }
}