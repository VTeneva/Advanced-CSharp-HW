using System.IO;

class CopyBinaryFile
{
    static void Main()
    {
        using (FileStream inputImage = new FileStream("../../image.jpg", FileMode.Open))
        {
            using (FileStream outputImage = new FileStream("../../image_result.jpg", FileMode.Create))
            {
                byte[] buffer = new byte[4096];

                while (true)
                {
                    int readBytes = inputImage.Read(buffer, 0, buffer.Length);

                    if (readBytes == 0)
                    {
                        break;
                    }

                    outputImage.Write(buffer, 0, readBytes);
                }
            }
        }
    }
}

