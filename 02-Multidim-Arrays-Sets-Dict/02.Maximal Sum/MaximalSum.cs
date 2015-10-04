using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int[,] matrix = new int[dimensions[0], dimensions[1]];

        for (int rows = 0; rows < dimensions[0]; rows++)
        {
            int[] newRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int col = 0; col < dimensions[1]; col++)
            {
                matrix[rows, col] = newRow[col];
            }
        }
            
        // Calculates the sum of the elements of the platform.
        
        int maxSum = matrix[0, 0] + matrix[0 + 1, 0] + matrix[0 + 2, 0] +
                    matrix[0, 0 + 1] + matrix[0 + 1, 0 + 1] + matrix[0 + 2, 0 + 1] +
                    matrix[0, 0 + 2] + matrix[0 + 1, 0 + 2] + matrix[0 + 2, 0 + 2];
        int maxRow = 0;
        int maxCol = 0;

        for (int i = 0; i < dimensions[0] - 2; i++)
        {
            for (int j = 0; j < dimensions[1] - 2; j++)
            {
               int sum = matrix[i, j] + matrix[i + 1, j] + matrix[i + 2, j] +
                    matrix[i, j + 1] + matrix[i + 1, j + 1] + matrix[i + 2, j + 1] +
                    matrix[i, j + 2] + matrix[i + 1, j + 2] + matrix[i + 2, j + 2];
                if(sum > maxSum)
                {
                    maxSum = sum;
                    maxRow = i;
                    maxCol = j;
                }
            }
        }

        Console.WriteLine("Sum = {0}", maxSum);

        for (int row = maxRow; row <= maxRow + 2; row++)
        {
            for (int col = maxCol; col <= maxCol + 2; col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
}

