using System;
using System.Linq;

class NumberCalculation
{
    static void Main()
    {
        Console.Write("Please select the type of the input numbers (choose between - int, double, decimal): ");
        string type = Console.ReadLine();
        Console.WriteLine("Enter the numbers in a single line separated by empty space: ");
        if (type == "int")
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            NumberCalculations(input);
        }
        else if (type == "double")
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            NumberCalculations(input);
        }
        else if (type == "decimal")
        {
            decimal[] input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            NumberCalculations(input);
        }
        else { Console.WriteLine("Invalid input!"); }
    }

    static void NumberCalculations(int[] nums)
    {
        // Max element.
        int max = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                max = nums[i];
            }
        }
        Console.WriteLine("Max element: {0}", max);

        // Min element.
        int min = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < nums[i - 1])
            {
                min = nums[i];
            }
        }
        Console.WriteLine("Min element: {0}", min);

        // Sum and average of elements.
        int sum = 0;
        foreach (var item in nums)
        {
            sum += item;
        }
        Console.WriteLine("Arithmetic mean of elements: {0}", sum/ nums.Length);
        Console.WriteLine("Sum of elements: {0}", sum);

        // Product of elements.
        int product = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            product = product * nums[i];
        }
        Console.WriteLine("Product of elements: {0}", product);
    }

    static void NumberCalculations(double[] nums)
    {
        // Max element.
        double max = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                max = nums[i];
            }
        }
        Console.WriteLine("Max element: {0}", max);

        // Min element.
        double min = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < nums[i - 1])
            {
                min = nums[i];
            }
        }
        Console.WriteLine("Min element: {0}", min);

        // Sum and average of elements.
        double sum = 0;
        foreach (var item in nums)
        {
            sum += item;
        }
        Console.WriteLine("Arithmetic mean of elements: {0}", sum / nums.Length);
        Console.WriteLine("Sum of elements: {0}", sum);

        // Product of elements.
        double product = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            product = product * nums[i];
        }
        Console.WriteLine("Product of elements: {0}", product);
    }

    static void NumberCalculations(decimal[] nums)
    {
        // Max element.
        decimal max = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                max = nums[i];
            }
        }
        Console.WriteLine("Max element: {0}", max);

        // Min element.
        decimal min = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < nums[i - 1])
            {
                min = nums[i];
            }
        }
        Console.WriteLine("Min element: {0}", min);

        // Sum and average of elements.
        decimal sum = 0;
        foreach (var item in nums)
        {
            sum += item;
        }
        Console.WriteLine("Arithmetic mean of elements: {0}", sum / nums.Length);
        Console.WriteLine("Sum of elements: {0}", sum);

        // Product of elements.
        decimal product = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            product = product * nums[i];
        }
        Console.WriteLine("Product of elements: {0}", product);
    }
}

