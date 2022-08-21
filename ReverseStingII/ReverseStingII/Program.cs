using System;
using System.Text;

namespace ReverseStingII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string s = "abcdefg";
            int k = 2;
            string input = s.Substring(0, k);
            string output= rev(input);
            output = output + s.Substring(k,s.Length - k);


        }

        public static string rev(string s) { 

            StringBuilder rev = new StringBuilder();

            for (int i = s.Length; i > 0; i--)
            {
                rev.Append(s.ToCharArray()[i - 1]);
            }
            return rev.ToString();
        }
    }
}
