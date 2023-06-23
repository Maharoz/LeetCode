using System.Diagnostics;

namespace BestTimeToBuyAndSellStock
{

	//https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, World!");
			int[] prices = { 7, 1, 5, 3, 6, 4 };
			MaxProfit(prices);
		}

		public static int MaxProfit(int[] prices)
		{
			int max = 0;
			int profit = 0;
			for(int i = 0; i < prices.Length-1; i++)
			{
				int[] arr = SubArrayBuilder.SubArray(prices,i+1, prices.Length-(i+1));
				int maxSubArrVal=arr.Max();
				if (prices[i]< maxSubArrVal)
				{
					profit =  maxSubArrVal- prices[i];
				}

				max= Math.Max(max, profit);

			}

			//Brute force solution=> will give TLE on some case
			//int temp = 0;
			//for (int i = prices.Length-1; i > 0; i--)
			//{
			//	for(int j = i - 1; j >= 0; j--)
			//	{
			//		if (prices[i] > prices[j])
			//		{
			//			temp = prices[i] - prices[j];
			//		}
			//		max=Math.Max(max, temp);
			//	}
				
			
			//}
			return max;
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