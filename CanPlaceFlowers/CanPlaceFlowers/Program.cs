using System;

namespace CanPlaceFlowers
{
    internal class Program
    {
        //https://leetcode.com/problems/can-place-flowers/
        static void Main(string[] args)
        {
            int[] flowerbed = { 0, 0, 1, 0, 1 };
            int n = 1;
            CanPlaceFlowers(flowerbed, n);
        }

        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int count = 0;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                // Check if the current plot is empty.
                if (flowerbed[i] == 0)
                {
                    // Check if the left and right plots are empty.
                    bool emptyLeftPlot = (i == 0) || (flowerbed[i - 1] == 0);
                    bool emptyRightPlot = (i == flowerbed.Length - 1) || (flowerbed[i + 1] == 0);

                    // If both plots are empty, we can plant a flower here.
                    if (emptyLeftPlot && emptyRightPlot)
                    {
                        flowerbed[i] = 1;
                        count++;
                    }
                }
            }
            return count >= n;
        }
    }
}
