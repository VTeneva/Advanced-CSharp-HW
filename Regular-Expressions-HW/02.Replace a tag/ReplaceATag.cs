using System;
using System.Text.RegularExpressions;

class ReplaceATag
{
    static void Main()
    {
        string input = Console.ReadLine();

        string pattern = @"<a.*href=((?:.|\n)*?(?=>))>((?:.|\n)*?(?=<))<\/a>";
        string replacement = @"[URL href=$1]$2[/URL]";

        var newString = Regex.Replace(input, pattern, replacement);
        Console.WriteLine(newString);
    }
}

