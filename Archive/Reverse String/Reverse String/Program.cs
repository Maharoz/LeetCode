using System;

namespace Reverse_String
{

    //https://leetcode.com/problems/reverse-string/
    class Program
    {
        static void Main(string[] args)
        {
            char[] s = new char[] { 'h', 'e', 'l', 'l', 'o' };
            var len = s.Length;
            for (int i = 0; i < len / 2; i++)
            {
                var temp = s[i];
                s[i] = s[len - 1 - i];
                s[len - 1 - i] = temp;
            }

        }
    }
}
