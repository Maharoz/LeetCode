using static System.Net.Mime.MediaTypeNames;

namespace RemoveDuplicateFromSortedArray
{
	internal class Program
	{
		//26. Remove Duplicates from Sorted Array
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, World!");
			int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Console.WriteLine(RemoveDuplicates(nums));
		}
		public static int RemoveDuplicates(int[] nums)
		{
			int count = 1;
			int prev=nums[0];

			for(int i = 1; i < nums.Length; i++)
			{
				if (prev != nums[i])
				{
					count++;
				}
				prev = nums[i];
			}
			return count;
		}
	}
}
