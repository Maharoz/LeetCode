using System;

namespace TwoSum
{
    class Program
    {

        //https://leetcode.com/problems/two-sum/
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            for (int i = 0; i < nums.Length - 1; i++)
            {

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] != target)
                    {
                        continue;
                    }
                    result[0] = i;
                    result[1] = j;
                }


            }

            return result;

        }
    }
}
