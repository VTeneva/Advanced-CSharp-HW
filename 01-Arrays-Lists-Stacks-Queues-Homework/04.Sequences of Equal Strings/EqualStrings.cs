using System;
using System.Collections.Generic;
using System.Linq;


class EqualStrings
{
    static void Main()
    {
        List<string> input = Console.ReadLine().Split(' ').ToList();

        Console.Write(input[0] + ' ');

        for (int i = 1; i < input.Count; i++)
        {
            if (input[i] == input[i - 1])
            {
                Console.Write(input[i] + ' ');
            }
            else
            {
                Console.Write("\n" + input[i] + ' ');
            }
        }

    }
}

