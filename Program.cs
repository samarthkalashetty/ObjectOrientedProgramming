using System;
using System.Collections.Generic;

class UniqueElementTracker
{
    private HashSet<int> uniqueElements;

    public UniqueElementTracker()
    {
        uniqueElements = new HashSet<int>();
    }

    public void AddElement(int num)
    {
        uniqueElements.Add(num);
    }

    public void PrintUniqueElements()
    {
        Console.WriteLine("Unique elements:");
        foreach (int element in uniqueElements)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
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

        UniqueElementTracker tracker = new UniqueElementTracker();
        foreach (int num in array)
        {
            tracker.AddElement(num);
        }

        tracker.PrintUniqueElements();
    }
}
