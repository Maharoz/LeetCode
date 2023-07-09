namespace ValidPalindrome
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}

		public static bool IsPalindrome(string s)
		{
			string fixed_string = string.Empty;

			foreach (char c in s.ToCharArray())
			{
				if (char.IsLetter(c) || char.IsDigit(c))
				{
					fixed_string += c;
				}
			}

			fixed_string= fixed_string.ToLower();
			char[] fixed_string_char= fixed_string.ToCharArray();
			int startPoint = 0;
			int endPoint = fixed_string.Length-1;

			while (startPoint < endPoint)
			{
				if (fixed_string_char[startPoint]!= fixed_string_char[endPoint])
				{
					return false;
				}
				startPoint++;
			}
			return true;
		}
	}
}