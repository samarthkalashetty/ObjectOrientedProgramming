
using System;

class DigitSumCalculator
{
    public static int CalculateDigitSum(int number)
    {
        int sum = 0;

        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return sum;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int inputNumber = int.Parse(Console.ReadLine());

        int digitSum = DigitSumCalculator.CalculateDigitSum(inputNumber);
        Console.WriteLine("Sum of digits: " + digitSum);
    }
}
