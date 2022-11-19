namespace ArrayPartition
{
    internal class Program
    {

        //https://leetcode.com/problems/array-partition/
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int[] x = { 6, 2, 6, 5, 1, 2 };
            ArrayPairSum(x);
        }

        static int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            int minSum = 0;
            for(int i = 0; i < nums.Length; i+=2)
            {
                minSum+=nums[i];
            }
            return minSum;
        }
        }
}