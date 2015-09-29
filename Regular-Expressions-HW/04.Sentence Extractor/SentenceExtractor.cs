using System;
using System.Text.RegularExpressions;

class SentenceExtractor
{
    static void Main()
    {
        string word = Console.ReadLine();
        string text = Console.ReadLine();

        string pattern = string.Format(@"(?<=\s|^)[^!.?]*\b{0}\b[^!.?]*[!.?]", word);
        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

        foreach (Match sentence in matches)
        {
            Console.WriteLine(sentence.Groups[0]);
        }
    }
}
