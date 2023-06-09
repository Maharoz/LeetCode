using System;

namespace ValidMountainArray
{

    //https://leetcode.com/problems/valid-mountain-array/
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] x =
                {0,1,2,3,4,5,6,7,8,9};
            validMountainArray(x);
        }

        static bool validMountainArray(int[] a)
        {
            if (a.Length < 3) return false;

            int i = 0;

            for (; i < a.Length-1; i++)
            {
                if (a[i] > a[i + 1])
                {
                    i++;
                    break;
                }else if (a[i] == a[i + 1])
                {
                    return false;
                }
            }

            if (i < 2) return false;

            for (; i < a.Length; i++)
            {
                if (a[i - 1] <= a[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
