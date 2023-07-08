using System.Text;

namespace LongestCommonPrefix
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, World!");
			string[] arr = { "flower", "flow", "flight","fl" };
			LongestCommonPrefix(arr);
		}

		public static string LongestCommonPrefix(string[] strs)
		{
			string result = string.Empty;
			Array.Sort(strs);
			string a = strs[0];
			string b = strs[strs.Length-1];
			result = CommonPrefix(a, b);
			return result;
		}


		public static string CommonPrefix(string a, string b)
		{
			if (a == null)
				throw new ArgumentNullException(nameof(a));

			if (b == null)
				throw new ArgumentNullException(nameof(b));

			var min = Math.Min(a.Length, b.Length);
			var sb = new StringBuilder(min);
			for (int i = 0; i < min && a[i] == b[i]; i++)
				sb.Append(a[i]);

			return sb.ToString();
		}
	}
}