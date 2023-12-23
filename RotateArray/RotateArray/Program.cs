namespace RotateArray
{

    //https://leetcode.com/problems/rotate-array/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3 };
            Rotate(x, 4);
        }

        public static void Rotate(int[] nums, int k)
        {


            k = k % nums.Length;
            Array.Reverse(nums);
            Array.Reverse(nums, 0, k);
            Array.Reverse(nums, k, nums.Length - k);

        }
    }
}
