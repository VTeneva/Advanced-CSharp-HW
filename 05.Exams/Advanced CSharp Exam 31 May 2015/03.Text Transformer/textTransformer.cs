using System;
using System.Text;

class TextTransformer
{
    static void Main()
    {
        StringBuilder input = new StringBuilder();

        string line = Console.ReadLine();

        while (line != "burp")
        {
            input.Append(line);

            line = Console.ReadLine();
        }

        
    }
}

