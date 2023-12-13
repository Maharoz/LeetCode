namespace ReverseWord
{
    //https://leetcode.com/problems/reverse-words-in-a-string/
    internal class Program
    {
        //https://leetcode.com/problems/reverse-words-in-a-string/
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ReverseWords("the sky       is      blue");
        }

        public static string ReverseWords(string s)
        {

            string[] words = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string constructedSentence = string.Join(" ", words.Select(word => word.Trim()).Reverse());
            return constructedSentence;
        }
    }
}
