namespace LengthOfLastWord
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, World!");
			LengthOfLastWord("Hello World");
		}
		public static int LengthOfLastWord(string s)
		{
			int length = 0;
			for(int i = s.Length - 1; i >= 0; i++)
			{
				if (s[i] != ' ')
				{
					length++;
				}
				else
				{
					if (length > 0)
					{
						return length;
					}
				}
			}
			return length;
		}
	}
}