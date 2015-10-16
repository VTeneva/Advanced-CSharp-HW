using System;
using System.Collections.Generic;
using System.Linq;

class StringLength
{
    static void Main()
    {
        string input = Console.ReadLine();
        string extract = input.PadRight(20, '*').Substring(0, 20);

        Console.WriteLine(extract);
    }
}

