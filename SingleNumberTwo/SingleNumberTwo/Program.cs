namespace SingleNumberTwo
{
    //https://leetcode.com/problems/single-number-ii/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int SingleNumber(int[] nums)
        {
            return nums.GroupBy(x=>x).Where(g=>g.Count()==1).Select(g=>g.Key).FirstOrDefault();
        }
    }
}
