using System;
using System.Linq;
using System.Collections.Generic;

class StuckNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        bool noStuck = true;
        for (int n1 = 0; n1 < input.Count; n1++)
        {
            for (int n2 = 0; n2 < input.Count; n2++)
            {
                for (int n3 = 0; n3 < input.Count; n3++)
                {
                    for (int n4 = 0; n4 < input.Count; n4++)
                    {
                        if (input[n1].CompareTo(input[n2]) != 0 && input[n1].CompareTo(input[n3]) != 0 &&
                            input[n1].CompareTo(input[n4]) != 0 && input[n2].CompareTo(input[n3]) != 0 &&
                            input[n2].CompareTo(input[n4]) != 0 && input[n3].CompareTo(input[n4]) != 0)
                        {
                            if ("" + input[n1] + input[n2] == "" + input[n3] + input[n4])
                            {
                                Console.WriteLine("{0}|{1}=={2}|{3}", input[n1], input[n2], input[n3], input[n4]);
                                noStuck = false;
                            }
                        }
                    }
                }            
            }
        }

        if (noStuck)
        {
            Console.WriteLine("No"); //No stuck numbers.
        }
    }
}
