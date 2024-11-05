using System;

namespace CodingChallenge.PirateSpeak
{
    class Program
    {
        static void Main(string[] args)
        {
            var results = new Solution().GetPossibleWords("boop", new[] { "oops", "poo", "boo", "noop", "bpoo" });
            foreach (var word in results)
            {
                Console.WriteLine(word);
            }
        }
    }
}
