using System;

class LastDigitOfNum
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        Console.WriteLine(GetLastDigitAsWord(input));
    }

    static string GetLastDigitAsWord(long n)
    {
        char[] digits = n.ToString().ToCharArray();
        char convert = digits[digits.Length - 1];

        string word;
        switch (convert)
        {
            case '1': word = "one"; break;
            case '2': word = "two"; break;
            case '3': word = "three"; break;
            case '4': word = "four"; break;
            case '5': word = "five"; break;
            case '6': word = "six"; break;
            case '7': word = "seven"; break;
            case '8': word = "eight"; break;
            case '9': word = "nine"; break;
            case '0': word = "zero"; break;
            default: word = "Error!"; break;
        }
        return word;
    }
}

