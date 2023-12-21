namespace RemoveDuplicateFromSortedArrayII
{
    //https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = {0,0,1,1,1,1,2,2,2,3,3};
            RemoveDuplicates(x);
        }

        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 2)
            {
                return nums.Length;
            }

            int count = 2;

            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[i] != nums[count-2])
                {
                    nums[count] = nums[i];
                    count++;
                }
            }
            return count;
        }
    }
}
