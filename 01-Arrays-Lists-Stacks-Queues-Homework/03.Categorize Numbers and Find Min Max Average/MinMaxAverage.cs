using System;
using System.Collections.Generic;
using System.Linq;

class MinMaxAverage
{
    static void Main()
    {
        List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList(); //Input


        List<int> integers = new List<int>();
        List<double> doubles = new List<double>();

        for (int i = 0; i <= input.Count - 1; i++)
        {
            if (input[i] == Math.Floor(input[i])) // Checks if numbers are integers
            {
                integers.Add((int)input[i]);
            }
            else
            {
                doubles.Add(input[i]);
            }
        }

        if (doubles.Count > 0)
        {
            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, average: {4:F2}",
        string.Join(" ", doubles), doubles.Min(), doubles.Max(), doubles.Sum(), doubles.Average()); //Prints results - list of doubles
        }

        if (integers.Count > 0)
        {
            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, average: {4:F2}",
            string.Join(" ", integers), integers.Min(), integers.Max(), integers.Sum(), integers.Average()); //Prints results - list of integers
        }
    }
}

