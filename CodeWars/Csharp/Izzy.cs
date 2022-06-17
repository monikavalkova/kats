using System.Linq;
using System.Text.RegularExpressions;

namespace Kats.CodeWars
{
    public static class Izzy
    {
        public static bool AreXsEqualToOx(string str)
        {
            var countX = 0;
            var countO = 0;
            foreach(var @char in str)
            {
                if(@char == 'x') countX++;
                if(@char == 'o') countO++;
            }
            return countO == countX;
        }

        public static string FindLongestWord(string sen)
        {
            var words = sen.Split(' ');
            var longestWord = RemoveNonLetterCharacters(words[0]);
            foreach(var word in words)
            {
                var currentWord = RemoveNonLetterCharacters(word);
                if(currentWord.Length > longestWord.Length)
                {
                    longestWord = currentWord;
                }    
            }
            return longestWord;
        }

        private static string RemoveNonLetterCharacters(string word)
        => Regex.Replace(word, @"[^a-zA-Z]+", "");

    }
}