using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class CommandInterpreter
{
    static void Main()
    {
        List<int> input = Console.ReadLine().
            Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).
            Select(int.Parse).
            ToList();

        string line = Console.ReadLine();
        while (line != "end")
        {
            string pattern = @"\d";
            Regex regex = new Regex(pattern);
            MatchCollection match = regex.Matches(line);

            for (int start = int.Parse(match[0].Value), end = int.Parse(match[0].Value) + int.Parse(match[1].Value); 
                start <= int.Parse(match[0].Value) + int.Parse(match[1].Value); 
                start++, end--)
            {
                int tempNum = input[start];
                input[start] = input[end];
                input[end] = tempNum;
            }

            line = Console.ReadLine();
        }
        
        
    }
}

