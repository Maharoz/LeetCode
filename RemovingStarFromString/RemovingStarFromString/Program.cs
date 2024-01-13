namespace RemovingStarFromString
{

    //https://leetcode.com/problems/removing-stars-from-a-string/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            string result =RemoveStars("leet**cod*e");
            Console.WriteLine(result);
        }

        public static string RemoveStars(string s)
        {
            string result = string.Empty;

            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c != '*')
                    
                {
                    stack.Push(c);
                }
                else
                {
                    stack.Pop();
                }
            }

            while (stack.Count > 0)
            {
                char c = stack.Pop();
                result = c+ result;
            }
            return result;
        }
    }


}
