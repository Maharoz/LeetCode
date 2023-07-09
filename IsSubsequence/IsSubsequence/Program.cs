namespace IsSubsequence
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			IsSubsequence("axc", "ahbgdc");
		}

		public static bool IsSubsequence(string s, string t)
		{
			if(s.Length == 0)
			{
				return true;
			}
			char[] sArr = s.ToCharArray();
			char[] tArr = t.ToCharArray();


			int s_pointer = 0;
			int t_pointer = 0;


		while(t_pointer < t.Length)
			{
				if (tArr[t_pointer] != sArr[s_pointer])
				{
					s_pointer++;
					if(s_pointer == s.Length)
					{
						return true;
					}
				}
				t_pointer++;
			}
			return false;
		}
	}
}