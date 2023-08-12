
using System;
using System.Globalization;

class TitleConverter
{
    public static string ConvertToTitleCase(string input)
    {
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        return textInfo.ToTitleCase(input);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a sentence: ");
        string inputSentence = Console.ReadLine();

        string convertedTitle = TitleConverter.ConvertToTitleCase(inputSentence);
        Console.WriteLine("Converted sentence: " + convertedTitle);
    }
}
