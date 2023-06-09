
//https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
using System.Diagnostics;

namespace BestTimeToBuyAndSellStock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] days = { 7, 1, 5, 3, 6, 4 };
            int x = MaxProfit(days);
        }

        static int MaxProfit(int[] prices)
        {
            if (prices.Length < 2)
            {
                return 0;
            }
            int low_value = prices[0];
            int max_profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                low_value = Math.Min(low_value, prices[i]);
                int curr_profit = prices[i] - low_value;
                max_profit = Math.Max(max_profit, curr_profit);
            }
            return max_profit;


        }
    }
}