using System;
using System.Collections.Generic;
using System.Linq;

class CountSymbol
{
    static void Main()
    {
        char[] text = Console.ReadLine().ToCharArray(); // Read in the string.
        char[] symbols = text.Distinct().ToArray(); // Remove duplicated symbols.
        Array.Sort(symbols); // Sort string.

        for (int symb = 0; symb < symbols.Length; symb++)
        {
            int counter = 0;
            for (int textChar = 0; textChar < text.Length; textChar++)
            {         
                if (symbols[symb] == text[textChar])
                {
                    counter++;
                }              
            }
            Console.WriteLine("{0}: {1} time/s", symbols[symb], counter);
        }
    }
}

