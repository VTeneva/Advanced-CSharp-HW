using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Enter all integers in a line separated by comma (',')!");
        int[] numbersInput = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

        Console.WriteLine(FirstLarger(numbersInput));
    }

    static int FirstLarger(int[] nums)
    {
        int firstLargerPosition = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            // First element
            if (i == 0)
            {
                if (nums[i] > nums[i + 1])
                {
                    firstLargerPosition = i;
                    return firstLargerPosition;
                }
            }

            // Elements with 2 neighbours.
            if (i > 0 && i < nums.Length - 1) 
            {
                if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
                {
                    firstLargerPosition = i;
                    return firstLargerPosition;
                }
            }

            // Last element.
            if (i == nums.Length - 1) 
            {
                if (nums[i] > nums[i - 1])
                {
                    firstLargerPosition = i;
                    return firstLargerPosition;
                }
            }
        }
        return firstLargerPosition;
    }
}
