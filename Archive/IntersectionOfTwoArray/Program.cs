using System.Globalization;

namespace IntersectionOfTwoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 4, 9, 5 };
            int[] nums2 = { 9, 4, 9, 8, 4 };
            Intersect(nums1, nums2);

        }

        static int[] Intersect(int[] nums1, int[] nums2)
        {
           Array.Sort(nums1);
           Array.Sort(nums2);
            List<int> list = new List<int>();
           int i = 0;int j = 0;

            while (i < nums1.Length && j < nums2.Length)
            {
                if(nums1[i] == nums2[j])
                {
                    list.Add(nums1[i]);
                    i++;
                    j++;
                }
                else
                {
                    if (nums1[i] > nums2[j])
                    {
                        j++;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            return list.ToArray();
        }
    }
}