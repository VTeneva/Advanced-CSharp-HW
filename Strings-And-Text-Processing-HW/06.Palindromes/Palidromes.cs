using System;
using System.Collections.Generic;
using System.Linq;

class Palidromes
{
    static void Main()
    {
        List<string> words = Console.ReadLine().
            Split(new string[] { " ", ",", ".", "?", "!" }, 
            StringSplitOptions.RemoveEmptyEntries).
            ToList();

        List<string> palidromes = new List<string>();

        for (int word = 0; word < words.Count; word++)
        {
            if (string.Compare(words[word], ReverseString(words[word]), false) == 0)
            {
                palidromes.Add(words[word]);
            }
        }

        palidromes.Sort();
        Console.WriteLine(string.Join(", ", palidromes));
    }

    static string ReverseString(string inputString)
    {
        char[] reversedString = inputString.ToCharArray();
        for (int i = 0; i < inputString.Length; i++)
        {
            reversedString[i] = inputString[inputString.Length - 1 - i];
        }
        return string.Join("", reversedString);
    }
}

