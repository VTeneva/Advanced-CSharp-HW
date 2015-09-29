using System;
using System.Linq;

class SortArrayOfNumbers
{
    static void Main()
    {
        int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Array.Sort(inputArr);

        Console.WriteLine(string.Join(" ", inputArr));
    }
}       

