namespace ContainerWithMostWater
{

    //https://leetcode.com/problems/container-with-most-water
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a= { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            MaxArea(a);
        }
        public static int MaxArea(int[] height)
        {
            int max =0;
            int left = 0;
            int right = height.Length -1;
            while (left < right)
            {
                int x = Math.Min(height[left], height[right]);
                int width = right - left;
                max = Math.Max(max, width * x);
                if (height[left] < height[right]) {
                    left++;
                }else
                {
                    right--;
                }
            }

            return max;
        }
    }
}
