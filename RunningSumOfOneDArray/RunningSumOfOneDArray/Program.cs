namespace RunningSumOfOneDArray
{
    //https://leetcode.com/problems/running-sum-of-1d-array/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            RunningSum(nums);
        }

        public static int[] RunningSum(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if (i != 0)
                {
                    nums[i] = nums[i] + nums[i - 1];
                }
            }
            return nums;
        }
    }
}
