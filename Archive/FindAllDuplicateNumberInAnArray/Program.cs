namespace FindAllDuplicateNumberInAnArray
{
    //https://leetcode.com/problems/find-all-duplicates-in-an-array/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 10,2,5,10,9,1,1,4,3,7};
            // Console.WriteLine("Hello, World!");
            FindDuplicates(a);
        }

        static IList<int> FindDuplicates(int[] nums)
        {
            IList<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int val = Math.Abs(nums[i]) - 1;
                if (nums[val] > 0)
                    nums[val] = -nums[val];
                else
                {
                    result.Add(val+1);
                }
            }

            return result;
        }
    }
}