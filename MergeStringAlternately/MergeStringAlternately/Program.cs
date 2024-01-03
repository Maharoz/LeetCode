using System.Text;

namespace MergeStringAlternately
{

    //https://leetcode.com/problems/merge-strings-alternately/
    internal class Program
    {
        static void Main(string[] args)
        {
            MergeAlternately("ab", "pqrq");
        }


        public static string MergeAlternately(string word1, string word2)
        {
            string result = string.Empty;

            StringBuilder sb = new StringBuilder(word1.Length + word2.Length);
            int maxLength = Math.Max(word1.Length, word2.Length);
            for (int i = 0; i < maxLength; i++)
            {
                if (i < word1.Length)
                {
                    sb.Append(word1[i]);
                }

                if (i < word2.Length)
                {
                    sb.Append(word2[i]);
                }
            }
            return sb.ToString();


        }
    }
}
