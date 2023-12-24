using System.Diagnostics;

namespace BestTimeToBuyAndSellStock
{

	//https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] prices = { 7, 1, 5, 3, 6, 4 };
			MaxProfit(prices);
		}

		public static int MaxProfit(int[] prices)
		{
			int buyingPrice = prices[0];
			int currentProfit = 0;
			int maxProfit = 0;

			for(int i = 0; i < prices.Length; i++)
			{
				buyingPrice = Math.Min(buyingPrice, prices[i]);
				if (prices[i] > buyingPrice)
				{
                    currentProfit= prices[i]-buyingPrice; 
                }
				maxProfit = Math.Max(maxProfit, currentProfit);

            }
			
			return maxProfit;
		}

	}

	public static class SubArrayBuilder
	{
		public static T[] SubArray<T>(this T[] data, int index, int length)
		{
			T[] result = new T[length];
			Array.Copy(data, index, result, 0, length);
			return result;
		}
	}
}