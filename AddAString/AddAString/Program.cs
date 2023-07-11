namespace AddAString
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			AddStrings("11", "123");
		}

		public static string AddStrings(string num1, string num2)
		{
			string s =string.Empty;

			s = (Convert.ToInt64(num1) + Convert.ToInt64(num2)).ToString();
			return s;
		}
	}
}