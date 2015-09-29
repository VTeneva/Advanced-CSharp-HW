using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Enter all integers in a line separated by comma (',')!");
        int[] numbersInput = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

        for (int i = 0; i < numbersInput.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbersInput, i));
        }
    }

    static bool IsLargerThanNeighbours(int[] nums, int i)
    {
        bool isLarger = false;
        // First element
        if (i == 0)
        {
            if (nums[i] > nums[i + 1])
            {
                isLarger = true;
            }
        }

        if (i > 0 && i < nums.Length - 1) // Elements with 2 neighbours.
        {
            if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
            {
                isLarger = true;
            }
        }

        if (i == nums.Length - 1) // Last element.
        {
            if (nums[i] > nums[i - 1])
            {
                isLarger = true;
            }
        }

        return isLarger;
    }
}

