namespace RansomNote
{

    //https://leetcode.com/problems/ransom-note/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static bool CanConstruct(string ransomNote, string magazine)
        {

            var charCount = new int[256];
            foreach (char c in magazine)
            {
                charCount[c]++;
            }

            foreach(var c in ransomNote)
            {
                charCount[c]--;
                if(charCount[c] < 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}