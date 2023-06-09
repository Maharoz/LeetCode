using System;
using System.Diagnostics.CodeAnalysis;

namespace MinimumCostOfBuyingCandy
{

    //https://leetcode.com/problems/minimum-cost-of-buying-candies-with-discount/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = {9,7,5,2,2,4,5};
            int y= MinimumCost(x);
            
        }

        static int MinimumCost(int[] cost)
        {
            Array.Sort(cost);
            int res = 0, n = cost.Length;
            for (int i = 0; i < n; ++i)
                if (i % 3 != n % 3)
                    res += cost[i];
            return res;
        }
    }
}