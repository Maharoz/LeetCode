namespace MximumSubArray
{

    //https://leetcode.com/problems/maximum-subarray/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -2,1,-3,4,-1,2,1,-5,4 };
            Console.WriteLine(MaxSubArray(nums));
        }

        static int MaxSubArray(int[] nums)
        {
            int max_so_far = nums[0];
            int curr_max = nums[0];

            for(int i =1; i < nums.Length; i++)
            {
                curr_max = Math.Max(nums[i], nums[i] + curr_max);
                max_so_far=Math.Max(curr_max, max_so_far);
            }
            return max_so_far;

        }
    }
}