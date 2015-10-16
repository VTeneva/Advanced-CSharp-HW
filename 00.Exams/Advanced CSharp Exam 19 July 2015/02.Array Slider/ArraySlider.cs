using System;
using System.Linq;
using System.Collections.Generic;

class ArraySlider
{
    static void Main()
    {
        List<long> numbers = Console.ReadLine().
            Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).
            Select(long.Parse).
            ToList();

        int currentPosition = 0;
        int offset = 0;

        string line = Console.ReadLine();
        while (line != "stop")
        {
            List<string> command = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            // Offset 
            offset = int.Parse(command[0]) % numbers.Count;

            currentPosition += offset;
            if (currentPosition < 0)
            {
                currentPosition = numbers.Count + currentPosition;
            }
            else if (currentPosition >= numbers.Count)
            {
                currentPosition = currentPosition - numbers.Count;
            }

            // Operation and operand
            switch (command[1])
            {
                case "&":
                    numbers[currentPosition] = numbers[currentPosition] & long.Parse(command[2]); break;
                case "|":
                    numbers[currentPosition] = numbers[currentPosition] | long.Parse(command[2]); break;
                case "^":
                    numbers[currentPosition] = numbers[currentPosition] ^ long.Parse(command[2]); break;
                case "+":
                    numbers[currentPosition] = numbers[currentPosition] + long.Parse(command[2]); break;
                case "-":
                    numbers[currentPosition] = numbers[currentPosition] - long.Parse(command[2]); break;
                case "*":
                    numbers[currentPosition] = numbers[currentPosition] * long.Parse(command[2]); break;
                case "/":
                    numbers[currentPosition] = numbers[currentPosition] / long.Parse(command[2]); break;
                default:
                    break;
            }

            if (numbers[currentPosition] < 0)
            {
                numbers[currentPosition] = 0;
            }

            // Next command line
            line = Console.ReadLine();
        }

        Console.WriteLine("[{0}]", string.Join(", ", numbers));
    }
}