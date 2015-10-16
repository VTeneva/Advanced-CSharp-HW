using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string input = Console.ReadLine();
        string patternEMail = @"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@[a-z]+\-?[a-z]+(?:\.[a-z]+)+)\b";

        Regex regexEMail = new Regex(patternEMail);
        MatchCollection matches = regexEMail.Matches(input);

        foreach (Match name in matches)
        {
            Console.WriteLine(name.Groups[0]);
        }
    }
}

