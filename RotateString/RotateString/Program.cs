using System;

namespace RotateString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abcde";
            string goal = "abced";

            RotateString(s, goal);


        }

        public static bool RotateString(string s, string goal)
        {
            if (s == null || goal == null)
            {
                return false;
            }

            return (s.Length == goal.Length && (s + s).Contains(goal));
            
            
        }
    }
}
