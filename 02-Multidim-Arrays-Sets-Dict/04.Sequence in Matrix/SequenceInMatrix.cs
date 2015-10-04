using System;
using System.Collections.Generic;
using System.Linq;


class SequenceInMatrix
{
    static void Main()
    {
        Console.WriteLine("Number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Nomber of cols: ");
        int cols = int.Parse(Console.ReadLine());

        // Read in the matrix.
        Console.WriteLine("Fill the matrix as each element to be added in separate line.");
        string[,] matrix = new string[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.WriteLine("Element [{0}, {1}]", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }

        // Find the longest sequence.

        int maxLength = 0;
        int maxRow = 0;
        int maxCol = 0;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                // Case 1. Line
                int counterLine = 1;
                for (int n = col + 1; n < cols; n++)
                {                   
                    if (matrix[row, col] == matrix[row, n])
                    {
                        counterLine++;
                    }
                    else
                    {
                        break;
                    }

                    if (counterLine > maxLength)
                    {
                        maxLength = counterLine;
                        maxCol = col;
                        maxRow = row;
                    }
                }

                // Case 2. Column
                int counterCol = 1;
                for (int n = row + 1; n < rows; n++)
                {
                    if (matrix[row, col] == matrix[n, col])
                    {
                        counterCol++;
                    }
                    else
                    {
                        break;
                    }

                    if (counterCol > maxLength)
                    {
                        maxLength = counterCol;
                        maxCol = col;
                        maxRow = row;
                    }
                }

                // Case 3. Diagonal
                int counterDiag = 1;
                for (int n = row + 1, m = col + 1; n < rows && m < cols; n++, m++)
                {     
                    if (matrix[row, col] == matrix[n, m])
                    {
                        counterDiag++;
                    }
                    else
                    {
                        break;
                    }

                    if (counterDiag > maxLength)
                    {
                        maxLength = counterDiag;
                        maxCol = col;
                        maxRow = row;
                    }
                    
                }

                // Case 3. Reversed Diagonal
                int counterDiagRev = 1;
                for (int n = row - 1, m = col - 1; n >= 0 && m >= 0; n--, m--)
                {
                    if (matrix[row, col] == matrix[n, m])
                    {
                        counterDiagRev++;
                    }
                    else
                    {
                        break;
                    }

                    if (counterDiagRev > maxLength)
                    {
                        maxLength = counterDiagRev;
                        maxCol = col;
                        maxRow = row;
                    }
                }
            }
        }

        //The longest sequence - output
        for (int i = 1; i < maxLength; i++)
        {
            Console.Write("{0}, ", matrix[maxRow, maxCol]);
        }
        Console.WriteLine(matrix[maxRow, maxCol]);
    }
}

