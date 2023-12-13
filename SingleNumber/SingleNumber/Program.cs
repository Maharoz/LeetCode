namespace SingleNumber
{

    //https://leetcode.com/problems/single-number/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 2 };
            SingleNumber(x);
        }

        public static int SingleNumber(int[] nums)
        {
            
            return nums.GroupBy(x=>x).Where(g=>g.Count()==1).Select(g=>g.Key).FirstOrDefault();
            
        }
    }
}
