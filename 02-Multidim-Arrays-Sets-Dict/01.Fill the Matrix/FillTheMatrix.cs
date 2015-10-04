using System;

class FillTheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // input n

        // Matrix 1 - Regular Pattern.
        int[,] boringMatrix = new int[n, n];
        int count = 1;

        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                boringMatrix[row, col] = count;
                count++;
            }
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0} ", boringMatrix[row, col]);
            }

            Console.WriteLine();
        }

        // Matrix 2 - Irregular pattern.
        int[,] wowMatrix = new int[n, n];
        count = 1;
        for (int col = 0; col < n; col++)
        {
            // Regular columns.
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    wowMatrix[row, col] = count;
                    count++;
                }
            }
            // Reversed columns.
            else
            {
                for (int row = (n - 1); row >= 0; row--)
                {
                    wowMatrix[row, col] = count;
                    count++;
                }
            }
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0} ", wowMatrix[row, col]);
            }

            Console.WriteLine();
        }
    }
}

