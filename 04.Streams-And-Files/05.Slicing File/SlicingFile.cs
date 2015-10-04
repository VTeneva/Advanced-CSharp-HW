using System;
using System.IO;

class SlicingFile
{
    static void Main()
    {
        string source = "../../iceland_fjallabak_09_big.jpg";
        string destination = @"E:\SoftUni\Advanced CSharp\Advanced CSharp\04.Streams-And-Files\05.Slicing File";
        int parts = 5;

        Slice(source, destination, parts);
    }

    static void Slice(string sourceFile, string destinationDirectory, int parts)
    {
        using (FileStream input = new FileStream(sourceFile, FileMode.Open))
        {
            string extension = sourceFile.Substring(sourceFile.LastIndexOf('.'));

            byte[] buffer = new byte[input.Length / parts];
            long bytesRead = 0;

            for (int part = 1; part <= parts; part++)
            {
                using (FileStream output = new FileStream(destinationDirectory + @"\Part " + part + extension, FileMode.Create))
                {
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

    }
}

