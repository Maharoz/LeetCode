namespace BestTimeForBuyAndSellStockII
{

    //https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prices = { 1, 2, 3, 4, 5 };
            MaxProfit(prices);
        }

        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    maxProfit = maxProfit+(prices[i] - prices[i - 1]);
                }
            }

            return maxProfit;
        }
    }
}
