using System;

namespace MergeSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 0 };
            int m = 0,ml=m;
            int[] nums2 = {1 };
            int n =1,nl=n;

            if (n == 0)
            {
                return;
            }

            if (m == 0)
            {
                nums1 = nums2;
                return;
            }

            while (ml<m+n)
            {
                nums1[ml] = nums2[ nl-n];
                ml++;
                nl++;
            }

            Array.Sort(nums1);

        }
    }
}
