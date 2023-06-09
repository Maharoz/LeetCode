using System;
using System.Linq;

namespace LengthOfLastWord
{

    //https://leetcode.com/problems/length-of-last-word/
    class Program
    {
        static void Main(string[] args)
        {
            count("   fly me   to   the moon  ");
        }

        public static void count(string s)
        {
            //string lastWord = s.Split(' ').Last();

            string[] parts = s.Split(' ');
            parts = parts.Where(x => x != string.Empty).ToArray();
            string lastWord = parts[parts.Length - 1];
         
            int count = lastWord.ToCharArray().Count();
        }
    }

    
}
