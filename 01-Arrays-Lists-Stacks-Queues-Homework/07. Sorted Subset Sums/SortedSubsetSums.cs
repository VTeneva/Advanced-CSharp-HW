using System;
using System.Collections.Generic;
using System.Linq;

class SortedSubsetSums
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> inDups = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> input = inDups.Distinct().ToList(); // Removes duplicates.

        int isEqual = 0; // Flag for no matching subsets.

        List<List<int>> subsetLists = new List<List<int>>();

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
                subset.Sort();
                subsetLists.Add(subset); // List of all lists

                isEqual = 1;
            }
        }

        subsetLists = subsetLists.OrderBy(subset => subset.Count).ThenBy(subset => subset.First()).ToList(); // Sort each subset in subsetList by length and then by first element.
        subsetLists.ForEach(subset => Console.WriteLine(string.Join(" + ", subset) + " = " + n)); //Print each subset.

        if (isEqual == 0)
        {
            Console.WriteLine("No matching subsets."); // In case of no matching subsets.
        }
    }
}
