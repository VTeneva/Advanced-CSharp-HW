using System;
using System.Text.RegularExpressions;

class SeriesOfLetters
{
    static void Main()
    {
        string input = Console.ReadLine();

        string pattern;
        string replacement;
        for (int letter = 0; letter < input.Length; letter++)
        {
            pattern = string.Format(@"{0}+", input[letter]);
            replacement = string.Format(@"{0}", input[letter]);

            Regex regex = new Regex(pattern);
            input = regex.Replace(input, replacement);
        }

        Console.WriteLine(input);
    }
}

