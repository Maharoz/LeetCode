using System;

namespace RankTransformationOfAnArray
{

    //https://leetcode.com/problems/rank-transform-of-an-array/
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 37,12,28,9,100,56,80,5,12};
            int[] output = new int[input.Length];
            int rank = 0;
            for(int i =0;i<input.Length;i++)
            {
                foreach(var x in input)
                {
                    if (input[i] > x)
                    {
                        rank++;
                    }
                }
                output[i] = rank+1;
                rank = 0;
            }
        }
    }
}
