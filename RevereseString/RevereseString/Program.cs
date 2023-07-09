namespace RevereseString
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			char[] chars = { 'a', 'b', 'c','d','e','f','g' };
			ReverseString(chars);
		}

		public static void ReverseString(char[] s)
		{
			int start = 0;
			int end = s.Length-1;
			
			while (start < end)
			{
				char temp = s[start];
				s[start] = s[end];
				s[end] = temp;
				start++;
				end--;
			}
		}
		}
}