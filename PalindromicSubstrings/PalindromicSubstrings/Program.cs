namespace PalindromicSubstrings
{
    //https://leetcode.com/problems/palindromic-substrings
    internal class Program
    {
        static void Main(string[] args)
        {
            CountSubstrings("baabc");
        }

        public static int CountSubstrings(string s)
        {
            char[] x=   s.ToArray();
            int total =0;
            for (int i = 0; i <= x.Length-1; i++)
            {
                total = total + search(i,i,x);
                total = total + search(i, i+1, x);
            }
            return total;
        }

        public static int search(int start ,int end , char[] s) {

            int count = 0;
            while((start>=0 && end<s.Length) && s[start]== s[end])
            {
                count++;
                start--;
                end++;

            }
            return count;
        }
    }
}
