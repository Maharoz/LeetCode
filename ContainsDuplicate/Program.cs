namespace ContainsDuplicate
{

    //https://leetcode.com/problems/contains-duplicate-ii/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 1 };
            ContainsNearbyDuplicate(nums, 3);
    }

        static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if (result.ContainsKey(nums[i]))
                {
                   
                    if(Math.Abs(result[nums[i]]-i) <= k)
                    return true;
                }
                result[nums[i]]=i;
            }
            return false;
        }
    }
}