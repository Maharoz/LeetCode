namespace remove_element
{

    //https://leetcode.com/problems/remove-element/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0)
                return 0;

            int valid_size = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != val)
                {
                    nums[valid_size] = nums[i];
                    valid_size++;
                }
            }

            return valid_size;
        }
    }
}