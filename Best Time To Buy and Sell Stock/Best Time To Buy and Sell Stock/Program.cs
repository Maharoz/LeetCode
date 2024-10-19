using static System.Net.Mime.MediaTypeNames;

namespace Best_Time_To_Buy_and_Sell_Stock
{
	internal class Program
	{
		//121. Best Time to Buy and Sell Stock
		static void Main(string[] args)
		{
			int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };

            Console.WriteLine(MaxProfit(prices));
		}

		public static int MaxProfit(int[] prices)
		{
		//Input: prices = [7,1,5,3,6,4]
		//Output: 5

			int buy=prices[0];
			int maxProfit = 0;

			for (int i = 1; i < prices.Length; i++) {
				int currentProfit = prices[i] - buy;
				maxProfit = Math.Max(maxProfit, currentProfit);
				buy=Math.Min(buy, prices[i]);
			}
			return maxProfit;
		}
	}
}
