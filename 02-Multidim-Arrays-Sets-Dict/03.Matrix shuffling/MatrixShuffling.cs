using System;
using System.Linq;

class MatrixShuffling
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        // Read in the matrix.
        string[,] matrix = new string[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }

        // Execute swap command.
        bool breakComm = false;

        do
        {
            string[] command = Console.ReadLine().Split(' ').ToArray();// Reads-in the input command
            if (command[0] == "END")
            {
                breakComm = true;
            }
            else if (command[0] == "swap")
            {
                if (int.Parse(command[1]) > rows - 1 || int.Parse(command[3]) > rows ||
                    int.Parse(command[2]) > cols - 1 || int.Parse(command[4]) > cols)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    string tempVar = matrix[int.Parse(command[1]), int.Parse(command[2])];
                    matrix[int.Parse(command[1]), int.Parse(command[2])] = matrix[int.Parse(command[3]), int.Parse(command[4])];
                    matrix[int.Parse(command[3]), int.Parse(command[4])] = tempVar;


                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            Console.Write("{0} ", matrix[row, col]);
                        }
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        } while (breakComm == false);
    }
}
