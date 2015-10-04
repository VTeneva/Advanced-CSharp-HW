using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class WordCount
{
    static void Main()
    {
        StreamReader words = new StreamReader("../../words.txt");
        StreamWriter writer = new StreamWriter("../../results.txt");

        using (words)
        {
            using (writer)
            {
                Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
                string word = words.ReadLine();

                while (word != null)
                {
                    int wordCount = 0;
                    wordFrequency.Add(word, wordCount);

                    using (var text = new StreamReader("../../text.txt"))
                    {
                        string textLine = text.ReadLine();
                        while (textLine != null)
                        {
                            string[] wordsInLine = textLine.Split(new string[] { " ", ",", "!", ".", "?", ":", ";", "-" },
                                StringSplitOptions.RemoveEmptyEntries);
                            var matchWord = from wordInLine in wordsInLine
                                            where wordInLine.ToUpper() == word.ToUpper()
                                            select word;

                            wordCount += matchWord.Count();
                            wordFrequency[word] = wordCount;

                            textLine = text.ReadLine();
                        }

                        text.Close();
                    }
                    word = words.ReadLine();
                }

                
                foreach (var wrd in wordFrequency.OrderByDescending(wrd => wrd.Value))
                {
                    writer.WriteLine("{0} -> {1}", wrd.Key, wrd.Value);
                }             
            }
        }
    }
}

