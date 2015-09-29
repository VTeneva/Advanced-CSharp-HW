using System;
using System.Linq;
using System.Collections.Generic;

class ReverseNumber
{
    static void Main()
    {
        double input = double.Parse(Console.ReadLine());
        Console.WriteLine(GetReversedNumber(input));
    }

    static double GetReversedNumber(double i)
    {
        // Double to string
        string number = i.ToString();

        // Remove the delimiter and reverse the digits
        List<char> reversed = i.ToString().Replace(".", "").ToCharArray().ToList();
        reversed.Reverse();

        // Insert the dilimer to the right position.
        reversed.Insert(number.IndexOf('.'), '.');             
        return (double.Parse(string.Join("", reversed)));
    }
}

