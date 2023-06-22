using System.Security.Cryptography.X509Certificates;

namespace TwoSum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, World!");
			int[] num = { 3,3};
			TwoSum(num, 6);
		}
		public static int[] TwoSum(int[] nums, int target)
		{
			//List<int> numsOnDic = new List<int>();
			int[] result = new int[2];
			Dictionary<int,int> dic = new Dictionary<int,int>();


			for (int i = 0; i < nums.Length; i++)
			{
				int firstVal = nums[i];
				int remain = target - firstVal;

				int myKey = dic.FirstOrDefault(x => x.Value == remain).Key;
				if (myKey >0)
				{
					result[0] = myKey;
					result[1] = i+1;
					result = result.Select(i => i - 1).ToArray();
					return result;
				}
				else
				{
					dic.Add(i+1, firstVal);
				}
			}

			return result.Select(i => i -1).ToArray();
		}
	}

	
}