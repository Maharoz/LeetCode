//https://leetcode.com/problems/house-robber/
namespace HouseRobber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static int Rob(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            if (nums.Length == 1)
            {
                return nums[0];
            }
            if (nums.Length == 2)
            {
                return Math.Max(nums[0], nums[1]);
            }

            int[] b = new int[nums.Length];
            b[0] = nums[0];
            b[1] = Math.Max(nums[0], nums[1]);

            for (int i = 2; i < nums.Length; i++)
            {
                b[i] = Math.Max(b[i - 2] + nums[i], b[i - 1]);
            }
            return b[nums.Length - 1];
        }
    }
}