namespace Binary_Search
{
	internal class Program
	{
		//Problem => 704. Binary Search
		static void Main(string[] args)
		{
			int[] nums = { 5 };
			int target = 5;
            Console.WriteLine(Search(nums, target));
		}
		public static int Search(int[] nums, int target)
		{
			int start=0, end=nums.Length-1;
			while (start <= end) {

				int mid = start + (end - start) / 2;
				if (nums[mid] == target)
				{
					return mid;
				}
				else if (nums[mid] > target) {
					end = mid - 1;

				}
				else
				{
					start = mid + 1;
				}
			}
			return -1;
		}
	}
}
