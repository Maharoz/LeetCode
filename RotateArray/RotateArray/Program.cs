namespace RotateArray
{

    //https://leetcode.com/problems/rotate-array/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 10,20,30,40,50,60 };
            Rotate(x, 2);
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
