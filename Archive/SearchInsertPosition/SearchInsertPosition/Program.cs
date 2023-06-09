using System;

namespace SearchInsertPosition
{

    //https://leetcode.com/problems/search-insert-position/
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 5, 6 };
            Array arr = new Array();
            int res = arr.searchInsert(a, 7);
        }
    }

    public class Array
    {
        public int searchInsert(int[] a, int target)
        {
            int pos = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == target)
                {
                    pos = i;
                    return pos;
                }
            }

            for (int j = 0; j < a.Length; j++)
            {
                if (a[0] > target)
                {
                    pos = 0;
                    return pos;
                }

                if (a[a.Length-1] < target)
                {
                    pos = a.Length;
                    return pos;
                }

                if (a[j] < target && a[j + 1] > target)
                {
                    pos = j + 1;
                    return j + 1;
                }
            }
            return pos;
        }
    }
}
