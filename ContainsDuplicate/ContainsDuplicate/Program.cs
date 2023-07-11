namespace ContainsDuplicate
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}

		public bool ContainsDuplicate(int[] nums)
		{
			int distict = nums.Distinct().Count();
			if(nums.Length > distict) return true;
			return false;
		}

	}
}