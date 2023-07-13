namespace MissingNumber
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			int[] x = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
			MissingNumber(x);
		}

		public static int MissingNumber(int[] nums)
		{
			int res = 0;
			int sum = nums.Length * (nums.Length + 1) / 2;
			res = sum - nums.Sum();

			return res;
		}
	}
}