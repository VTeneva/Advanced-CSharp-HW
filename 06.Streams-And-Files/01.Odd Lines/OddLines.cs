using System;
using System.IO;


class OddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../Few lines.txt");

        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();

            while (line != null)
            {
                if (lineNumber % 2 == 1)
                {
                    Console.WriteLine("Line {0}: {1}",lineNumber, line);
                }
        
                lineNumber++;
                line = reader.ReadLine();
            }

            reader.Close();
        }
    }
}

