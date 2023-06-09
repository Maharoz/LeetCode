namespace MaximumAvarageSubarray
{

    //https://leetcode.com/problems/maximum-average-subarray-i/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] x = { 1, 12, -5, -6, 50, 3 };
            FindMaxAverage(x, 4);
        }

        static double FindMaxAverage(int[] nums, int k)
        {
            int currsum = 0;
            for (int i = 0; i < k; i++)
            {
                currsum += nums[i];
            }
            int maxsum = currsum;
            int start = 0;
            int end = k - 1;
            while (end < nums.Length - 1)
            {
                currsum -= nums[start];
                currsum += nums[end + 1];
                maxsum = Math.Max(maxsum, currsum);
                start++; end++;
            }
            return maxsum / (double)k;

        }
    }
}