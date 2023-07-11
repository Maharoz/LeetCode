namespace JewelAndStone
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}
		public int NumJewelsInStones(string jewels, string stones)
		{
			int res = 0;
			List<char> jewelArr = jewels.ToCharArray().ToList();
			List<char> stoneArr= stones.ToCharArray().ToList();	
			foreach(char c in stoneArr)
			{
				if (jewelArr.Contains(c))
				{
					res++;
				}
			}

			return res;
		}
	}
}