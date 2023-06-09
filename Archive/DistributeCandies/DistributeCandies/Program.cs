
//https://leetcode.com/problems/distribute-candies/
using System;

int[] n = { 2, 5, 9, 3, 6 };

static int DistributeCandies(int[] candyType)
{
    int x = candyType.Distinct().Count();

    if(x > candyType.Length / 2)
    {
        return candyType.Length / 2;
    }
    return x;
}
