namespace MaxSubArray
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] x = { -2, -5, 6, - 2, -3, 1, 5, -6 };
			MaxSubArray(x);
		}
		public static int MaxSubArray(int[] nums)
		{
			int max_so_far = nums[0];
			int curr_max = nums[0];

			for(int i=1; i<nums.Length; i++)
			{
				curr_max = Math.Max(nums[i], nums[i]+curr_max);
				max_so_far = Math.Max(curr_max, max_so_far);
			}
			return max_so_far;
		}
	}
}