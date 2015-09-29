using System;
using System.Text;

class UnicodeChar
{
    static void Main()
    {
        string input = Console.ReadLine();

        Console.WriteLine("Method 1 - For-Loop");
        for (int letter = 0; letter < input.Length; letter++)
        {
            Console.Write("\\u{0:X4}", (int)input[letter]);
        }

        Console.WriteLine("\nMethod 2 - StringBulder");
        Console.WriteLine(GetUnicode(input));
    }

    static string GetUnicode(string strToConvert)
    {
        StringBuilder unicodeRepresentation = new StringBuilder();

        for (int letter = 0; letter < strToConvert.Length; letter++)
        {
            char currentChar = strToConvert[letter];
            unicodeRepresentation.Append("\\u" + ((int)currentChar).ToString("X4"));
        }

        return unicodeRepresentation.ToString();
    }
}

