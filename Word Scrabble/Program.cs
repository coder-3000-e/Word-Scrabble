using System;
using Word_Scrabble.src.Helpers;
using Word_Scrabble.src.Services;

class Program
{
    public static void Main(string[] args)
    {
        ScrambleService scrambleService = new(new FileReader());

        Console.WriteLine("Please enter a sentence:");
        string sentenceEntered = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(sentenceEntered))
        {
            var result = scrambleService.randomSentence(sentenceEntered);
            Console.WriteLine("Sentence: " + sentenceEntered);
            Console.WriteLine("Scrambled sentence: " + result);
        }
        else
        {
            Console.WriteLine("You did not enter a sentence.");
        }
    }
}
