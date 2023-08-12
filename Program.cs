using System;

class WordReverser
{
    public static string ReverseWords(string input)
    {
        string[] words = input.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            char[] charArray = words[i].ToCharArray();
            Array.Reverse(charArray);
            words[i] = new string(charArray);
        }

        return string.Join(" ", words);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        string reversedWordsString = WordReverser.ReverseWords(inputString);
        Console.WriteLine("Reversed words: " + reversedWordsString);
    }
}
