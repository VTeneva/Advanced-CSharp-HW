using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        using (var reader = new StreamReader("../../Few lines.txt"))
        {
            using (var writer = new StreamWriter("../../Few lines - line number.txt"))
            {
                string line = reader.ReadLine();
                int lineNumber = 0;
                while (line != null)
                {
                    writer.WriteLine("Line {0}: {1}", lineNumber, line);
                    lineNumber++;
                    line = reader.ReadLine();
                }

                reader.Close();
                writer.Close();
            }
        }
    }
}

