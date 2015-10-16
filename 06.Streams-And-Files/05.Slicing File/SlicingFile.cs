using System.Collections.Generic;
using System.IO;

class SlicingFile
{
    static void Main()
    {
        string source = "../../iceland_fjallabak_09_big.jpg";
        string destination = "../../";
        int parts = 5;

        Slice(source, destination, parts);

        Assemble(filesToCombine, destination);
    }

    static List<string> filesToCombine = new List<string>();

    static void Slice(string sourceFile, string destinationDirectory, int parts)
    {
        using (FileStream input = new FileStream(sourceFile, FileMode.Open))
        {
            string extension = sourceFile.Substring(sourceFile.LastIndexOf('.'));

            byte[] buffer = new byte[input.Length / parts];
            long bytesRead = 0;

            for (int part = 1; part <= parts; part++)
            {
                using (FileStream output = new FileStream(destinationDirectory + @"File Part " + part + extension, FileMode.Create))
                {
                    filesToCombine.Add(destinationDirectory + @"File Part " + part + extension);

                    if (part < parts)
                    {
                        int readBytes = input.Read(buffer, 0, buffer.Length);
                        bytesRead += readBytes;

                        if (readBytes == 0)
                        {
                            break;
                        }

                        output.Write(buffer, 0, readBytes);
                    }
                    else
                    {
                        while (true)
                        {
                            int readBytes = input.Read(buffer, 0, buffer.Length);
                            bytesRead += readBytes;

                            if (readBytes == 0)
                            {
                                break;
                            }
                            output.Write(buffer, 0, readBytes);
                        }
                    }
                }
            }
        }
    }

    static void Assemble(List<string> files, string destinationDirectory)
    {
        string extension = files[0].Substring(files[0].LastIndexOf('.'));

        using (FileStream combined = new FileStream(destinationDirectory + "combined files" + extension, FileMode.Create))
        {
            for (int file = 0; file < files.Count; file++)
            {
                using (FileStream input = new FileStream(files[file], FileMode.Open))
                {
                    byte[] buffer = new byte[4096];

                    while (true)
                    {
                        int readBytes = input.Read(buffer, 0, buffer.Length);

                        if (readBytes == 0)
                        {
                            break;
                        }
                        combined.Write(buffer, 0, readBytes);
                    }
                }
            }
        }

    }
}

