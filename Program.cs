using System;

class ElementAnalyzer
{
    private int[] array;
    private int maximum;
    private int minimum;
    private bool analyzed;

    public ElementAnalyzer(int[] inputArray)
    {
        array = inputArray;
        analyzed = false;
    }

    public void AnalyzeElements()
    {
        if (array.Length == 0)
        {
            Console.WriteLine("Array is empty.");
            return;
        }

        maximum = array[0];
        minimum = array[0];

        foreach (int num in array)
        {
            if (num > maximum)
            {
                maximum = num;
            }

            if (num < minimum)
            {
                minimum = num;
            }
        }

        analyzed = true;
    }

    public void PrintResults()
    {
        if (!analyzed)
        {
            Console.WriteLine("Please analyze elements first.");
            return;
        }

        Console.WriteLine($"Maximum element: {maximum}");
        Console.WriteLine($"Minimum element: {minimum}");
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

        ElementAnalyzer analyzer = new ElementAnalyzer(array);
        analyzer.AnalyzeElements();
        analyzer.PrintResults();
    }
}
