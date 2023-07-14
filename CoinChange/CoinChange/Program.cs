using System.Drawing;
using System.Numerics;

namespace CoinChange
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			int[] x = { 1,3,5 };
			int amount = 9;
			CoinChange(x, amount);
		}

		public static int CoinChange(int[] coins, int amount)
		{
			if (amount < 1) { return 0; }
			int[] minCoinsDP =new int[amount + 1];

			for(int i =1;i<=amount;i++)
			{
				minCoinsDP[i] = int.MaxValue;
				foreach(int coin in coins)
				{
					if (coin <= i && minCoinsDP[i - coin] != int.MaxValue)
					{
						minCoinsDP[i] = Math.Min(minCoinsDP[i], 1 + minCoinsDP[i-coin]);
					}
				}
			}

			if (minCoinsDP[amount] == int.MaxValue)
			{
				return -1;
			}
			return minCoinsDP[amount];

		}
	}
}