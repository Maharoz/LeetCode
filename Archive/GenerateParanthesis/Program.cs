namespace GenerateParanthesis
{

    //https://leetcode.com/problems/generate-parentheses/
    internal class Program
    {
        static void Main(string[] args)
        {
            GenerateParenthesis(3);
        }


        static IList<string> GenerateParenthesis(int n)
        {
            IList<string> strings = new List<string>();
            findAll("(", 1, 0, strings, n);
            return strings;
        }

        public static void findAll(string current, int o,int c,IList<string> result,int n)
        {
            if (current.Length == 2 * n)
            {
                result.Add(current);
                return;
            }
            if (o < n)
            {
                findAll(current +"(", o + 1, c, result, n);

            }
            if (c < o)
            {
                findAll(current + ")", o, c+1, result, n);
            }
        }
    }
}