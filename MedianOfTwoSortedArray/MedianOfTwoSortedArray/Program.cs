using System;
using System.Linq;

namespace MedianOfTwoSortedArray
{

    //https://leetcode.com/problems/median-of-two-sorted-arrays/
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int[] a = {1,2 };
            int[] b = { 3,4 };
            FindMedianSortedArrays(a, b);
        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double res = 0.00;
            int[] x =nums1.Concat(nums2).OrderBy(x => x).ToArray();

            if (x.Length % 2 == 0)
            {
                int mid = x.Length / 2;

                int a = x[mid];
                int b = x[mid - 1];
                res = a + b/2;
            }
            else
            {
                int mid = x.Length / 2;
                res = x[mid];
            }

            return res;
        }
    }
}
