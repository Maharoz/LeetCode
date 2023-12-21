namespace MergeSortedArray
{
    internal class Program
    {
        //https://leetcode.com/problems/merge-sorted-array/
        static void Main(string[] args)
        {
            int[] x = { 0 };
            int[] y = {1};
            int m = 0;
            int n = 1;
            Merge(x,m,y,n);
        }

        static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for(int i = m,j=0; i < nums1.Length; i++,j++)
            {
                nums1[i]= nums2[j];
            }

            Array.Sort(nums1);
        }
    }
}
