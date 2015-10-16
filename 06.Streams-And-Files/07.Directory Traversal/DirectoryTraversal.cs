using System;
using System.IO;
using System.Collections.Generic;

class DirectoryTraversal
{
    static void Main()
    {
        Console.WriteLine("Enter the directory to be traversed:");
        string directory = Console.ReadLine(); ;

        Dictionary<string, Dictionary<string, long>> extFiles = new Dictionary<string, Dictionary<string, long>>();
        
        string[] files = Directory.GetFiles(directory);
        foreach (var file in files)
        {
            var fileInfo = new FileInfo(file);

            if (!extFiles.ContainsKey(fileInfo.Extension)) //Add file extension as key to dictionary
            {
                extFiles.Add(
                    fileInfo.Extension,
                    new Dictionary<string, long>()
                    );
            }
            if (!extFiles[fileInfo.Extension].ContainsKey(fileInfo.Name)) // Add new file to file extension key in dictionary.
            {
                extFiles[fileInfo.Extension].Add(
                        fileInfo.Name,
                        fileInfo.Length
                );
            }
        }

        // Create the report.
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        using (StreamWriter outputStream = new StreamWriter(String.Format(@"{0}\report.txt", path)))
        {
            foreach (var fileExt in extFiles)
            {
                outputStream.WriteLine(fileExt.Key);
                foreach (var fileName in fileExt.Value)
                {
                    outputStream.WriteLine("--{0} - {1}b", fileName.Key, fileName.Value);
                }
            }
        }
    }
}

