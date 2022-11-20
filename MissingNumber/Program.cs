namespace MissingNumber
{
    //https://leetcode.com/problems/missing-number/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            Console.WriteLine(MissingNumber(x)); 
        }

        static int MissingNumber(int[] nums)
        {
            Array.Sort(nums);
            int high=nums.Length;
            for(int i = 0; i < high; i++)
            {
                if (!nums.Contains(i))
                {
                    return i;
                }
            }
            return high;
        }
    }
}