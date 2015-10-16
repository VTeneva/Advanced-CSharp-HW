using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

class ZippingSlicedFiles
{
    public static void Main()
    {
        string source = "../../iceland_fjallabak_09_big.jpg";
        string destination = @"../../";
        int parts = 3;

        SliceCompress(source, destination, parts);

        extensionSource = source.Substring(source.LastIndexOf('.'));
        Assemble(filesToCombine, destination);
    }

    static string extensionSource;

    static List<string> filesToCombine = new List<string>();

    static void SliceCompress(string sourceFile, string destinationDirectory, int parts)
    {
        using (FileStream input = new FileStream(sourceFile, FileMode.Open))
        {
            string extension = ".gz";

            byte[] buffer = new byte[input.Length / parts];
            long bytesRead = 0;

            for (int part = 1; part <= parts; part++)
            {
                using (FileStream output = new FileStream(destinationDirectory + @"File Part " + part + extension, FileMode.Create))
                {
                    filesToCombine.Add(destinationDirectory + @"File Part " + part + extension);

                    using (GZipStream outputCompressed = new GZipStream(output, CompressionMode.Compress, false))
                    {
                        if (part < parts)
                        {
                            int readBytes = input.Read(buffer, 0, buffer.Length);
                            bytesRead += readBytes;

                            if (readBytes == 0)
                            {
                                break;
                            }

                            outputCompressed.Write(buffer, 0, readBytes);
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
                                outputCompressed.Write(buffer, 0, readBytes);
                            }
                        }
                    }
                }
            }
        }
    }

    static void Assemble(List<string> files, string destinationDirectory)
    {
        using (FileStream combined = new FileStream(destinationDirectory + "combined files" + extensionSource, FileMode.Create))
        {
            for (int file = 0; file < files.Count; file++)
            {
                using (FileStream input = new FileStream(files[file], FileMode.Open))
                {
                    using (GZipStream commpression = new GZipStream(input, CompressionMode.Decompress, false))
                    {
                        byte[] buffer = new byte[4096];

                        while (true)
                        {
                            int readBytes = commpression.Read(buffer, 0, buffer.Length);

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
}

