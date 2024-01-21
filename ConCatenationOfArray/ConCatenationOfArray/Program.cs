using System;

namespace ConCatenationOfArray
{

    //https://leetcode.com/problems/concatenation-of-array/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 1 };
            GetConcatenation(nums);
        }

        public static int[] GetConcatenation(int[] nums)
        {
            int[] res = new int[nums.Length*2];
            nums.CopyTo(res, 0);
            nums.CopyTo(res, nums.Length);

            return res;
        }
    }
}
