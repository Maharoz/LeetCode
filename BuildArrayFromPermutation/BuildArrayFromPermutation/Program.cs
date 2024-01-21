namespace BuildArrayFromPermutation
{
    internal class Program
    {
        //https://leetcode.com/problems/build-array-from-permutation/
        static void Main(string[] args)
        {
            int[] nums = { 0, 2, 1, 5, 3, 4 };
            BuildArray(nums);
        }
        public static int[] BuildArray(int[] nums)
        {
            int[] ints = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                ints[i] = nums[nums[i]];
            }

            return ints;
        }
    }
}
