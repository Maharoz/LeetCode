using System;
using System.Linq;

namespace ThirdMaximumNumber
{

    //https://leetcode.com/problems/third-maximum-number/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int ThirdMax(int[] nums)
        {
            Array.Sort(nums);
            nums = nums.Distinct().ToArray();
            if (nums.Length == 1)
            {
                return nums[0];
            }

            if (nums.Length < 3)
            {
                return nums[1];
            }
            int x = nums[nums.Length - 3];

            return x;
        }
    }
}
