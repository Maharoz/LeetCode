namespace BuildAnArrayWithStackOperation
{
    //https://leetcode.com/problems/build-an-array-with-stack-operations/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] target = { 3, 4, 7 };
            int x= 10;
            BuildArray(target, x);
        }

        static IList<string> BuildArray(int[] target, int n)
        {
            IList<string> list = new List<string>();
          
            int j = 0;
            for (int i = 1; i <= n && j < target.Length; i++)
            {
                list.Add("Push");
                if (target[j] == i)
                {
                    j++;
                }
                else
                {
                    list.Add("Pop");
                }
            }
            return list;
        }
    }
}