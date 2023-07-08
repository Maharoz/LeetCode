namespace SearchInsertPosition
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, World!");
			int[] a = { 1};
			int x = SearchInsert(a, 0);
		}
		public static int SearchInsert(int[] nums, int target)
		{

			int low = 0;
			int high = nums.Length - 1;

			while (low <= high)
			{
				int mid = low + (high-low) / 2;
				if (nums[mid] == target)
				{
					return mid;
				}
				else if (nums[mid] > target)
				{
					high = mid - 1;
				}
				else
				{
					low = mid + 1;
				}


			}
			return low;
		}
	}
}