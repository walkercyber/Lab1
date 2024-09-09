using System;
using System.Text.RegularExpressions;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ange en textsträng:");
        string inputNumbers = Console.ReadLine();
        HighlightNumbers(inputNumbers);
    }

    public static void HighlightNumbers(string inputNumbers)
    {
        for (int i = 0; i < inputNumbers.Length; i++)
        {
            if (Char.IsDigit(inputNumbers[i]))
            {
                for (int j = i + 1; j < inputNumbers.Length; j++)
                {
                    if (inputNumbers[i] == inputNumbers[j])
                    {
                        string delstrangMatch = inputNumbers[i] + inputNumbers.Substring(i + 1, j - i - 1) + inputNumbers[j];

                        if (Regex.IsMatch(delstrangMatch, @"^\d+$"))
                        {
                            Console.Write(inputNumbers.Substring(0, i));

                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.Write(inputNumbers[i]);
                            Console.Write(inputNumbers.Substring(i + 1, j - i - 1));
                            Console.Write(inputNumbers[j]);

                            Console.ResetColor();

                            Console.WriteLine(inputNumbers.Substring(j + 1));

                            break;
                        }
                    }
                }
            }
        }
    }
}