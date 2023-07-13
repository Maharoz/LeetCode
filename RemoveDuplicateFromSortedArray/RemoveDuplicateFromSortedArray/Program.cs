namespace RemoveDuplicateFromSortedArray
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			int[] nums = { 1,1,2 };
			int x=RemoveDuplicates(nums);
			Console.WriteLine(x);
		}

		public static int RemoveDuplicates(int[] nums)
		{
			int result = 0;
			for(int i=0;i<nums.Length;i++)
			{
				if (i < nums.Length - 1  && nums[i] == nums[i+1])
				{
					continue;
				}
				else
				{
					nums[result] = nums[i];
					result++;	
				}
			}
			return result;
		}
	}
}