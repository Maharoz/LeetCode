namespace HalvesAreAlike
{
    //https://leetcode.com/problems/determine-if-string-halves-are-alike/description/
    internal class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine("Hello, World!");
            HalvesAreAlike("textbook");
        }

        public static bool HalvesAreAlike(string s)
        {
            string firstHalves= s.Substring(0,s.Length/2);
            string lastHalves = s.Substring(s.Length/2);
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int numberOfVowelInFirstHalves = firstHalves.ToLower().Count(c => vowels.Contains(c));
            int numberOfVowelInSecondHalves = lastHalves.ToLower().Count(c => vowels.Contains(c));

            if(numberOfVowelInFirstHalves == numberOfVowelInSecondHalves)
            {
                return true;
            }

            return false;
        }
    }
}
