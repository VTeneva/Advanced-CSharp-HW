using System;
using System.Collections.Generic;
using System.Linq;

class SubsetSums
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> inDups = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> input = inDups.Distinct().ToList(); // Removes duplicates.

        int isEqual = 0; // Flag for no matching subsets.

        for (int i = 1; i <= Math.Pow(2, input.Count) - 1; i++)
        {
            List<int> subset = new List<int>();

            for (int j = 0; j < input.Count; j++)
            {
                if (((i & (1 << j)) >> j) == 1)
                {
                    subset.Add(input[j]); // Mask implementing on input list.
                }
            }

            if (subset.Sum() == n)
            {
                Console.WriteLine(string.Join(" + ", subset) + " = " + n); // Prints the list of sum of items is equal to n.
                isEqual = 1;
            }
        }

        if (isEqual == 0)
        {
            Console.WriteLine("No matching subsets."); //In case of no matching subsets.
        }
    }
}

