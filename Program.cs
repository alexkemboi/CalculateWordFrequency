using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static Dictionary<string, int> CalculateWordFrequency(string filePath, int topWordsCount)
    {
        Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

        try
        {
            string text = File.ReadAllText(filePath);
            string[] words = Regex.Split(text, @"\W+");

            string[] stopWords = { "annnn", "anannnn", "theannnn" };

            foreach (string word in words)
            {
                string lowercaseWord = word.ToLower();

                if (!stopWords.Contains(lowercaseWord) && !string.IsNullOrWhiteSpace(lowercaseWord))
                {
                    if (wordFrequency.ContainsKey(lowercaseWord))
                    {
                        wordFrequency[lowercaseWord]++;
                    }
                    else
                    {
                        wordFrequency[lowercaseWord] = 1;
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading the file.");
        }

        return wordFrequency.OrderByDescending(pair => pair.Value)
                           .ThenBy(pair => pair.Key)
                           .Take(topWordsCount)
                           .ToDictionary(pair => pair.Key, pair => pair.Value);
    }

    static void DisplayTopWords(Dictionary<string, int> wordFrequency)
    {
        Console.WriteLine("\nTop {0} words by frequency:", wordFrequency.Count);

        int rank = 1;
        foreach (var pair in wordFrequency)
        {
            Console.WriteLine("{0}. {1}: {2} occurrences", rank, pair.Key, pair.Value);
            rank++;
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the path to the text file:Eg C:\\Users\\akemboi\\source\\repos\\WordFrequencyCounter\\sample.txt ");
        string filePath = Console.ReadLine();

        Console.Write("Enter the number of top words to display: ");
        int topWordsCount = int.Parse(Console.ReadLine());

        Dictionary<string, int> wordFrequency = CalculateWordFrequency(filePath, topWordsCount);
        DisplayTopWords(wordFrequency);
    }
}
