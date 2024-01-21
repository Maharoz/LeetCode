namespace TruncateSentence
{

    //https://leetcode.com/problems/truncate-sentence/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            TruncateSentence("Hello how are you Contestant", 4);
        }


        public static string TruncateSentence(string s, int k)
        {
            string[] sentence = s.Split(" ").Take(k).ToArray();
            string x = string.Join(" ", sentence);
            return x;
        }
    }
}
