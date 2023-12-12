namespace RomanToInteger
{
	internal class Program
	{
		static void Main(string[] args)
		{
			RomanToInt("MCMXCIV");
		}

		public static int RomanToInt(string s)
		{
			Dictionary<char,int> map = new Dictionary<char,int>();
			map.Add('I', 1);
			map.Add('V', 5);
			map.Add('X', 10);
			map.Add('L', 50);
			map.Add('C', 100);
			map.Add('D', 500);
			map.Add('M', 1000);	
			int result = 0;
			char[] chars = s.ToCharArray();

			foreach (char c in chars)
			{
				int val= map[c];
				result = result + val;
			}
			return result;

		}
		
	}
}