using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class TextFilter
{
    static void Main()
    {
        List<string> ban = Console.ReadLine().
            Split(new string[] { ", " },
            StringSplitOptions.None).
            ToList();
        string text = Console.ReadLine();

        Console.WriteLine(BanTextFilter(text, ban));
    }

    static string BanTextFilter(string inputText, List<string> censor)
    {
        StringBuilder text = new StringBuilder();
        text.Append(inputText);

        for (int censorWord = 0; censorWord < censor.Count; censorWord++)
        {
            text.Replace(censor[censorWord], new string('*', censor[censorWord].Length));
        }

        return text.ToString();
    }
}

