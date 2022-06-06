using System;

namespace ShuffleTheArray
{

    //https://leetcode.com/problems/shuffle-the-array/
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int[] x = { 2, 5, 1, 3, 4, 7 };
            int n = 3;

            //int[] arrOne = new int[n];
            //int[] arrTwo = new int[n];

            //for(int i = 0; i < x.Length; i++)
            //{
            //    if (i >= n)
            //    {
            //        arrTwo
            //    }
            //}
            int i = 1;
            int j = n;
            int temp=0;

            while (i < j)
            {
                temp = x[j];
                for(int k = j-1; k >= i; k--)
                {
                 x[k+1] = x[k] ;
                 
                }

                x[i] = temp;
                i = i + 2;
                j++;
            }
        }
    }
}
