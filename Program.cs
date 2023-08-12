using System;
using System.Collections.Generic;

class ElementFrequencyCounter
{
    private Dictionary<int, int> frequencyMap;

    public ElementFrequencyCounter()
    {
        frequencyMap = new Dictionary<int, int>();
    }

    public void CountElement(int num)
    {
        if (frequencyMap.ContainsKey(num))
        {
            frequencyMap[num]++;
        }
        else
        {
            frequencyMap[num] = 1;
        }
    }

    public void PrintElementFrequencies()
    {
        Console.WriteLine("Element Frequencies:");
        foreach (var entry in frequencyMap)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} times");
        }
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

        ElementFrequencyCounter counter = new ElementFrequencyCounter();
        foreach (int num in array)
        {
            counter.CountElement(num);
        }

        counter.PrintElementFrequencies();
    }
}
