using System;

namespace KthLargest
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			int[] x = { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
			FindKthLargest(x, 4);
		}

		public static int FindKthLargest(int[] nums, int k)
		{
			//Array.Sort(nums,);
			nums= nums.OrderByDescending(c => c).ToArray();
			int x = nums[k-1];
			return x;
		}

	}
}