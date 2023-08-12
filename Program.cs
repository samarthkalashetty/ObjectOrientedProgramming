using System;
using System.Collections.Generic;

class DuplicateCounter
{
    private Dictionary<int, int> frequencyMap;

    public DuplicateCounter()
    {
        frequencyMap = new Dictionary<int, int>();
    }

    public void CountDuplicates(int[] array)
    {
        foreach (int num in array)
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
    }

    public int GetTotalDuplicateCount()
    {
        int duplicateCount = 0;
        foreach (var pair in frequencyMap)
        {
            if (pair.Value > 1)
            {
                duplicateCount += pair.Value - 1;
            }
        }
        return duplicateCount;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[5];
        Console.WriteLine("Enter the element");
        Console.ReadLine();
    

        DuplicateCounter counter = new DuplicateCounter();
        counter.CountDuplicates(array);

        int totalDuplicateCount = counter.GetTotalDuplicateCount();
        Console.WriteLine("Total number of duplicate elements: " + totalDuplicateCount);
    }
}
