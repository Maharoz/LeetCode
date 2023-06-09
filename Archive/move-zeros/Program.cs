namespace move_zeros
{

    //https://leetcode.com/problems/move-zeroes/
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            int[] a = { 0, 1, 0 };
            MoveZeroes(a);
        }

        static void MoveZeroes(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    for(int j = i; j < nums.Length; j++)
                    {
                       
                        if (j == nums.Length - 1)
                        {
                            nums[j] = 0;
                        }
                        else
                        {
                            nums[j] = nums[j + 1];
                        }

                    }
                }
            }

            //for(int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
        }
    }
}