namespace ValidAnagram
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			IsAnagram("rat", "car");
		}

		public static bool IsAnagram(string s, string t)
		{
			bool result = true;


			s= s.ToLower();
			t=t.ToLower();


			s = s.Replace(" ", "");
			t = t.Replace(" ", "");

			int[] x = new int[26];
			
		  for(int i=0;i<s.Length;i++)
			{
				x[s[i] - 'a']++;
			}

			for (int i = 0; i < t.Length; i++)
			{
				x[t[i] - 'a']--;
			}

			foreach (int i in x)
			{
				if(i != 0)
				{
					return false;
				}
			}

			return result;
		}
	}
}