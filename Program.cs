using System;
using System.Linq;

class TwoLowestSumCalculator
{
    public static int CalculateTwoLowestSum(int[] numbers)
    {
        var positiveNumbers = numbers.Where(num => num > 0).OrderBy(num => num);

        if (positiveNumbers.Count() < 2)
        {
            Console.WriteLine("There are not enough positive numbers to calculate the sum.");
            return 0;
        }

        return positiveNumbers.Take(2).Sum();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int sum = TwoLowestSumCalculator.CalculateTwoLowestSum(array);
        Console.WriteLine("Sum of two lowest positive numbers: " + sum);
    }
}
