namespace MajorityElement
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			int[] nums = { 6, 5, 5 };
			MajorityElement(nums);
		}

		public static int MajorityElement(int[] nums)
		{
			int majorityCondition = nums.Length / 2+1;
			foreach (int num in nums.Distinct())
			{
				
				int count = nums.Where(x => x == num).Count() ;
				if(count >= majorityCondition)
				{
					return num;
				}
			}
			return 0;
		}
	}
}