using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.PirateSpeak
{
    public class Solution
    {
        public string[] GetPossibleWords(string jumble, string[] dictionary)
        {
            var result = new List<string>(); ;
            string jumbleOrdered = GetOrdered(jumble);
            foreach (var word in dictionary)
            {
                var wordOrdered = GetOrdered(word);
                if (jumbleOrdered == wordOrdered)
                {
                    result.Add(word);
                }
            }
            return result.ToArray();
        }

        private static string GetOrdered(string word)
        {
            var chars = word.ToArray().OrderBy(x => x).ToArray();
            return new string(chars);
        }
    }
}
