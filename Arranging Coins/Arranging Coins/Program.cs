namespace Arranging_Coins
{
	internal class Program
	{
		//441. Arranging Coins
		static void Main(string[] args)
		{
			Console.WriteLine(ArrangeCoins(8));
		}

		public static int ArrangeCoins(int n)
		{
			int counter = 1;
			int remaining = n;
			while (counter<=remaining)
			{
				remaining = remaining - counter;
				counter++;
			}

			return counter-1;
		}
	}
}
