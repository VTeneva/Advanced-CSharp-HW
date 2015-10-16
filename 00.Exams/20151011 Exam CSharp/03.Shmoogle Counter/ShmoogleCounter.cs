using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

class ShmoogleCounter
{
    static void Main()
    {

        string patternInt = @"(?<=int\s)\w*";
        Regex regexInt = new Regex(patternInt);

        string patternDouble = @"(?<=double\s)\w*";
        Regex regexDouble = new Regex(patternDouble);

        List<string> ints = new List<string>();
        List<string> doubles = new List<string>();

        string line = Console.ReadLine();

        while (line != @"//END_OF_CODE")
        {
            MatchCollection intMatch = regexInt.Matches(line);
            MatchCollection doubleMatch = regexDouble.Matches(line);

            foreach (Match item in intMatch)
            {
                ints.Add(item.ToString());
            }

            foreach (Match item in doubleMatch)
            {
                doubles.Add(item.ToString());
            }

            line = Console.ReadLine();
        }

        ints.Sort();
        doubles.Sort();

        ints.Distinct().ToList();
        doubles.Distinct().ToList();

        if (doubles.Count == 0)
        {
            Console.WriteLine("Doubles: None");
        }
        else { Console.WriteLine("Doubles: {0}", string.Join(", ", doubles)); }

        if (ints.Count == 0)
        {
            Console.WriteLine("Ints: None");
        }
        else { Console.WriteLine("Ints: {0}", string.Join(", ", ints)); }

    }
}

