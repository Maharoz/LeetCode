using System.Linq;

namespace LongestSubstringWithoutRepeatingChracter
{

    //https://leetcode.com/problems/longest-substring-without-repeating-characters/
    internal class Program
    {
        static void Main(string[] args)
        {
            int res=LengthOfLongestSubstring("abcbc");
            Console.WriteLine(res);
        }

        public static int LengthOfLongestSubstring(string s)
        {
            int pointer_a = 0;
            int pointer_b = 0;
            int max = 0;

            char[] chars = s.ToCharArray();
   
      
            HashSet<char> result = new HashSet<char>();

            while(pointer_b < chars.Length)
            {
                if (!result.Contains(chars[pointer_b]))
                {
                    result.Add(chars[pointer_b]);
                    pointer_b++;
                    max = Math.Max(result.Count(), max);
                }
                else
                {
                   result.Remove(chars[pointer_a]);
                   pointer_a++;
                }
            }

            return  max; ;
        }
    }
}