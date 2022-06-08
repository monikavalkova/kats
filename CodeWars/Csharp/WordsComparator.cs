namespace Kats.CodeWars.Csharp
{
    public static class WordsComparator
    {
        public static string GetLargestScoringWord(string s)
        {
            var words = s.Split(" ");
            var highestScoreWord = "";
            var highestScore = 0;
            for (int i = 0; i < words.Length; i++)
            {
                var score = words[i].ToLowerInvariant().Select(@char => @char - 96).Sum();

                if (score > highestScore)
                {
                    highestScore = score;
                    highestScoreWord = words[i];
                }
            }
            return highestScoreWord;
        }

        public static string GetLargestScoringWordFunc(string s)
         => GetLargestScoringWord("", 0, s.Split(" ").Select(a => a));


        public static string GetLargestScoringWord(string highestScoreWord, int highestScore, IEnumerable<string> words)
        {
            var thisWord = words.First();
            var thisScore = thisWord.ToLowerInvariant().Select(@char => @char - 96).Sum();
            
            if (words.Count() == 1) return thisScore > highestScore ? thisWord : highestScoreWord;
            
            return thisScore > highestScore ? GetLargestScoringWord(thisWord, thisScore, words.Skip(1))
                                        : GetLargestScoringWord(highestScoreWord, highestScore, words.Skip(1));
        }
    }
}