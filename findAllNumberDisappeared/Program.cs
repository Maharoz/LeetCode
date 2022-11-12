namespace findAllNumberDisappeared
{

    //https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 3, 2, 7, 8, 2, 3, 1 };
            // Console.WriteLine("Hello, World!");
            FindDisappearedNumbers(a);
        }

        static IList<int> FindDisappearedNumbers(int[] nums)
        {
            IList<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int val = Math.Abs(nums[i]) - 1;
                if (nums[val] > 0)
                    nums[val] = -nums[val];
            }

            for (int i = 0; i < nums.Length; i++)
                if (nums[i] > 0)
                    result.Add(i + 1);
            return result;
        }
    }
}