using System;
using System.Linq;
using System.Collections.Generic;

class LongestIncreasingSequence
{
    static void Main()
    {
        List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); // input

        List<string> workList = new List<string>();

        Console.Write("{0} ", input[0]);    // Prints first element

        workList.Add("/");                  // Adds '/' as first element of the list
        workList.Add(input[0].ToString());  // Adds first element to list

        for (int i = 1; i < input.Count; i++)
        {
            if (input[i] > input[i - 1])
            {
                Console.Write("{0} ", input[i]);
                workList.Add(input[i].ToString());
            }
            else
            {
                workList.Add("/");    // Adds '/' when the sequence ends.
                Console.Write("\n{0} ", input[i]);
                workList.Add(input[i].ToString());
            }
        }

        workList.Add("/");

        List<int> ch = workList.Select((s, index) => new { s, index }) //Puts the positions all '/'s into a list
                      .Where(x => x.s == "/")
                      .Select(x => x.index)
                      .ToList();


        int max = ch[1] - ch[0] - 1;
        int start = 0;
        int end = 1;

        for (int p = 2; p < ch.Count; p++)
        {
            if (max < (ch[p] - ch[p - 1] - 1))  //Finds the longest sequence and the position of '/'s 
            {
                start = p - 1;
                end = p;
            }
            max = Math.Max(max, (ch[p] - ch[p - 1] - 1));
        }

        Console.Write("\nLongest: ");
        for (int j = (ch[start] + 1); j < ch[end]; j++)
        {
            Console.Write(workList[j] + " "); // Prints the longest sequence
        }
    }
}

