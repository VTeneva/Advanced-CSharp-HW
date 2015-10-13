using System;
using System.Linq;

class BunkerBuster
{
    static void Main()
    {
        // Field dimensions
        int[] dimensions = Console.ReadLine().Split('\u0020').Select(int.Parse).ToArray();

        // Field
        int[,] field = new int[dimensions[0], dimensions[1]];
        
        for (int n = 0; n < dimensions[0]; n++)
        {
            int[] fieldLine = Console.ReadLine().Split('\u0020').Select(int.Parse).ToArray();

            for (int m = 0; m < dimensions[1]; m++)
            {
                field[n, m] = fieldLine[m];
            }
        }

        // Bomb power
        

        string line = Console.ReadLine();
        while (line != "cease fire!")
        {
            char[] bomb = line.Split('\u0020').Select(char.Parse).ToArray();

            int row = int.Parse(bomb[0].ToString());
            int col = int.Parse(bomb[1].ToString());

            decimal bombPowerInTwo = Math.Round((decimal)bomb[2] / 2, 0, MidpointRounding.AwayFromZero);

            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = col - 1; j <= col + 1 ; j++)
                {
                    if (i == row && j == col)
                    {
                        field[row, col] = field[row, col] - (int)bomb[2];
                    }
                    else if(i >= 0 && j >= 0 && i < dimensions[0] && j < dimensions[1])
                    {
                        field[i, j] = field[i, j] - (int)bombPowerInTwo;
                    }
                }
            }

            line = Console.ReadLine();
        }

        double defeated = 0;
        for (int n = 0; n < dimensions[0]; n++)
        {
            for (int m = 0; m < dimensions[1]; m++)
            {
                if (field[n, m] <= 0)
                {
                    defeated++;
                }               
            }
        }

        Console.WriteLine("Destroyed bunkers: {0}", defeated);
        Console.WriteLine("Damage done: {0:F1} %", Math.Round(defeated / (dimensions[0] * dimensions[1]) * 100, 1, MidpointRounding.AwayFromZero));
    }
}

