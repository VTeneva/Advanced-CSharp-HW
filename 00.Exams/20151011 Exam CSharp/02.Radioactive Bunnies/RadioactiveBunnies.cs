using System;
using System.Linq;
using System.Collections.Generic;

class RadioactiveBunnies
{
    public static void Main()
    {
        List<int> fieldDim = Console.ReadLine().
            Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).
            Select(int.Parse).ToList();

        n = fieldDim[0];
        m = fieldDim[1];

        field = new char[n, m];

        for (int row = 0; row < n; row++)
        {
            char[] line = Console.ReadLine().ToCharArray();

            for (int col = 0; col < m; col++)
            {
                field[row, col] = line[col];
            }
        }

        // Player coordinates

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                if (field[row, col] == 'P')
                {
                    player = new List<int> { row, col };
                }
            }
        }

        // Bunnies coordinates

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                if (field[row, col] == 'B')
                {
                    List<int> bunny = new List<int> { row, col };
                    bunnies.Add(bunny);
                }
            }
        }

        // Commands
        char[] commands = Console.ReadLine().ToCharArray();


        // Play the game
        foreach (char command in commands)
        {
            // Player
            List<int> playerNextMove = new List<int> { player[0], player[1] };

            switch (command)
            {
                case 'R':
                    // col
                    if (playerNextMove[1] + 1 < m)
                    {
                        playerNextMove[1] += 1;
                    }
                    else
                    {
                        IsOut = true;
                    }
                    ; break;

                case 'L':
                    //  col
                    if (playerNextMove[1] - 1 >= 0)
                    {
                        playerNextMove[1] -= 1;
                    }
                    else
                    {
                        IsOut = true;
                    }
                    ; break;

                case 'U':
                    // row
                    if (playerNextMove[0] - 1 >= 0)
                    {
                        playerNextMove[0] -= 1;
                    }
                    else
                    {
                        IsOut = true;
                    }
                    ; break;

                case 'D':
                    // row
                    if (playerNextMove[0] + 1 < n)
                    {
                        playerNextMove[0] += 1;
                    }
                    else
                    {
                        IsOut = true;
                    }
                    ; break;
                default:
                    break;
            }


            if (field[playerNextMove[0], playerNextMove[1]] == 'B')
            {
                isDead = true;
                field[player[0], player[1]] = '.';
                player[0] = playerNextMove[0];
                player[1] = playerNextMove[1];
            }

            else if(!IsOut)
            {
                field[player[0], player[1]] = '.';
                player[0] = playerNextMove[0];
                player[1] = playerNextMove[1];
                field[player[0], player[1]] = 'P';
            }

            if (IsOut)
            {
                field[player[0], player[1]] = '.';
            }

            // Bunnies spread
            BunniesSpread();


            if (isDead)
            {
                DrawField();
                Console.WriteLine("dead: {0} {1}", player[0], player[1]);
                break;
            }
            if (IsOut)
            {
                break;
            }
        }

        if (!isDead)
        {
            field[player[0], player[1]] = '.';
            DrawField();
            Console.WriteLine("won: {0} {1}", player[0], player[1]);
        }


    }

    public static bool IsOut = false;
    public static bool isDead = false;

    public static int n = 0;
    public static int m = 0;

    public static char[,] field;

    public static List<int> player = new List<int>();
    public static List<List<int>> bunnies = new List<List<int>>();

    public static void BunniesSpread()
    {
        List<List<int>> bunniesAdd = new List<List<int>>();

        foreach (List<int> bunny in bunnies)
        {
            List<int> newBunny = new List<int>();

            // spread up
            if (bunny[0] - 1 >= 0)
            {
                newBunny = new List<int> { bunny[0] - 1, bunny[1] };
                bunniesAdd.Add(newBunny);
            }

            // spread down
            if (bunny[0] + 1 < n)
            {
                newBunny = new List<int> { bunny[0] + 1, bunny[1] };
                bunniesAdd.Add(newBunny);
            }

            // spread left
            if (bunny[1] - 1 >= 0)
            {
                newBunny = new List<int> { bunny[0], bunny[1] - 1 };
                bunniesAdd.Add(newBunny);
            }


            // spread right
            if (bunny[1] + 1 < m)
            {
                newBunny = new List<int> { bunny[0], bunny[1] + 1 };
                bunniesAdd.Add(newBunny);
            }

        }

        foreach (List<int> bunny in bunniesAdd)
        {
            if (field[bunny[0], bunny[1]] == 'P')
            {
                isDead = true;
            }
                field[bunny[0], bunny[1]] = 'B';

        }

        bunnies.AddRange(bunniesAdd);
    }

    public static void DrawField()
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write(field[row, col]);
            }
            Console.WriteLine("");
        }
    }
}

