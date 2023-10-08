using System;
using System.Text;
using Word_Scrabble.src.Helpers;
using Word_Scrabble.src.Interfaces;

namespace Word_Scrabble.src.Services
{
    public class ScrambleService : IScramble
    {
        private FileReader _reader;
        private string[] wordsInFile;
        private Random _random;

        public ScrambleService(FileReader reader)
        {
            _reader = reader;
            wordsInFile = _reader.readFile();
            _random = new Random();
        }
        public string randomSentence(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
            {
                throw new Exception("Sentence is not valid");
            }

            string[] sentenceSplit = sentence.Split(' ');

            string result = string.Join(" ", sentenceSplit.Select(word => replaceWord(word)));

            return result.Trim();
        }

        public string replaceWord(string word)
        {
            string letter = word.Substring(0, 1);
            int length = word.Length;

            var matchingWordsInList = wordsInFile
                .Where(x => x
                .StartsWith(letter, StringComparison.OrdinalIgnoreCase) && x.Length == length)
                .ToList();

            if (matchingWordsInList.Count > 0)
            {
                int randomIndex = _random.Next(0, matchingWordsInList.Count);
                return matchingWordsInList[randomIndex];
            }
            else
            {
                return word;
            }
        }
    }
}
