using System;
using System.Collections.Generic;
using System.Linq;


class ArrayManipulator
{
    static void Main()
    {
        //new string[] { " " }, StringSplitOptions.RemoveEmptyEntries

        List<int> input = Console.ReadLine().
            Split(' ').
            Select(int.Parse).
            ToList();

        List<string> commands = new List<string>();
        string line = Console.ReadLine();
        while (line != "end")
        {
            commands.Add(line);
            line = Console.ReadLine();
        }

        for (int comm = 0; comm < commands.Count; comm++)  
        {
            List<string> command = commands[comm].Split(' ').ToList();

            // Command - Exchange
            if (command[0] == "exchange")
            {
                if (int.Parse(command[1]) < 0 || int.Parse(command[1]) >= input.Count)
                {
                    Console.WriteLine("Invalid index");
                }
                else
                {
                    List<int> listBeforeIndex = new List<int>();
                    List<int> listAfterIndex = new List<int>();

                    foreach (var num in input)
                    {
                        if (input.IndexOf(num) <= int.Parse(command[1]))
                        {
                            listBeforeIndex.Add(num);
                        }
                        else { listAfterIndex.Add(num); }
                    }


                    input.RemoveAll(x => input.IndexOf(x) >= 0 && input.IndexOf(x) < input.Count());

                    input.AddRange(listAfterIndex);
                    input.AddRange(listBeforeIndex);
                }
            }
            else
            {
                List<int> numsManipulated = new List<int>(); 

                switch (command[command.Count - 1])
                {
                    case "even":
                        var evenList = from num in input
                                       where num % 2 == 0
                                       select num;

                        numsManipulated = evenList.ToList();
                        break;                        
                    case "odd":
                        var oddList = from num in input
                                      where num % 2 == 1
                                      select num;
                        numsManipulated = oddList.ToList();
                        break;
                    default:
                        break;
                }

                
                switch (command[0])
                {
                    // Command Max
                    case "max":
                        if (numsManipulated.Count == 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            int maxElement = numsManipulated.Max();
                            Console.WriteLine(input.LastIndexOf(maxElement));
                        }                                            

                        break;

                    // Command - Min
                    case "min":
                        if (numsManipulated.Count == 0)
                        {
                            Console.WriteLine("No matches");

                        }
                        else
                        {
                            int minElement = numsManipulated.Min();
                            Console.WriteLine(input.LastIndexOf(minElement));
                        }
                        break;

                    // Command - First
                    case "first":
                        int first = int.Parse(command[1]);
                        if (first > input.Count)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            if (numsManipulated.Count == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                List<int> firstNElements = new List<int>();
                                for (int i = 0; i < first; i++)
                                {
                                    if (i >= numsManipulated.Count)
                                    {
                                        break;
                                    }
                                    else { firstNElements.Add(numsManipulated[i]); }
                                }
                                Console.WriteLine("[{0}]", string.Join(", ", firstNElements));
                            }
                        };
                        break;

                    // Command - Last
                    case "last":
                        int last = int.Parse(command[1]);
                        if (last > input.Count)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            if (numsManipulated.Count == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                List<int> lastNElements = new List<int>();
                                for (int i = numsManipulated.Count - 1, numb = 1; numb <= last; i--, numb++)
                                {
                                    if (i < 0)
                                    {
                                        break;
                                    }
                                    else { lastNElements.Add(numsManipulated[i]); }
                                }
                                lastNElements.Reverse();
                                Console.WriteLine("[{0}]", string.Join(", ", lastNElements));
                            }
                        };
                        break;


                    default:
                        break;
                }
            }

        }

        // Print final array

        Console.WriteLine("[{0}]", string.Join(", ", input));
    }
}

