public class Program
{
    public static void Main(string[] args)
    {
        // string sourceFilePath = "E:\\Source.txt";
        // string destinationFilePath = "E:\\Destination.txt";
        // File.Copy(sourceFilePath, destinationFilePath, true);

        // Console.WriteLine($"File copied from {sourceFilePath} to {destinationFilePath}. File exists: {File.Exists(destinationFilePath)}");


        // FileInfo fileInfo = new FileInfo(destinationFilePath);
        // Console.WriteLine($"File size: {fileInfo.Length} bytes");


        string filePath = "E:\\FileNew";
        // Directory.CreateDirectory(filePath);
        DirectoryInfo directoryInfo = new DirectoryInfo(filePath);
        directoryInfo.Create();


    }
}