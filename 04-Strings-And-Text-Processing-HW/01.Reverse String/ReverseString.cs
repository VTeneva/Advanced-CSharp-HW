using System;

class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(ReverseInputString(input)); 
    }

    static string ReverseInputString(string inputString)
    {
        char[] reversedString = inputString.ToCharArray();
        for (int i = 0; i < inputString.Length; i++)
        {
            reversedString[i] = inputString[inputString.Length - 1 - i];
        }
        return string.Join("", reversedString);
    }
}

