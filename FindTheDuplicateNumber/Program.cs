namespace FindTheDuplicateNumber
{

    //https://leetcode.com/problems/find-the-duplicate-number/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 3, 4, 2, 2 };
            Console.WriteLine(FindDuplicate(x));
        }

        static int FindDuplicate(int[] nums)
        {
            Array.Sort(nums);
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    return nums[i];
                }
            }
            return -1;
        }
    }
}