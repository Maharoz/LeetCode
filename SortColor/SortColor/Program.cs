namespace SortColor
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			int[] nums = { 2,0,2,1,1,0,1,0,1,0 };
			SortColors(nums);
		}

		public static void SortColors(int[] nums)
		{
			int start = 0;
			int mid = 0;
			int end = nums.Length - 1;

			while (mid <= end)
			{
				switch(nums[mid])
				{
					case 0:
						swap(nums, start, mid);
						mid++;
						start++;
						break;
					case 1:
						mid++;
						break;
					case 2:
						swap(nums, mid, end);
						end--;
						break;

				}
			}
		}

		private static void swap(int[] arr,int pos1,int pos2)
		{
			int temp = arr[pos1];
			arr[pos1] = arr[pos2];
			arr[pos2] = temp;
		}


	}
}