using System;

class SubstringOccurence
{
    static void Main()
    {
        string input = Console.ReadLine().ToUpper();
        string target = Console.ReadLine().ToUpper();


        Console.WriteLine(CountOccurence(input, target));
    }

    static int CountOccurence(string input, string target)
    {
        int targetIndex = 0;
        int nextTarget = 0;
        int counter = 0;

        targetIndex = input.IndexOf(target, nextTarget);
        while (targetIndex != -1)
        {
            counter++;
            nextTarget = targetIndex + 1;
            targetIndex = input.IndexOf(target, nextTarget);
        }

        return counter;
    }
}

