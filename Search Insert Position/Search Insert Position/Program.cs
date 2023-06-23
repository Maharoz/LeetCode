namespace Search_Insert_Position
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}
	}

	public class Solution
	{
		public int SearchInsert(int[] nums, int target)
		{
			int midPoint = nums.Length / 2;
			int startPoint = 0;
			while (nums[midPoint] < target)
			{
				startPoint= midPoint + 1;

			}
		}
	}
}