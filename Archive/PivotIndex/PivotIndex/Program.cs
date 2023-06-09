//https://leetcode.com/problems/find-pivot-index/

using System.Globalization;

namespace PivotIndex
{
    internal class Program
    {
        //https://leetcode.com/problems/find-pivot-index/
        static void Main(string[] args)
        {
            int[] nums = { -1,-1,0,0,-1,-1 };
            int x = PivotIndex(nums);
        }

        public static int PivotIndex(int[] nums)
        {
            int sumOfLeft = 0;

            int sumOfRight = 0;

            int result = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    sumOfLeft = sumOfLeft + nums[j];
                }

                for(int k =i+1; k< nums.Length; k++)
                {
                    sumOfRight = sumOfRight + nums[k];
                }

                if(sumOfLeft == sumOfRight)
                {
                    result=i;
                    return result;
                }
                sumOfLeft = 0;
                sumOfRight = 0;
            }
            return result;
        }
    }
}