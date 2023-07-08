namespace PlusOne
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			int[] x = {0 };
			PlusOne(x);
		}

		public static int[] PlusOne(int[] digits)
		{
			int n = digits.Length;
			for(int i = n-1; i >= 0; i--)
			{
                if (digits[i]<9)
                {
					digits[i]++;
					return digits;
				}

				digits[i]=0;
			}
			int[] new_num = new int[n+1];
			new_num[0] = 1;
			return new_num;

		}
	}
}