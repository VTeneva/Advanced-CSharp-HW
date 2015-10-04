using System;

class CollectTheCoins
{
    static void Main()
    {
        // Input.
        char[][] input = new char[4][];
        for (int i = 0; i < 4; i++)
        {
            string line = Console.ReadLine();
            input[i] = line.ToCharArray();
        }

        string commLine = Console.ReadLine();
        char[] commands = commLine.ToCharArray();

        // Executing commands.

        // Starting coordinates;
        int row = 0;
        int col = 0;
        // Counters of events.
        int coins = 0;
        int wallHits = 0;

        for (int comm = 0; comm < commands.Length; comm++)
        {
            // Movement of the object. New coordinates in the jagged array.
            // * Hitting wall - NOTE: If the wall had alredy been hit with the previos command and the current command remain the same,  
            // the wall would be hit again and respectively the value of the counter would be increased.
            if (commands[comm] == '^')
            {
                if (row > 0 && row <= 3 && col <= input[row-1].Length - 1)
                {
                    row -= 1;
                }
                else
                {
                    wallHits++;
                }
            }
            else if (commands[comm] == 'V')
            {
                if (row >= 0 && row < 3 && col <= input[row + 1].Length - 1)
                {
                    row += 1;
                }
                else
                {
                    wallHits++;
                }
            }
            else if (commands[comm] == '<')
            {
                if (col > 0 && col <= input[row].Length - 1)
                {
                    col -= 1;
                }
                else
                {
                    wallHits++;
                }
            }
            else if (commands[comm] == '>')
            {
                if (col >= 0 && col < input[row].Length - 1)
                {
                    col += 1;
                }
                else
                {
                    wallHits++;
                }
            }
            else
            {
                Console.WriteLine("Invalid command at step {0}!", (comm + 1)); // In case of invalid input command. 
            }

            // Collecting coins.
            if (input[row][col] == '$')
            {
                coins++;
            }
        }

        // Print results.
        Console.WriteLine("Coins collected: {0}", coins);
        Console.WriteLine("\nWalls hit: {0}", wallHits);
    }
}
