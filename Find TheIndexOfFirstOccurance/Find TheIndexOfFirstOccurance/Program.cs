namespace Find_TheIndexOfFirstOccurance
{

    //https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int StrStr(string haystack, string needle)
        {
            for(int i=0;i<haystack.Length-needle.Length+1; i++)
            {
                if (haystack.Substring(i, needle.Length) == needle)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
