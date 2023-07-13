namespace PalindromeNumber
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			IsPalindrome(121);
		}

		public static bool IsPalindrome(int x)
		{
			if(x < 0)
			{
				return false;
			}
			int r = 0;
			int c=x;
			while (c > 0)
			{
				r = r * 10 + c % 10;
				c /= 10;
			}
			return r == x;
		}
	}
}