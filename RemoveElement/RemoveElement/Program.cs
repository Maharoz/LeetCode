namespace RemoveElement
{

    //https://leetcode.com/problems/remove-element/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 3,2,2,3 };
            int val = 3;
            RemoveElement(x, val);
        }

        public static int RemoveElement(int[] nums, int val)
        {
            int result = 0;
            foreach (var item in nums)
            {
                if (item != val)
                {
                    nums[result] = item;
                    result++;
                }
            }

            return result;
        }
    }
}
