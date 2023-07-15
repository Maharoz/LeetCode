using System.Text;

namespace WordPattern
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			string pattern = "abba";
			string s = "dog dog dog dog";
			WordPattern(pattern, s);
		}


		public static bool WordPattern(string pattern, string s)
		{
				var dict1 = new Dictionary<char, string>();
				var dict2 = new Dictionary<string, char>();
				var sList = s.Split(' ', StringSplitOptions.None);

				if (pattern.Length != sList.Count()) return false;

				for (int i = 0; i < sList.Count(); i++)
				{
					dict1.TryAdd(pattern[i], sList[i]);
					dict2.TryAdd(sList[i], pattern[i]);
					if (dict1[pattern[i]] != sList[i]) return false;
					if (dict2[sList[i]] != pattern[i]) return false;
				}

				return true;
			}
		
	}
}